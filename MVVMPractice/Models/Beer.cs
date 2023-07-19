namespace MVVMPractice.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }

        public Beer()
        {

        }

        public Beer(int id, string name, string description, string brand)
        {
            Id = id;
            Name = name;
            Description = description;
            Brand = brand;
        }
    }
}
