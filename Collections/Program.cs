namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ShoppingItem> shoppingList = new()
            {
                new ShoppingItem { Name = "Bread", Price = 1.99M, Quantity = 3 },
                new ShoppingItem { Name = "Milk", Price = 0.99M, Quantity = 2 },
                new ShoppingItem { Name = "Bananas", Price = 2.49M, Quantity = 1 },
                new ShoppingItem { Name = "Apples", Price = 1.49M, Quantity = 2 }
            };

            Console.WriteLine("Shopping List:");
            foreach (ShoppingItem item in shoppingList)
            {
                Console.WriteLine($"{item.Name} - ${item.Price} x {item.Quantity}");
            }
        }
    }
}