using System;
using System.Collections;
using System.Collections.Generic;

public class ListEnumerator<T> : IEnumerator<T> where T : IComparable<T>
{
    private CustomList<T> _list;
    private int _position = -1; 

    public ListEnumerator(CustomList<T> list)
    {
        _list = list;
    }

    public T Current
    {
        get
        {
            if (_position < 0 || _position >= _list.Count())
                throw new InvalidOperationException();
            return _list.GetElementAt(_position); 
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current; 
        }
    }

    public bool MoveNext()
    {
        _position++;
        return (_position < _list.Count());
    }

    public void Reset()
    {
        _position = -1;
    }
    public void Dispose() { }

    
}
        
    
