int[] arr = [1, 2, 3, 4, 1, 10, 15, 8];

Console.WriteLine($"Sun total is {sun(arr)}");

Console.WriteLine($"Find 1 total is {find(arr, 1)}");
Console.WriteLine($"Find 2 total is {find(arr, 2)}");
Console.WriteLine($"Max value is {max(arr)}");

int[] arr2 = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

Console.WriteLine($"Binary Search the index is {binarySearch(arr2, 3, arr2.Length, 0)}");

static int sun(int[] arr, int i = 0)
{
    if (arr.Length == i)
        return 0;
    else
        return arr[i] + sun(arr, i + 1);

}

static int find(int[] arr, int value, int i = 0)
{
    if (arr.Length == i)
        return 0;
    else if (arr[i] == value)
        return 1 + find(arr, value, i + 1);
    else
        return find(arr, value, i + 1);
}

static int max(int[] arr, int i = 0)
{
    if (arr.Length - 1 == i)
        return arr[i];
    else
    {
        var maxValue = max(arr, i + 1);

        if (arr[i] > maxValue)
            return arr[i];
        else
            return maxValue;
    }
}

static int binarySearch(int[] arr, int number, int hig, int low)
{
    if (low > hig)
        return -1;
    else
    {
        int mid = (low + hig) / 2;
        Console.WriteLine($"low={low},hig={hig},mid={mid}");

        if (arr[mid] == number)
            return mid;

        if (arr[mid] > number)
            return binarySearch(arr, number, mid - 1, low);
        else
            return binarySearch(arr, number, hig, mid + 1);
    }
}