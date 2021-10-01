namespace Pubs.Application.Contracts.Pub
{
    public class PubDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string OpeningHours { get; set; }
        public string Address { get; set; }
    }
}
