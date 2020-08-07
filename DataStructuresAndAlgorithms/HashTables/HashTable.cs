using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.HashTables
{
    public class HashTable<T, Y>
    {
        private LinkedList<Entry<T, Y>>[] entries;
        class Entry<T, Y>
        {
            public T Key { get; set; }
            public Y Value { get; set; }
            public Entry(T key, Y value)
            {
                Key = key;
                Value = value;
            }
        }
        public HashTable(int size = 10)
        {
            entries = new LinkedList<Entry<T, Y>>[size];
        }
        public Y this[T key]
        {
            get 
            {
                var entry = GetEntry(key);
                if (entry != null)
                    return entry.Value;
                throw new ArgumentNullException();
            }
            set 
            {
                var entry = GetEntry(key);
                if (entry != null)
                {
                    entry.Value = value;
                    return;
                }  
                throw new ArgumentNullException();
            }
        }
        public void Add(T key, Y value)
        {
            var entry = GetEntry(key);
            if (entry != null)
                throw new InvalidProgramException();

            GetOrCreateBucket(key).AddLast(new Entry<T, Y>(key, value));
        }
        public void Remove(T key)
        {
            var entry = GetEntry(key);
            if (entry == null)
                throw new ArgumentNullException();
            GetBucket(key).Remove(entry);
        }
        private LinkedList<Entry<T, Y>> GetBucket(T key)
        {
            return entries[Hashing(key)];
        }
        private LinkedList<Entry<T, Y>> GetOrCreateBucket(T key)
        {
            var hashedKey = Hashing(key);
            if (entries[hashedKey] == null)
                entries[hashedKey] = new LinkedList<Entry<T, Y>>();
            return entries[hashedKey];
        }
        private int Hashing(T key)
        {
            return Convert.ToInt32(key) % entries.Length;
        } 
        private Entry<T, Y> GetEntry(T key)
        {
            var bucket = GetBucket(key);
            if (bucket != null)
            {
                foreach (var item in bucket)
                {
                    if (item.Key.Equals(key))
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
