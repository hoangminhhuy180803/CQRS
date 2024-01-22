

namespace Domain.model
{
    public class Product : Entity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Validate(name, price);

            Name = name;
            Price = price;

      
        }

        public void UpdateDetails(string newName, decimal newPrice)
        {
            Validate(newName, newPrice);

            Name = newName;
            Price = newPrice;

           
        }

        private void Validate(string name, decimal price)
        {
             if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Product name cannot be null or empty.", nameof(name));
            }

            if (price <= 0)
            {
                throw new ArgumentException("Product price must be greater than zero.", nameof(price));
            }
        }
    }
}
