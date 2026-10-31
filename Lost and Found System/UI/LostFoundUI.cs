using System;
using System.Collections.Generic;
using LostAndFoundCSharp.Model;
using LostAndFoundCSharp.Services;

namespace LostAndFoundCSharp.UI
{
    public class LostFoundUI
    {
        private readonly LostFoundService _service;
        private int userType = 0;

        public LostFoundUI()
        {
            _service = new LostFoundService();
        }

        public void ShowMenu()
        {
            if (!LoginUI())
                return;

            while (true)
            {
                Console.WriteLine("\n------ LOST AND FOUND MANAGEMENT SYSTEM ------");

                if (userType == 1)
                    Console.WriteLine("Logged in as: ADMIN");
                else
                    Console.WriteLine("Logged in as: USER");

                Console.WriteLine("1. Add Lost Item");
                Console.WriteLine("2. Add Found Item");
                Console.WriteLine("3. View All Items");
                Console.WriteLine("4. Search Item by Name");
                Console.WriteLine("5. Update Item");

                if (userType == 1)
                    Console.WriteLine("6. Delete Item");

                Console.WriteLine("7. Claim Item");

                if (userType == 1)
                {
                    Console.WriteLine("8. View History");
                    Console.WriteLine("9. Sort Items by Name (A-Z)");
                    Console.WriteLine("10. Sort Items by Date");
                }

                Console.WriteLine("11. View Lost Items Only");
                Console.WriteLine("12. View Found Items Only");
                Console.WriteLine("13. View Claimed Items Only");

                if (userType == 1)
                {
                    Console.WriteLine("14. Clear History (Admin Only)");
                    Console.WriteLine("15. Exit");
                }
                else
                    Console.WriteLine("14. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    AddItemUI("lost");
                else if (choice == "2")
                    AddItemUI("found");
                else if (choice == "3")
                    ViewAllItemsUI();
                else if (choice == "4")
                    SearchUI();
                else if (choice == "5")
                    UpdateUI();
                else if (choice == "6" && userType == 1)
                    DeleteUI();
                else if (choice == "7")
                    ClaimUI();
                else if (choice == "8" && userType == 1)
                    HistoryUI();
                else if (choice == "9" && userType == 1)
                    SortByNameUI();
                else if (choice == "10" && userType == 1)
                    SortByDateUI();
                else if (choice == "11")
                    ViewStatusUI("lost", "LOST ITEMS", "No lost items.");
                else if (choice == "12")
                    ViewStatusUI("found", "FOUND ITEMS", "No found items.");
                else if (choice == "13")
                    ViewStatusUI("claimed", "CLAIMED ITEMS", "No claimed items.");
                else if (choice == "14" && userType == 1)
                    ClearHistoryUI();
                else if (choice == "14" && userType != 1)
                {
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
                }
                else if (choice == "15" && userType == 1)
                {
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
                }
                else
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
            }
        }

        private bool LoginUI()
        {
            int attempts = 0;

            Console.WriteLine("============================================");
            Console.WriteLine("    LOST AND FOUND MANAGEMENT SYSTEM");
            Console.WriteLine("============================================");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.Write("Select user type: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                userType = 1;

                while (attempts < 3)
                {
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    if (password == "1234")
                    {
                        Console.WriteLine("Login successful!");
                        return true;
                    }

                    attempts++;
                    Console.WriteLine("Wrong password! Attempts left: " + (3 - attempts));
                }

                Console.WriteLine("Too many failed attempts. Program will exit.");
                return false;
            }
            else if (choice == "2")
            {
                userType = 2;
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid user type.");
                return false;
            }
        }

        private void AddItemUI(string status)
        {
            Console.WriteLine("=== ADD " + status.ToUpper() + " ITEM ===");

            Console.Write("Enter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            if (status == "lost")
                Console.Write("Enter location lost: ");
            else
                Console.Write("Enter location found: ");

            string location = Console.ReadLine();

            Console.Write("Enter date (dd/mm/yyyy): ");
            string date = Console.ReadLine();

            if (_service.AddItem(name, description, location, date, status))
                Console.WriteLine(status + " item added successfully!");
            else
                Console.WriteLine("Storage is full!");
        }

        private void ViewAllItemsUI()
        {
            Console.WriteLine("=== VIEW ALL ITEMS ===");

            List<LostFoundItem> items = _service.GetAll();

            if (items.Count == 0)
                Console.WriteLine("No items in the system.");
            else
            {
                Console.WriteLine("No. | Name | Description | Location | Date | Status");

                for (int i = 0; i < items.Count; i++)
                    PrintItem(i + 1, items[i]);
            }
        }

        private void PrintItem(int number, LostFoundItem item)
        {
            Console.WriteLine(number + ". " + item.ToString());
        }

        private void SearchUI()
        {
            Console.Write("Enter item name to search: ");
            string name = Console.ReadLine();

            List<LostFoundItem> foundItems = _service.SearchByName(name);

            if (foundItems.Count == 0)
                Console.WriteLine("Item not found!");
            else
            {
                foreach (LostFoundItem item in foundItems)
                {
                    Console.WriteLine("Item Found!");
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private void UpdateUI()
        {
            List<LostFoundItem> items = _service.GetAll();

            if (items.Count == 0)
            {
                Console.WriteLine("No items to update.");
                return;
            }

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine((i + 1) + ". " + items[i].Name + " (" + items[i].Status + ")");

            Console.Write("Enter item number to update: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > items.Count)
            {
                Console.WriteLine("Invalid item number!");
                return;
            }

            Console.Write("Enter new name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new description: ");
            string description = Console.ReadLine();

            Console.Write("Enter new location: ");
            string location = Console.ReadLine();

            Console.Write("Enter new date (dd/mm/yyyy): ");
            string date = Console.ReadLine();

            if (_service.UpdateItem(number, name, description, location, date))
                Console.WriteLine("Item updated successfully!");
            else
                Console.WriteLine("Invalid item number!");
        }

        private void DeleteUI()
        {
            List<LostFoundItem> items = _service.GetAll();

            if (items.Count == 0)
            {
                Console.WriteLine("No items to delete.");
                return;
            }

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine((i + 1) + ". " + items[i].Name + " (" + items[i].Status + ")");

            Console.Write("Enter item number to delete: ");
            int number = int.Parse(Console.ReadLine());

            if (_service.DeleteItem(number))
                Console.WriteLine("Item deleted successfully!");
            else
                Console.WriteLine("Invalid item number!");
        }

        private void ClaimUI()
        {
            List<LostFoundItem> items = _service.GetAll();
            bool found = false;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Status == "found")
                {
                    Console.WriteLine((i + 1) + ". " + items[i].Name + " - Found at: " + items[i].Location);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No found items available to claim.");
                return;
            }

            Console.Write("Enter item number to claim: ");
            int number = int.Parse(Console.ReadLine());

            if (_service.ClaimItem(number))
                Console.WriteLine("Item claimed successfully!");
            else
                Console.WriteLine("This item is not available for claiming or item number is invalid!");
        }

        private void HistoryUI()
        {
            List<string> history = _service.GetHistory();

            Console.WriteLine("=== ACTIVITY HISTORY ===");

            if (history.Count == 0)
                Console.WriteLine("No history available.");
            else
            {
                for (int i = 0; i < history.Count; i++)
                    Console.WriteLine((i + 1) + ". " + history[i]);
            }
        }

        private void SortByNameUI()
        {
            _service.SortByName();

            Console.WriteLine("Items sorted by name successfully!");

            List<LostFoundItem> items = _service.GetAll();

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine((i + 1) + ". " + items[i].Name + " (" + items[i].Status + ")");
        }

        private void SortByDateUI()
        {
            _service.SortByDate();

            Console.WriteLine("Items sorted by date successfully!");

            List<LostFoundItem> items = _service.GetAll();

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine((i + 1) + ". " + items[i].Name + " | " + items[i].Date + " | " + items[i].Status);
        }

        private void ViewStatusUI(string status, string title, string noMessage)
        {
            Console.WriteLine("=== " + title + " ===");

            List<LostFoundItem> items = _service.GetByStatus(status);

            if (items.Count == 0)
                Console.WriteLine(noMessage);
            else
            {
                foreach (LostFoundItem item in items)
                    Console.WriteLine(item.ToString());
            }
        }

        private void ClearHistoryUI()
        {
            _service.ClearHistory();
            Console.WriteLine("History cleared successfully!");
        }
    }
}