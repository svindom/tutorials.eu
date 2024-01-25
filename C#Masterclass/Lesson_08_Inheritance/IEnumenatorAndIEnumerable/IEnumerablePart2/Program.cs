IEnumerableGenericLearn2 enumerableGeneric = new IEnumerableGenericLearn2();

List<int> numbersList = new List<int>() { 8, 6, 2, 9};
int[] numbersArray = new int[] { 22, 23, 24, 45};

int sum = enumerableGeneric.CollectionSum(numbersList);
Console.WriteLine($"Sum of List is {sum}");

Console.WriteLine("--------------------------------------------------------------");

sum = enumerableGeneric.CollectionSum(numbersArray);
Console.WriteLine($"Sum of Array is {sum}");


Console.ReadKey();

class IEnumerableGenericLearn2
{
    public int CollectionSum(IEnumerable<int> anyCollection)
    {
        // sum variable to store the sum of the numbers in anyCollection
        int sum = 0;

        foreach (int num in anyCollection) 
        {
            sum += num;
        }
        return sum;
    }
}
