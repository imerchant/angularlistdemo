using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularListDemo.Services
{
    public static class ItemsService
    {
        private static List<Item> _items; 
        public static IEnumerable<Item> Items
        {
            get { return _items.AsReadOnly(); }
        }

        static ItemsService()
        {
            _items = new List<Item>();
            _items.Add(new Item { Id = 1, Value = "one"});
            _items.Add(new Item { Id = 2, Value = "two"});
            _items.Add(new Item { Id = 3, Value = "three"});
            _items.Add(new Item { Id = 4, Value = "four"});
        }

        public static void SaveItem(Item item)
        {
            _items.Add(item);
        }

        public static void DeleteItem(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return;
            }

            _items.Remove(item);
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}