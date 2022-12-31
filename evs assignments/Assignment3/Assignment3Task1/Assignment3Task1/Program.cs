using Assignment3Task1;
Console.WriteLine("Enter 1 for pending\nEnter 2 for Approved\nEnter 3 for Rejected");
int n=int.Parse(Console.ReadLine());
Advertisement d = (Advertisement)n;//int to enum
Console.WriteLine(d);
