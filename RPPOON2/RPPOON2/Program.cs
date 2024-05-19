//2 PREIM

class Product
{
    public string Name { get; private set; } // prod. name
    public string Price { get; private set; } // prod. price
    public bool IsStocked { get; set; } // flag - is prod. in stock or not?

    public Product(string name, string price)
    {
        this.Name = name;
        this.Price = price;
        this.IsStocked = false;
    }
}

class Inventory
{
    List<Product> products; // List of prods.,

    public Inventory(List<Product> products) // inventory of prods.
    {
       products = products;
    }

    public void Resock(Product product)
    {
        foreach (Product products in products)
        { // make prod. available again
            if (product == products)
                products.IsStocked = true;
        }
    }
    public void RemoveAllProducts()
    { // expel the sold out products !!!
        products.RemoveAll(product => product.IsStocked == false);
    }
}
