using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //    Console.WriteLine("Radius:");
            //    double radius = Convert.ToDouble(Console.ReadLine());
            //    Shape shape1 = new Shape(radius);
            //    double circleArea = shape1.CalculateArea();
            //    Console.WriteLine($"The area of circle: {circleArea}");

            //    Console.WriteLine("Length:");
            //    double length = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Width:");
            //    double width = Convert.ToDouble(Console.ReadLine());
            //    Shape shape2 = new Shape(length,width);
            //    double rectangleArea = shape2.CalculateArea();
            //    Console.WriteLine($"The area of rectangle: {rectangleArea}");
            //}
            #endregion
            #region Task2

            //VisaCard visaCard = new VisaCard(1000);


            //visaCard.Pay(50);
            //visaCard.CheckBalance();
            

            //Console.WriteLine();


            //MasterCard masterCard = new MasterCard(1500);


            //masterCard.Pay(100);
            //masterCard.CheckBalance();
            

            #endregion
        }
        #region Task1
        //class Shape
        //{


        //    public double Radius { get; set; }
        //    public double Length { get; set; }
        //    public double Width { get; set; }
        //public Shape()
        //{

        //}
        //public Shape(double radius)
        //{
        //    Radius = radius;
        //}

        //public Shape(double length, double width)
        //{
        //    Length = length;
        //    Width = width;
        //}

        //public virtual double CalculateArea()
        //    {
        //        return 0;
        //    }
        //}
        //abstract class Circle : Shape
        //{

        //public override double CalculateArea()
        //    {
        //        double area = Math.PI * Math.Pow(Radius, 2);

        //        return area;
        //    }

        //}
        //abstract class Rectangle : Shape
        //{


        //public override double CalculateArea()
        //    {
        //        double area = Length * Width;
        //        return area;
        //    }
        //}
        #endregion
        #region Task2
        //public interface BankCard
        //{
        //    void Pay(double amount);
        //    double CheckBalance();
        //}


        //public class VisaCard : BankCard
        //{
        //    public double Balance;


        //    public VisaCard(double balance)
        //    {
        //        Balance = balance;
        //    }


        //    public void Pay(double amount)
        //    {
        //        if (Balance >= amount)
        //        {
        //            Balance -= amount;
        //            Console.WriteLine($"Visa Card payment {amount}");
        //        }
                
        //    }

        //    public double CheckBalance()
        //    {
        //        Console.WriteLine($"Visa Card Balance: {Balance}");
        //        return Balance;
        //    }


            
        }


        public class MasterCard : BankCard
        {
            public double Balance;


            public MasterCard(double balance)
            {
                Balance = balance;
            }


            public void Pay(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Mastercard payment: {amount}.");
                }
               
            }

            public double CheckBalance()
            {
                Console.WriteLine($"MasterCard Balance: {Balance}");
                return Balance;
            }


          
            #endregion
        }
    }




