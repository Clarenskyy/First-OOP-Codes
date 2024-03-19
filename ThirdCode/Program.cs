using System; //using code tells us that codes/syntax that will be used on the code
namespace ThirdCode{
internal class Program
{
	static void Main(string[] args)
	{
        Console.Write("input the 1st number: ");
       int a = Convert.ToInt16(Console.ReadLine());
        Console.Write("input the 2nd number: ");
      int b = Convert.ToInt16(Console.ReadLine());
        int sum;

        sum = a + b;

        Console.WriteLine("the sum of the two number is: " + sum);

   Console.Write("Name: ");

        String name; 
        name = Console.ReadLine();
        Console.WriteLine("Hi, " + name); //String Concatenation
       Console.Write("Enter your age: ");
       int age;
       age = Convert.ToInt16(Console.ReadLine());

       Console.WriteLine("You are " + age + " years old " + name);

       
	   Console.Write("Lastname:");  //does not create a new line for the next syntax, so it will output beside it
       Console.WriteLine("\tDELA CRUZ");  //will create new line after being outputed
       Console.Write("Firstname:"); 
       Console.WriteLine("\tCLARENCE KIETH");// /t means tab /n means new line
       Console.Write("Year and Section:");  //method and tawag sa syntax na may katabi na (, basically lahat ng kulay dilaw
       Console.WriteLine("\tCPE 1-1");  //any comment will be ignore by the computer as it is executed ctrl kc for shortcut sa comment
        //variable stores data type-specific some are String, int, char, datetime, double, float
	}
}
}