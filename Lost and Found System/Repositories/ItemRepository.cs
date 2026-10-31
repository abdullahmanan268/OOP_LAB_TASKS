using System.Collections.Generic;
using System.IO;
using LostAndFoundCSharp.Model;

namespace LostAndFoundCSharp.Repositories
{
    public class ItemRepository
    {
        private readonly string _filePath = "items.txt";

        public List<LostFoundItem> GetAll()
        {
            List<LostFoundItem> items = new List<LostFoundItem>();

            if (!File.Exists(_filePath))
                return items;

            string[] lines = File.ReadAllLines(_filePath);
            if (lines.Length == 0)
                return items;

            int count = int.Parse(lines[0]);
            int lineIndex = 1;
            int i = 0;

            while (i < count && lineIndex + 4 < lines.Length)
            {
                LostFoundItem item = new LostFoundItem();
                item.Name = lines[lineIndex];
                item.Description = lines[lineIndex + 1];
                item.Location = lines[lineIndex + 2];
                item.Date = lines[lineIndex + 3];
                item.Status = lines[lineIndex + 4];
                items.Add(item);
                lineIndex = lineIndex + 5;
                i++;
            }

            return items;
        }

        public void SaveAll(List<LostFoundItem> items)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, false))
            {
                writer.WriteLine(items.Count);
                foreach (LostFoundItem item in items)
                {
                    writer.WriteLine(item.Name);
                    writer.WriteLine(item.Description);
                    writer.WriteLine(item.Location);
                    writer.WriteLine(item.Date);
                    writer.WriteLine(item.Status);
                }
            }
        }
    }
}
