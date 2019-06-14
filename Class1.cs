using System;

public class QuickSort1
{
    private IComparable[] _array;

    public QuickSort1(IComparable[] a)
    {
        _array = a;

        Randomize();
        QuickSort1(0, a.Length - 1);
    }

    public void QuickSort1(int lo, int hi) //***
    {
        if (hi <= lo) return;

        int partitionValue = Partition(low, hi);

        QuickSort1(lo, partitionValue - 1);
        QuickSort1(partitionValue + 1, hi);
    }

    private void Partition(int lo, int hi) // ***
    {
        while (true)
        {

        }
    }

    private bool Less(IComparable i, IComparable j)
    {
        // If i is less than j, -1 < 0 is true
        return i.CompareTo(j) < 0;
    }

    private void Exchange(int i, int j)
    {
        var temp = _array[i];
        _array[i] = _array[j];
        _array[j] = temp;
    }

    private void Randomize()
    {
        Random rand = new Random();

        for (int q = 0; q < length - 1; q++) // - 1
        {
            int j = rand.Next(q, _array.Length); // ***
            Exchange(q, j);
        }
    }

}
