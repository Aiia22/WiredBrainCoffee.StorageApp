using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;


namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class SqlRepository<T> where T : class, IEntity
    {

        private readonly List<T> _items = new();

        public T GetById(int id)
        {
            return _items.Single(items => items.Id == id);
        }


        public void Add(T item)
        {
            item.Id = _items.Any()
                ? _items.Max(item => item.Id) + 1
                : 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }


}

