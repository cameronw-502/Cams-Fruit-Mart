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
            int totalCouponAmount = 0;
            if (answer == "Y")
            {
                Console.WriteLine("How many coupons do you have?");
                int coupNum = Convert.ToInt32(Console.ReadLine());
                int x = 0;
                
                while (x < coupNum)
                {
                    Console.WriteLine("Enter coupon   " + x + " amount: ");
                    int coupTotal = Convert.ToInt32(Console.ReadLine());
                    totalCouponAmount = totalCouponAmount + coupTotal;
                    x++;
                }
                
            }
            else
            {
                Console.WriteLine("Complete Payment!");
            }
            
            Console.WriteLine("===============================================");
            Console.WriteLine("Discounts: $ " + totalCouponAmount);
            double newSub = total - totalCouponAmount;
            Console.WriteLine("Subtotal: $" + newSub);
            double newTax = newSub * 0.06;
            Console.WriteLine("Tax: $" + newTax);
            double grandTotal = newTax + newSub;
            Console.WriteLine("Grand Total: $" + grandTotal);
            

        }

        public static void checkout(int total)
        {
            Console.WriteLine("How would you like to check out?");
            Console.WriteLine("1 -- Credit Card");
            Console.WriteLine("2 -- Check");
            Console.WriteLine("3 -- Cash");
            int checkoutResponse = Convert.ToInt32(Console.ReadLine());
        }
        
    }
}