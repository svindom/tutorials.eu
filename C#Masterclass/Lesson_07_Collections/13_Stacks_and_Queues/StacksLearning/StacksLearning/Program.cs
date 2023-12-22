using System.Diagnostics.CodeAnalysis;

StackAddition stackExample = new StackAddition();
stackExample.AddToStack(1);
stackExample.AddToStack(2);
stackExample.AddToStack(3);

Console.WriteLine($"Top value in the stack is: {stackExample.Stack.Peek()}");  // Peek() method will return the element at the top of the stack without removing it. In our case it will return 3

// To remove item from stack we use the Pop() method
int itemToRemove = stackExample.Stack.Pop();
Console.WriteLine($"Popped item is: {itemToRemove}");
// Let's check if the item was removed
Console.WriteLine($"Top value in the stack is: {stackExample.Stack.Peek()}");

stackExample.RemoveAllItems();
Console.WriteLine($"Display the remains of items in the Stack: {stackExample.Stack.Count}");
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine();


//------------------------------------------------------------------------------------------------------------------------------------------------
// How to reverse stack

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
//Let's define a new stack
Stack<int> myIntStack = new Stack<int>();
Stack<int> reversedStack = new Stack<int>();

for (int i = 0; i < numbers.Length; i++)
{
    myIntStack.Push(numbers[i]);
}
Console.WriteLine($"Items in the Stack: {myIntStack.Count}");

//let's print all items
foreach (int item in myIntStack)
{
    Console.WriteLine($"Displaying the items in the new stack: {item}");
}
Console.WriteLine();

// and now, let's reverse all items in the stack
while (myIntStack.Count > 0)
{
    reversedStack.Push(myIntStack.Pop());
}
//let's print all items
foreach (int item in reversedStack)
{
    Console.WriteLine($"Displaying the reversed items in the new stack: {item}");
}


Console.ReadKey();


public class StackAddition
{
    private Stack<int> _stack; // defining a new stack
    public Stack<int> Stack 
    {
        get 
        { 
            return _stack; 
        } 
    }

    public StackAddition()
    {
        _stack = new Stack<int>();
    }

    public void AddToStack(int stackElement)
    {
        Stack.Push(stackElement); // add element to the stack using Push() 
    }

    public void RemoveAllItems()
    {
        while ( Stack.Count > 0 ) 
        {
            _stack.Pop(); // using the Pop() method we can remove item from the Stack
        }
    }
}
