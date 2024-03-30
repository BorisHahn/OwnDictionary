namespace OwnDictionary;

public class OtusDictionary
{
    private int initialCapacity = 32;
    private int size;
    private Entry[] entries;

    public OtusDictionary()
    {
        size = 0;
        entries = new Entry[initialCapacity];
    }

    public void Add(int key, string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Значение не может быть пустым");
        }

        if (size >= entries.Length)
        {
            Resize();
        }

        int index = GetBucketIndex(key);
        if (entries[index] != null)
        {
            index = FindAvailableIndex(index);
        }

        entries[index] = new Entry(key, value);
        size++;
    }

    public string Get(int key)
    {
        int index = GetBucketIndex(key);
        while (index < entries.Length)
        {
            Entry entry = entries[index];
            if (entry != null && entry.Key == key)
            {
                return entry.Value;
            }
            index++;
        }
        return null;
    }

    private void Resize()
    {
        int newCapacity = entries.Length * 2;
        Entry[] newEntries = new Entry[newCapacity];
        foreach (Entry entry in entries)
        {
            if (entry != null)
            {
                int index = GetBucketIndex(entry.Key, newCapacity);
                if (newEntries[index] != null)
                {
                    index = FindAvailableIndex(newCapacity, index);
                }
                newEntries[index] = entry;
            }
        }
        entries = newEntries;
    }

    private int GetBucketIndex(int key)
    {
        return GetBucketIndex(key, entries.Length);
    }

    private int GetBucketIndex(int key, int capacity)
    {
        return key % capacity;
    }

    private int FindAvailableIndex(int index)
    {
        while (entries[index] != null)
        {
            index = (index + 1) % entries.Length;
        }
        return index;
    }

    private int FindAvailableIndex(int capacity, int index)
    {
        while (entries[index] != null)
        {
            index = (index + 1) % capacity;
        }
        return index;
    }

    private class Entry
    {
        public int Key { get; }
        public string Value { get; }

        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}