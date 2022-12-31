using Assignment3Task2;
//Product p=new Product();
//p.CostPrice = -200;
Product[] products = new Product[10];
int j = 1;
for(int i = 0; i < products.Length; i++)
{
    Product p = new Product();
    Console.WriteLine($"Enter Code of Product:{j}");
    p.Code = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Name of Product:");
    p.Name = Console.ReadLine();
    Console.WriteLine("Enter Cost Price of Product:");
    p.CostPrice= Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Enter GST Rate of Product:");
    p.GstRate = Convert.ToSingle(Console.ReadLine());

    products[i] = p;
    j++;
}
Console.Clear();
int k = 1;
foreach(Product p in products)
{
 Console.WriteLine($"Code{k}:{p.Code}\nName:{p.Name}\nCost Price:{p.CostPrice}\nGST Ammount:{p.GstAmmount}\nSale Price:{p.SalePrice}\n");
    k++;
}