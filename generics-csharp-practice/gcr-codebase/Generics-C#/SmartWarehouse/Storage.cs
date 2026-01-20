
using System.Collections.Generic;

class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void ShowAll()
    {
        foreach (var item in items)
            item.Display();
    }
}
