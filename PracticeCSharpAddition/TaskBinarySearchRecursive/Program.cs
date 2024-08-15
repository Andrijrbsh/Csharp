int[] numbers = new int[] {1,2,3,4,5};
System.Console.WriteLine("Please input number from 1 to 5, what you need to pick from array");
int rightNumber = int.Parse(Console.ReadLine());

int index = BinarySearch(numbers, 0, numbers.Length - 1, rightNumber);

 if (index != -1)
        {
            Console.WriteLine($"Number {rightNumber} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Number {rightNumber} not found in the array.");
        }

static int BinarySearch(int[] numbers, int left, int right, int rightNumber)
{
    if (left<=right)
    {
       int middle = (left + right)/2;
       if (numbers[middle] == rightNumber)
       {
            return middle;
       }
       else if (numbers[middle] > rightNumber)
       {
            return BinarySearch(numbers, left, middle - 1, rightNumber);
       }
       else
       {
            return BinarySearch(numbers, middle + 1, right, rightNumber);
       }
    }
    return -1;
}
