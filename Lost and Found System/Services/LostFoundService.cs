using System.Collections.Generic;
using LostAndFoundCSharp.Model;
using LostAndFoundCSharp.Repositories;

namespace LostAndFoundCSharp.Services
{
    public class LostFoundService
    {
        private readonly ItemRepository _repository;
        private List<LostFoundItem> items;
        private List<string> history;

        public LostFoundService()
        {
            _repository = new ItemRepository();
            items = _repository.GetAll();
            history = new List<string>();

            history.Add("Added lost item: Wallet");
            history.Add("Added found item: iPhone");
            history.Add("Added found item: Keys");
            history.Add("Added lost item: Laptop Bag");
            history.Add("Added found item: Watch");
            history.Add("Added found item: ID Card");
            history.Add("Claimed item: Water Bottle");
            history.Add("Added lost item: Earphones");

            if (items.Count == 0)
            {
                items.Add(new LostFoundItem("Wallet", "Black Leather", "Canteen", "15/03/2025", "lost"));
                items.Add(new LostFoundItem("iPhone", "iPhone 13 Black", "Library 2nd Floor", "18/03/2025", "found"));
                items.Add(new LostFoundItem("Keys", "Honda Bike Keys", "Parking Lot", "20/03/2025", "found"));
                items.Add(new LostFoundItem("Laptop Bag", "Dell Backpack", "Lab 301", "22/03/2025", "lost"));
                items.Add(new LostFoundItem("Watch", "Casio Silver", "Playground", "25/03/2025", "found"));
                items.Add(new LostFoundItem("ID Card", "Ali Ahmed CNIC", "Main Gate", "26/03/2025", "found"));
                items.Add(new LostFoundItem("Water Bottle", "Blue Milton", "Classroom 204", "27/03/2025", "claimed"));
                items.Add(new LostFoundItem("Earphones", "Boat Airdopes", "Cafeteria", "28/03/2025", "lost"));
                _repository.SaveAll(items);
            }
        }

        public List<LostFoundItem> GetAll()
        {
            return items;
        }

        public bool AddItem(string name, string description, string location, string date, string status)
        {
            if (items.Count >= 100)
                return false;

            items.Add(new LostFoundItem(name, description, location, date, status));
            history.Add("Added " + status + " item: " + name);
            _repository.SaveAll(items);
            return true;
        }

        public bool UpdateItem(int itemNumber, string name, string description, string location, string date)
        {
            if (itemNumber < 1 || itemNumber > items.Count)
                return false;

            LostFoundItem item = items[itemNumber - 1];
            item.Name = name;
            item.Description = description;
            item.Location = location;
            item.Date = date;
            history.Add("Updated item: " + name);
            _repository.SaveAll(items);
            return true;
        }

        public bool DeleteItem(int itemNumber)
        {
            if (itemNumber < 1 || itemNumber > items.Count)
                return false;

            history.Add("Deleted item: " + items[itemNumber - 1].Name);
            items.RemoveAt(itemNumber - 1);
            _repository.SaveAll(items);
            return true;
        }

        public bool ClaimItem(int itemNumber)
        {
            if (itemNumber < 1 || itemNumber > items.Count)
                return false;

            if (items[itemNumber - 1].Status != "found")
                return false;

            items[itemNumber - 1].Status = "claimed";
            history.Add("Claimed item: " + items[itemNumber - 1].Name);
            _repository.SaveAll(items);
            return true;
        }

        public List<LostFoundItem> SearchByName(string name)
        {
            List<LostFoundItem> foundItems = new List<LostFoundItem>();
            foreach (LostFoundItem item in items)
            {
                if (item.Name == name)
                    foundItems.Add(item);
            }
            return foundItems;
        }

        public List<LostFoundItem> GetByStatus(string status)
        {
            List<LostFoundItem> foundItems = new List<LostFoundItem>();
            foreach (LostFoundItem item in items)
            {
                if (item.Status == status)
                    foundItems.Add(item);
            }
            return foundItems;
        }

        public List<string> GetHistory()
        {
            return history;
        }

        public void ClearHistory()
        {
            history.Clear();
        }

        public void SortByName()
        {
            for (int i = 0; i < items.Count - 1; i++)
            {
                for (int j = 0; j < items.Count - i - 1; j++)
                {
                    if (string.Compare(items[j].Name, items[j + 1].Name) > 0)
                    {
                        LostFoundItem temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
            history.Add("Sorted items by name");
            _repository.SaveAll(items);
        }

        public void SortByDate()
        {
            for (int i = 0; i < items.Count - 1; i++)
            {
                for (int j = 0; j < items.Count - i - 1; j++)
                {
                    if (string.Compare(items[j].Date, items[j + 1].Date) > 0)
                    {
                        LostFoundItem temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
            history.Add("Sorted items by date");
            _repository.SaveAll(items);
        }
    }
}
