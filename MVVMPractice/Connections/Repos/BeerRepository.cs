using MVVMPractice.Models;
using System;

namespace MVVMPractice.Connections.Repos

{
    public class BeerRepository : IBeerRepository
    {
        public Beer GetBeer()
        {
            return new Beer();
        }

        public Beer GetRandomBeer()
        {
            var isPar = DateTime.Now.Millisecond % 2 == 0;
            var newName = isPar ? "Par" : "Impar";
            var description = isPar ? "Par description" : "Impar desc";
            var brand = isPar ? "Brand description par" : "Impar desc brand";

            Beer beer = new Beer()
            {
                Id = DateTime.Now.Millisecond,
                Name = $"New name {newName}",
                Description = description,
                Brand = brand
            };

            return beer;
        }
    }
}
