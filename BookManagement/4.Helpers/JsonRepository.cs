using BookManagement._3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement._4.Helpers
{
    public class JsonRepository<T> where T : IEntity
    {
        private readonly string _filePath;

        public JsonRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<T> Load()
        {
            return JsonStorage<T>.Load(_filePath);
        }

        public void Save(List<T> items)
        {
            JsonStorage<T>.Save(_filePath, items);
        }

        public void Add(T item)
        {
            var items = Load();
            int newId = items.Any() ? items.Max(x => x.Id) + 1 : 1;
            item.Id = newId;
            items.Add(item);
            Save(items);
        }

        public void Update(T item)
        {
            var items = Load();
            var index = items.FindIndex(x => x.Id == item.Id);
            if (index >= 0)
            {
                items[index] = item;
                Save(items);
            }
            else
            {
                throw new Exception("Không tìm thấy bản ghi để cập nhật.");
            }
        }

        public void Delete(int id)
        {
            var items = Load();
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                items.Remove(item);
                Save(items);
            }
            else
            {
                throw new Exception("Không tìm thấy bản ghi để xóa.");
            }
        }
    }
}
