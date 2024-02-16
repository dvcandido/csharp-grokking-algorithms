// See https://aka.ms/new-console-template for more information
var arr = new List<int>() { 5, 3, 6, 2, 10 };

Console.WriteLine(string.Join(",", SelectionSort(arr)));

int FindSmallest(List<int> arr)
{
    var smallest = arr[0];
    var smallestIndex = 0;

    for (var i = 0; i < arr.Count; i++)
    {
        if (smallest > arr[i])
        {
            smallest = arr[i];
            smallestIndex = i;
        }
    }

    return smallestIndex;
}

int[] SelectionSort(List<int> arr)
{
    var newArr = new int[arr.Count];

    for (var i = 0; i < newArr.Length; i++)
    {
        var smallest = FindSmallest(arr);
        newArr[i] = arr[smallest];
        arr.RemoveAt(smallest);
    }

    return newArr;
}