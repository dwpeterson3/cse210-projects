using System;
using System.Collections.Generic;

class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void SaveEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void clearEntries()
    {
        _entries.Clear(); 
    }

    public List<Entry> getEntries()
    {
      return _entries;
    }

    public void dispayEnteries() 
    {
        _entries.ForEach(entry => entry.Display());
    }


}