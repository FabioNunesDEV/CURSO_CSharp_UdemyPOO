﻿using System.Globalization;

namespace Entities
{
    class Product
    {
        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Name
                   + ", "
                   + Price.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
