IEnumerableGenericLearn1 enumerableLearning = new IEnumerableGenericLearn1();
IEnumerable<int> unknownCollection;

// here we get List
unknownCollection = enumerableLearning.GetCollection(1);
foreach (int num in unknownCollection)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Console.WriteLine("------------------------------------------------------");

// here we get Queue
unknownCollection = enumerableLearning.GetCollection(2);
foreach (int num in unknownCollection)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Console.WriteLine("------------------------------------------------------");

// here we get Array as a default option, which we declared in the IEnumerableGenericLearn class early
unknownCollection = enumerableLearning.GetCollection(5);
foreach (int num in unknownCollection)
{
    Console.Write(num + " ");
}
Console.ReadLine();



class IEnumerableGenericLearn1
{
    public IEnumerable<int> GetCollection(int option)
    {
        List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5};

        Queue<int> numbersQueue = new Queue<int>();
        // add value to the queue
        List<int> listIntForQueue = new List<int>() { 6, 7, 8, 9, 10 };
        foreach (int number in listIntForQueue)
        {
            numbersQueue.Enqueue(number);
        }

        //if the option is 1
        if (option == 1)
        {
            //return the list of type List<int>
            Console.WriteLine("return the list of type List<int>");
            return numbersList;
        }
        else if (option == 2)
        {
            // return the queue of type<int>
            Console.WriteLine("return the queue of type<int>");
            return numbersQueue;
        }
        // return an array of numbers initialized with some numbers
        Console.WriteLine("eturn an array of numbers initialized with some numbers");
        return new int[] { 11, 12, 13, 14, 15 };
    }
}