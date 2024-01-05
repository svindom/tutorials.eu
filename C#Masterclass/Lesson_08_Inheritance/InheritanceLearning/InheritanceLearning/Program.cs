Radio radio = new Radio(false, "BBC");
radio.Brand = "BBC4";

// we are using the method from the base class
radio.SwitchOn();
// we are using the method from the child class
radio.ListenRadio();



// the same can be done with the TV

Console.ReadKey();





// Parent - Base class
public class ElectricalDevice
{
    // boolean to determine the state of the device
    public bool IsOn { get; set; }
    // string for the brand name of the device
    public string Brand { get; set; }

    public ElectricalDevice(bool isOn, string brand)
    {
        IsOn = isOn;
        Brand = brand;
    }

    // switch on the device
    public void SwitchOn()
    {
        IsOn = true;
    }
    // switch off the device
    public void SwitchOff()
    {
        IsOn = false;
    }
}

// Child Class (inherited from the ElectricalDevice class)
public class Radio : ElectricalDevice
{
    public Radio(bool isOn, string brand):base(isOn,brand)
    {
    }


    public void ListenRadio()
    {
        if (IsOn) 
        {
            Console.WriteLine($"Listening to the {Brand} radio");
        }
        else
        {
            Console.WriteLine("Radio is switched off, you need to switch it on first");
        }
    }
}


// Child Class (inherited from the ElectricalDevice class)
public class TV : ElectricalDevice
{
    public TV(bool isOn, string brand): base(isOn, brand)
    {
    
    }
    public void WatchingTV()
    {
        if (IsOn)
        {
            Console.WriteLine("Listening to the TV");
        }
        else
        {
            Console.WriteLine("TV is switched off, you need to switch it on first");
        }
    }
}


