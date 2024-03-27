namespace _04_quicksort;

public class QuickSort
{

    public static List<int> Sort(List<int> array)
    {
        if (array.Count < 2)
            return array;
        else
        {
            var pivot = array[0];
            array.RemoveAt(0);

            List<int> smaller = new();
            List<int> grater = new();

            foreach (var i in array)
            {
                if (i <= pivot)
                    smaller.Add(i);
                else
                    grater.Add(i);
            }

            return [.. Sort(smaller), .. new List<int> { pivot }, .. Sort(grater)];
        }

    }
}