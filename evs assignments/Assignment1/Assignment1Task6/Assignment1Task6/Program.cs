//6.Write a console application to take login id, password, confirm password, date of birth of user as input and validate data as per following validation rules and show appropriate messages after validation. 
//Length of login id must be between 7 to 30 characters 
//Password length can't be less then 7 characters
//Password and Confirm Password must match
//User age must be above 13 years

Console.WriteLine("Enter Login ID in charachters:");
string? loginId =Console.ReadLine();
if(loginId?.Length<7 || loginId?.Length>30)
{
    Console.WriteLine("Length of login id must be between 7 to 30 characters ");
    System.Environment.Exit(0);
}
else
{
    Console.WriteLine($"Login id: {loginId}");
}

Console.WriteLine("Enter Password in charachters:");
string? password = Console.ReadLine();
if(password?.Length<7)
{
    Console.WriteLine("Password length can't be less then 7 characters");
    System.Environment.Exit(0);
}
else
{
    Console.WriteLine($"Password: {password}");
}

string? confirmpassword = Console.ReadLine();
if(string.Equals(password,confirmpassword))
{
    Console.WriteLine($"Password: {confirmpassword}");
    System.Environment.Exit(0);
}
else
{
    Console.WriteLine("Password does not match");
}

Console.WriteLine("Enter your age");
int age=int.Parse(Console.ReadLine());
if(age<13)
{
    Console.WriteLine("User age must be above 13 years");
    System.Environment.Exit(0);
}
else
{
    Console.WriteLine($"Age: {age}");
}


