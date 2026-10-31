namespace LostAndFoundCSharp.Model
{
    public class LostFoundItem
    {
        public string Name;
        public string Description;
        public string Location;
        public string Date;
        public string Status;

        public LostFoundItem() { }

        public LostFoundItem(string name, string description, string location, string date, string status)
        {
            Name = name;
            Description = description;
            Location = location;
            Date = date;
            Status = status;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                   "\nDescription: " + Description +
                   "\nLocation: " + Location +
                   "\nDate: " + Date +
                   "\nStatus: " + Status;
        }
    }
}