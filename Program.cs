using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSproject
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Scheduler sc = new Scheduler();
            List<Process> p = new List<Process>();
            
            Console.Write("Enter the number of process : ");
            sc.numprocess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arrival Time :- ");
            Console.Write("\tEnter the mean : ");
            sc.ATm = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tEnter The standered diviation : ");
            sc.ATsd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Burst time :- ");
            Console.Write("\tEnter the mean : ");
            sc.BTm = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tEnter The standered diviation : ");
            sc.BTsd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Lambda of priority : ");
            sc.lambda = Convert.ToDouble(Console.ReadLine());
            p = sc.generate();
            Console.WriteLine("Chose your algorithm : ");
            Console.WriteLine("1=>FCFS    2=>npHPF    3=>pHPF    4=>RR    5=>SRJF    6=>SJF");
            Console.Write("Enter your choice : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("FCFS : ");
                sc.FCFS(p);
                sc.calculate(p);
                sc.printall(p);
            }
            else if (c ==2)
            {
                Console.WriteLine("npHPF : ");
                sc.npHPF(p);
                sc.calculate(p);
                sc.printall(p);
            }
            else if(c ==3)
            {
                Console.WriteLine("pHPF : //not emplemented yet");
                
            }
            else if (c ==4)
            {
                Console.WriteLine("RR : ");
                Console.Write("Enter time quantum : ");
                double q = Convert.ToDouble(Console.ReadLine());
                sc.RR(p, q);
                sc.calculate(p);
                sc.printall(p);
            }
            else if (c == 5)
            {
                Console.WriteLine("pSRJF : ");
                sc.SRJF(p);
                sc.calculate(p);
                sc.printall(p);
            }
            else if (c ==6) 
            {
                Console.WriteLine("npSJF : ");
                sc.SJF(p);
                sc.calculate(p);
                sc.printall(p);
            }
            Console.ReadLine();
        }
    }
}
