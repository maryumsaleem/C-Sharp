// 1. Write a C# program that take cost price of a product from user and calculate sale price before and after sales tax based on following formula.
//Sale Price = Cost Price + Profit (25% of the cost price)
//General Sales Tax(GST) = 17 % of Sale Price
//Final Price = Sale Price + GST
Console.WriteLine("Enter Cost of Product");
long costPrice = long.Parse(Console.ReadLine());
double profit=costPrice * 25 / 100;//25% of costPrice
double salePrice = costPrice+profit;
Console.WriteLine($"Sales Price Before Tax: {salePrice}");
double GST=salePrice*17/100;
double finalPrice = salePrice + GST;
Console.WriteLine($"Sales Price after Tax: {finalPrice}");