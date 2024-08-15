List<int> numbers = new List<int>(){5,4,9};
double average;
int sum = SumAndAverageFromList(numbers, numbers.Count-1, out average);
System.Console.WriteLine("Sum is {0}, Average is {1}", sum, average);

static int SumAndAverageFromList(List<int> numbers, int index, out double average)
{
    if (index < 0)
    {
        average = 0;
        return 0;
    }
    int sum = numbers[index] + SumAndAverageFromList(numbers, index - 1, out average);

    if (index == numbers.Count - 1)
    {
        average = (double)sum / numbers.Count;
    }

    return sum;
}

