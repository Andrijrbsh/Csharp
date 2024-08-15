List<int> numbers = new List<int>(){5,4,9};
int sum = SumFromList(numbers, numbers.Count - 1);
System.Console.WriteLine("Sum is {0}", sum);

static int SumFromList(List<int> numbers, int index)
{
    if (index < 0)
    {
        return 0;
    }
    return numbers[index] + SumFromList(numbers, index - 1);
}
