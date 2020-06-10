class MyArray
{
    int[] arr;

    public MyArray(int size)
    {
        arr = new int[size];
    }

    public int this[int index]
    {
        get
        {
            return arr[index];
        }
    }

    public int this[int index, int number]
    {
        set
        {
            arr[index] = number * number;
        }
    }
}