using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;


public class MySortedList<Tkey, Tvalue> : IDictionary<Tkey, Tvalue>
{

    SortedList<Tkey, Tvalue> s= new SortedList<Tkey,Tvalue>();
    public Tvalue this[Tkey key] { get => s[key] ; set => s[key] =value; }

    public ICollection<Tkey> Keys => s.Keys;

    public ICollection<Tvalue> Values => s.Values;

    public int Count => s.Count;

    public bool IsReadOnly => false;

    public void Add(Tkey key, Tvalue value)
    {
       s.Add(key, value);
    }

    public void Add(KeyValuePair<Tkey, Tvalue> item)
    {
        ((ICollection<KeyValuePair<Tkey, Tvalue>>)s).Add(item);
    }

    public void Clear()
    {
        s.Clear();
    }

    public bool Contains(KeyValuePair<Tkey, Tvalue> item)
    {
        return s.Contains(item);
    }

    public bool ContainsKey(Tkey key)
    {
       return s.ContainsKey(key);
    }

    public void CopyTo(KeyValuePair<Tkey, Tvalue>[] array, int arrayIndex)
    {
        ((ICollection<KeyValuePair<Tkey, Tvalue>>)s).CopyTo(array, arrayIndex);    
    }

    public IEnumerator<KeyValuePair<Tkey, Tvalue>> GetEnumerator()
    {
        return s.GetEnumerator();
    }

    public bool Remove(Tkey key)
    {
       return s.Remove(key);
    }

    public bool Remove(KeyValuePair<Tkey, Tvalue> item)
    {
        return ((ICollection<KeyValuePair<Tkey, Tvalue>>)s).Remove(item);
    }

    public bool TryGetValue(Tkey key, [MaybeNullWhen(false)] out Tvalue value)
    {
        return s.TryGetValue(key, out value);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}




public class Program
{

  static  IEnumerable<int> sh()
    {
        yield return 1;
        yield return 2; 
        yield return 3; 
        yield return 4; 
        yield return 5;
    }
    public static void Main(string[] args)
    {
        IEnumerator<int> e = sh().GetEnumerator();

        e.MoveNext();
        Console.WriteLine(e.Current);
        e.MoveNext();
        Console.WriteLine(e.Current);    
            

        foreach (int i in sh())
        {
            Console.WriteLine(i);
        }

        MySortedList<int,string> m = new MySortedList<int,string>();

        m.Add(1, "one");
        m.Add(2, "two");
        m.Add(3, "three");
        foreach(KeyValuePair<int,string> i in m)
        {
            Console.WriteLine(i.Key + " " + i.Value);
        }
    }
}