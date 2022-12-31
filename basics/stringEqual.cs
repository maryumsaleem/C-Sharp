string author1 = "Mahesh Chand";  
string author2 = "Praveen Kumar";  
string author3 = "Mahesh Chand";  
  
// Compare strings using String.Equals  
if (String.Equals(author1, author2))  
    Console.WriteLine($"{author1} and {author2} have same value.");  
else  
    Console.WriteLine($"{author1} and {author2} are different.");  
  
if (String.Equals(author1, author3))  
    Console.WriteLine($"{author1} and {author3} have same value.");  
else  
    Console.WriteLine($"{author1} and {author3} are different.");