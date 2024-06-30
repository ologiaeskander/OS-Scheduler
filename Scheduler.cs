using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSproject
{
    public class Scheduler
    {
        public double clock;    //clock
        public double idle;     //idle time of scheduler
        public double ATm, ATsd, BTm, BTsd, lambda, ATAT, AWT , Q;
        public int numprocess;
        public Scheduler()
        {
            clock = 0;
            idle = 0;
        }
        
        public List<Process> generate()
        {
            Random random = new Random();   // class for randoming
            
            
            List<Process> processes = new List<Process>();
            for (int pnum = 0; pnum < numprocess; pnum++)
            {
                double u1 = random.NextDouble(); // get random value between 0 and 1
                double u2 = random.NextDouble();
                double u3 = random.NextDouble();
                double u4 = random.NextDouble();
                double u5 = random.NextDouble();
                double z1 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);  //z-score of normal distribution
                double z2 = Math.Sqrt(-2 * Math.Log(u3)) * Math.Sin(2 * Math.PI * u4); //z-score of normal distribution
                processes.Add(new Process()
                {
                    arrival =Math.Abs( ATm + (ATsd * z1)), // genrating number equation from z = (x-mean)/std, arrival= x
                    burst =Math.Abs( BTm + (BTsd * z2)),
                    rbt =Math.Abs( BTm + (BTsd * z2)),
                    priority =Math.Abs( (-Math.Log(1 - u5)) / lambda)
                });
            }
            return processes;
        }

        public void FCFS (List<Process> processes)     //First Come First Served
        {
            List<Process> processes_arrival = processes.OrderBy(x => x.arrival).ToList(); //new list sorted by arrival time
            foreach (Process p in processes_arrival)
            {
                if (p.arrival > clock)     //if the next process hasen't arrived yet then the scheduler is idle
                {
                    idle += (p.arrival - clock);
                    clock += (p.arrival - clock);
                }
                p.run(ref clock, p.burst);  //i think i need to pass clock by reference 
            }
        }

        public void npHPF(List<Process> processes)     //non-preemptive Highest Priority First
        {
            List<Process> processes_arrival = processes.OrderBy(x => x.arrival).ToList();
            if (processes_arrival[0].arrival > clock)     //first process is automatically run
            {
                idle += (processes_arrival[0].arrival - clock);
                clock += (processes_arrival[0].arrival - clock);
            }
            processes_arrival[0].run(ref clock, processes_arrival[0].burst);
            processes_arrival.RemoveAt(0); 
            List<Process> rq_priority = new List<Process>();
            while (true)
            {
                bool done = true;
                foreach (Process x in processes_arrival)  //if any process came while process was processing
                {
                    if (x.arrival < clock && x.exit == 0)
                    {
                        rq_priority.Add(x);
                    }
                }
                if (processes_arrival[0].arrival > clock && rq_priority.Count == 0)  //if the process hasn't arrived and nothing is waiting
                {
                    idle += (processes_arrival[0].arrival - clock);
                    clock += (processes_arrival[0].arrival - clock);
                    processes_arrival[0].run(ref clock, processes_arrival[0].burst);
                    processes_arrival.RemoveAt(0);
                }
                
                rq_priority = rq_priority.OrderByDescending(p => p.priority).ToList();   //order the processes by priority
                rq_priority[0].run(ref clock, rq_priority[0].burst);  // run first priority then delete
                processes_arrival.RemoveAt(0);
                rq_priority.RemoveAt(0);

                foreach (Process x in processes_arrival) //if any process hasn't finished yet
                {
                    if (x.exit == 0)
                        done = false;
                }
                if (done)
                    break;
            }
            foreach(Process z in rq_priority)  //if any process does not run in priority list
            {
                z.run(ref clock, z.burst);
            }
        }

        public void SRJF(List<Process> processes)     //Shortest Remaining Job First
        {
            List<Process> processes_arrival = processes.OrderBy(x => x.arrival).ToList();
            List<Process> rq_rbt = new List<Process>();
            while (true)
            {
                if (processes_arrival[0].arrival > clock && rq_rbt.Count == 0)  //if the process hasn't arrived and nothing is waiting
                {
                    idle += (processes_arrival[0].arrival - clock);
                    clock += (processes_arrival[0].arrival - clock);
                }
                foreach (Process x in processes_arrival)  //if any process came while process was processing
                {
                    if (x.arrival <= clock && x.exit == 0)
                    {
                        rq_rbt.Add(x);
                    }
                }
                processes_arrival.RemoveAll(n => rq_rbt.Contains(n));

                rq_rbt = rq_rbt.OrderBy(p => p.rbt).ToList();   //order the processes by rbt
                if (processes_arrival.Count == 0)
                    break;
                rq_rbt[0].run(ref clock, (processes_arrival[0].arrival-clock));  // run shortest rbt till te next process arrives
                if (rq_rbt[0].rbt == 0)
                    rq_rbt.RemoveAt(0);

            }
            foreach (Process z in rq_rbt)  //if any process does not run in priority list
            {
                z.run(ref clock, z.burst);
            }
        }

        public void RR(List<Process> processes, double time_slot)        //Round Robin
        {
            List<Process> processes_arrival = processes.OrderBy(x => x.arrival).ToList(); //new list sorted by arrival 
            while (true)
            {
                bool done = true;
                foreach (Process p in processes_arrival)
                {
                    bool any_redy = false;   //checking if there is idle time befor the next process arrival
                    foreach (Process x in processes_arrival)
                    {
                        if (x.rbt != x.burst && x.rbt != 0) //if any process is currently waiting
                            any_redy = true;
                    }
                    if (p.arrival > clock && !any_redy)  //if the process hasn't arrived and nothing is waiting
                    {
                        idle += (p.arrival - clock);
                        clock += (p.arrival - clock);
                    }
                    if (p.arrival <= clock && p.exit == 0) //if a process arrived and hasen't exited
                    {
                        p.run(ref clock, time_slot);
                    }
                }
                foreach (Process x in processes) //if any process hasn't finished yet
                {
                    if (x.exit == 0)
                        done = false;
                }
                if (done)
                    break;
            }
        }

        public void SJF(List<Process> processes)        //Shortest Job First
        {
            List<Process> processes_arrival = processes.OrderBy(x => x.arrival).ToList();
            //if (processes_arrival[0].arrival > clock)     //first process is automatically run
            //{
            //    idle += (processes_arrival[0].arrival - clock);
            //    clock += (processes_arrival[0].arrival - clock);
            //}
            processes_arrival[0].run(ref clock, processes_arrival[0].burst);
            processes_arrival.RemoveAt(0);
            List<Process> rq_burst = new List<Process>();
            while (true)
            {
                bool done = true;
                if (processes_arrival[0].arrival > clock && rq_burst.Count == 0)  //if the process hasn't arrived and nothing is waiting
                {
                    idle += (processes_arrival[0].arrival - clock);
                    clock += (processes_arrival[0].arrival - clock);
                }
                foreach (Process x in processes_arrival)  //if any process came while process was processing
                {
                    if (x.arrival < clock && x.exit == 0)
                    {
                        rq_burst.Add(x);
                        processes_arrival.ToList().Remove(x);
                    }
                }

                rq_burst = rq_burst.OrderBy(p => p.burst).ToList();   //order the processes by priority
                rq_burst[0].run(ref clock, rq_burst[0].burst);  // run first priority then delete
                processes_arrival.RemoveAt(0);
                rq_burst.RemoveAt(0);

                foreach (Process x in processes_arrival) //if any process hasn't finished yet
                {
                    if (x.exit == 0)
                        done = false;
                }
                if (done)
                    break;
            }
            foreach (Process z in rq_burst)  //if any process does not run in priority list
            {
                z.run(ref clock, z.burst);
            }
        }
        
        public void calculate(List<Process> processes)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                processes[i].TAT = processes[i].exit- processes[i].arrival;
                processes[i].WT = processes[i].exit - processes[i].arrival - processes[i].burst;
            }
            double tat = 0;
            double wt = 0;
            foreach(Process p in processes)
            {
                tat += (p.exit - p.arrival);   //total arrival time
                wt += (p.exit - p.arrival - p.burst);   //total waiting time
            }
            ATAT = tat / numprocess;
            AWT= wt / numprocess;
        }

        public void printall(List<Process> processes)
        {
            List<Process> processes_arrival = processes.OrderBy(x => x.arrival).ToList();
            int counter = 1;
            foreach (Process p in processes_arrival)
            {
                Console.WriteLine("Process" + counter + ":\narrival: " + p.arrival + "\tburst " + p.burst + "\texit: " + p.exit + "\trbt: " + p.rbt + "\tpriority"+ p.priority);
                Console.WriteLine("\tTAT: " + p.TAT + "\tWT: " + p.WT);
                counter++;
            }
            Console.WriteLine("\nClock: " + clock + "\nIdle: " + idle + "\n");
            Console.WriteLine("ATAT = " + ATAT);
            Console.WriteLine("AWT = " + AWT);
        }
    }
}
