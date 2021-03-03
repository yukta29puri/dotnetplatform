using System;
namespace Elect_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, unit;
            double chg, GST = 0, gramt, net;
            Console.Write("\n\n");
            Console.Write("Calculate Electricity Bill:\n");
            Console.Write("----------------------------\n");
            Console.Write("Input Customer ID :");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the unit consumed by the customer : ");
            unit = Convert.ToInt32(Console.ReadLine());
            if (unit>=0 && unit <= 100)
            {
                chg = 5.0;
                gramt = unit * chg;
            }
            else if (unit >= 101 && unit <= 200)
            {
                chg = 7.0;
                gramt = unit * chg;
            }
            else if (unit >= 201 && unit <= 300)
            {
                chg = 10.0;
                gramt = unit * chg;
            }
            else if (unit >= 301 && unit <= 400)
            {
                chg = 12.0;
                gramt = unit * chg;
            }
            else
            {
                chg = 15;
                gramt = unit * chg;
            }
            GST = gramt * 14 / 100.0;
            net = gramt + GST;
            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO                       :{0}\n", id);
            Console.Write("Unit Consumed                       :{0}\n", unit);
            Console.Write("Amount Charges @Rs. {0} per unit     :{1}\n", chg, gramt);
            Console.Write("GST(14%)                            :{0}\n", GST);
            Console.Write("Net Amount Paid By the Customer     :{0}\n", net);

        }
    }
}
