using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    // First Order Detail
        Address address1 = new Address("Die Vogel Straße", "Feldkich", "Voralberg", "Österreich");
        address1.GetDisplay();
        Customer customer1 = new Customer("Noel Steiner", address1);
        Product product1 = new Product("Mirror",14452,8.99,1); 
        Product product2 = new Product("Ukulele", 12445, 149.99, 2);
        Product product3 = new Product("barbie", 1789, 13.99,2);
        Order order1 =new Order();
        order1.SetProductToList(product1);
        order1.SetProductToList(product2);
        order1.SetProductToList(product3);

        //Order Label
        Console.WriteLine("Packing Label: ");
        order1.Total(customer1);
        order1.packingLabel();

        //Shipping Address
        order1.shippingLabel(customer1);
        Console.WriteLine();
    
    // Second order
        Address address2 = new Address("Road of St. James", "Riverton", "Nebraska", "USA");
        address1.GetDisplay();
        Customer customer2 = new Customer("Joana Castro", address2);
        Product product4 = new Product("Auch Puntlichkeit Kann Toten ",5578,12.99,1); 
        Product product5 = new Product("A Hora da Estrela", 6512, 15.49, 1);
        Product product6 = new Product("USB-C Cable", 5412, 15.99,2);
        Order order2 =new Order();
        order2.SetProductToList(product4);
        order2.SetProductToList(product5);
        order2.SetProductToList(product6);

        //Order Label
        Console.WriteLine("Packing Label: ");
        order2.Total(customer2);
        order2.packingLabel();

        //Shipping Address
        order2.shippingLabel(customer2);
    
    }
}