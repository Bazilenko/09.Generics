using System;

public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }
    public Box() { }

   
    public void Swap(List<Box<T>> list, int index1, int index2)
    {
        Box<T> temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }

    public int CompareTo(Box<T> box)
    {
        if (box is null)
            throw new ArgumentNullException("Invalid parameter!");
        return this.Value.CompareTo(box.Value);
        
    }

    public int Compare(List<Box<T>> list, Box<T> element)
    {   
        int k = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].CompareTo(element) == 1)
            {
                k++;
            }
        }
        return k;
    }


    public override string ToString()
    {
        return $"{GetType().FullName}: {Value}";
    }
}
