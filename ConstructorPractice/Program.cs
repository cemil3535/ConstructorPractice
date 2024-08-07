// See https://aka.ms/new-console-template for more information
 using ConstructorPractice;
using System.Threading.Channels;
public class Program 
{ 
    public static void Main(string[] args)
    {
        // The object is defined with the default constructor
        Baby baby1 = new Baby();

        Console.WriteLine("-----------------------------------------");

        //The object is defined with a constructor that takes parameters.
        Baby baby2 = new Baby("Ali", "Guzel"); 
    }
   
}



