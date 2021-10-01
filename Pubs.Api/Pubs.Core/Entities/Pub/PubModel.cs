namespace Pubs.Core.Entities.Pub
{
    public class PubModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string OpeningHours { get; set; }        
        public string Address { get; set; }

        public PubModel(int id, string name, int capacity, string openingHours, string address)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            OpeningHours = openingHours;
            Address = address;
        }
    }
}
