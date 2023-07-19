
namespace MVVMPrismP2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"User information: {Id} - {Name} - {LastName} - {Email}";
        }
    }
}
