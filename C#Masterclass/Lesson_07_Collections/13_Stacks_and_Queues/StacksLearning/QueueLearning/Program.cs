
using System.Runtime.CompilerServices;

// How to work with Queue

QueueAddition queueOfInt = new QueueAddition();

queueOfInt.PrintItemOfQueue();

queueOfInt.AddIntToQueue(1);
queueOfInt.PrintItemOfQueue();

queueOfInt.AddIntToQueue(2);
queueOfInt.PrintItemOfQueue();

queueOfInt.AddIntToQueue(3);
queueOfInt.RemoveItemFromQueue();
queueOfInt.PrintItemOfQueue();

queueOfInt.RemoveAllItemsFromQueue();

Console.WriteLine();


// Let's work with the Order class

Queue<Order> orderQueue = new Queue<Order>();
OrderArray orderArray = new OrderArray();

foreach (Order order in orderArray.OrdersFromBranch1)
{
    // add each order to the queue
    orderQueue.Enqueue(order);
}

foreach (Order order in orderArray.OrdersFromBranch2)
{
    // add each order to the queue
    orderQueue.Enqueue(order);
}

// as long as the queue is not empty
while (orderQueue.Count > 0)
{
    // remove the order At the front of the queue
    // add store it in a variable called currentOrder
    Order currentOrder = orderQueue.Dequeue();
    
    // print (process) the order
    currentOrder.PrintProcessOrder();
}




Console.ReadKey();


public class QueueAddition
{
    private Queue<int> _queueInt;
    public Queue<int> Queue { get { return _queueInt; } }

    public QueueAddition()
    {
        _queueInt = new Queue<int>();
    }
    public void AddIntToQueue (int intOfQueue)
    {
        // this is how to add the element to a queue
        _queueInt.Enqueue(intOfQueue);
    }
    public void PrintItemOfQueue()
    {
        // this is how we print the element at the front of the queue
        // Will always show the first edded item
        if (_queueInt.Count > 0) 
        {
            Console.WriteLine($"The value at the front of the queue is: {Queue.Peek()}");
        }
        else
        {
            Console.WriteLine("The queue is empty");
            Console.WriteLine();
        }

    }
    public void RemoveItemFromQueue()
    {
        int queueuItem = _queueInt.Dequeue();
    }

    public void RemoveAllItemsFromQueue()
    {
        while (_queueInt.Count > 0)
        {
            Console.WriteLine();
            // Dequeue() will return the element that was removed from the queue
            Console.WriteLine($"The front value {_queueInt.Dequeue()} was removed from the queue");

            // Print the queue count
            Console.WriteLine($"Current queue count is: {_queueInt.Count}");
        }
    }
}

public class Order
{
    public int OrderID {  get; set; }
    public int OrderQuantity { get; set; }

    public Order(int orderID, int orderQuantity) 
    {
        this.OrderID = orderID;
        this.OrderQuantity = orderQuantity;
    }

    public void PrintProcessOrder()
    {
        Console.WriteLine($"Order {OrderID} was processed!");
    }
}

public class OrderArray
{
    // fields
    private Order[] _ordersFromBranch1 = new Order[] { new Order(1, 5), new Order(2, 4), new Order(6, 10) };
    private Order[] _ordersFromBranch2 = new Order[] { new Order(3,5), new Order(4, 4), new Order(5, 10) };

    // properties
    public Order[] OrdersFromBranch1 { get {return _ordersFromBranch1;} }
    public Order[] OrdersFromBranch2 { get { return _ordersFromBranch2;} }

}
