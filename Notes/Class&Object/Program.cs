using System;

namespace Program;

class program
{
  
  static void Main(String[] args)
  {
     book book1 = new book("John",2021,"USA") // Creating object of book class construnctor;
       
       book1.EmpID = 2303; // changing valu; 
       
     Console.WriteLine(book1.EmpID); // printing the value;
        
  }
    


}
