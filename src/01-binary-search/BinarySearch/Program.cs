// See https://aka.ms/new-console-template for more information

int BinarySearch(int[] arr, int number)
{
    int low = 0;
    int hig = arr.Length - 1;

    while (low <= hig)
    {
        int mid = (low + hig) / 2;
        int guess = arr[mid];

        if (guess == number)
        {
            return mid;
        }
        if (guess > number)
        {
            hig = mid - 1;
        }
        else
        {
            low = mid + 1;
        }
    }

    return -1;
}

int[] arr = { 1, 3, 5, 7, 9 };

Console.WriteLine(BinarySearch(arr, 3)); // 1
Console.WriteLine(BinarySearch(arr, -1)); //-1