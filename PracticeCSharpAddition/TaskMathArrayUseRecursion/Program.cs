int[] numbers = {3,5,6};
int sum = SumAllNumFromArray(numbers, numbers.Length - 1);
Console.WriteLine("Sum is {0}", sum);
static int SumAllNumFromArray(int[] numbers, int index)
{
    if (index < 0)
    {
        return 0;
    }
    return numbers[index] + SumAllNumFromArray(numbers, index - 1);
}
