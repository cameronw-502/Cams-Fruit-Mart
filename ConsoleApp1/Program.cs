using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Register!");
            Console.WriteLine("Enter any key to continue.");
            Console.Write("The current date and time is: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();
            
            Console.WriteLine("How many items are you Purchasing?");
            int response = Convert.ToInt32(Console.ReadLine());
            
            int i = 0;
            double total = 0;
            while(i < response)
            {
                Console.WriteLine("Please enter price of " + i + " out of " + response);
                double price = Convert.ToDouble(Console.ReadLine());
                
                total = total + price;
                i++;
                Console.WriteLine("Subtotal: $" + total);
                
            }
            Console.WriteLine("===================================================");
            Console.WriteLine("Subtotal: $" + total);
            double tax = total * 0.06;
            Console.WriteLine("6% Sales Tax: $" + tax);
            double finalTotal = total + tax;
            Console.WriteLine("Total: $" + finalTotal);
            
            Console.WriteLine("Do you have any coupons? (Y/N)");
            String answer = Console.ReadLine();
            if (answer == "Y")
            {
                Console.WriteLine("How many coupons do you have?");
                int coupNum = Convert.ToInt32(Console.ReadLine());
                int x = 0;
                while (x < coupNum)
                {
                    Console.WriteLine("Enter coupon  # " + x + "percentage: ");
                    int percent
                }
                
            }
            else
            {
                Console.WriteLine("Complete Payment!");
            }
        }
        
    }
}