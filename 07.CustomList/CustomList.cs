using System;
using System.Collections;

public class CustomList<T> : IEnumerable<T> where T : IComparable<T>
{
    private List<T> elements;

    public CustomList()
    {
        elements = new List<T>();
    }

    public void Add(T element)
    {
        elements.Add(element);
    }

    public void Remove(int index)
    {
        if (index >= 0 && index < elements.Count)
        {
            elements.RemoveAt(index);
        }
        throw new ArgumentOutOfRangeException("Invalid index.");
    }

    public bool Contains(T element)
    {
        return elements.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        if (index1 >= 0 && index1 < elements.Count && index2 >= 0 && index2 < elements.Count)
        {
            T temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Invalid indices.");
        }
    }
    public void Sort()
    {
        elements.Sort();
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        for (int i = 0; i < elements.Count; ++i)

            if (elements[i].CompareTo(element) > 0)
            {
                count++;
            }   


        return count;
    }

    public T Max()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("List is empty.");

        T max = elements[0];

        for (int i = 1; i < elements.Count; ++i)
        {
            if (max.CompareTo(elements[i]) < 0) 
            {
                max = elements[i];
            }
        }

        return max;
    }


    public T Min()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("List is empty.");

        T min = elements[0];

        for (int i = 1; i < elements.Count; ++i)
        {
            if (min.CompareTo(elements[i]) > 0)
            {
                min = elements[i];
            }
        }

        return min;
    }
    public int CompareTo(T element)
    {
        if (element is null)
            throw new ArgumentException("Invalid parameter");

        return this.CompareTo(element);
    }

    public void Print()
    {
        foreach (var item in elements)
        {
            Console.WriteLine(item);
        }

    }
    public T GetElementAt(int index)
    {
        if (index >= 0 && index < elements.Count)
        {
            return elements[index];
        }
        throw new ArgumentOutOfRangeException("Invalid index.");
    }
    public IEnumerator<T> GetEnumerator()
    {
        return elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }



}


