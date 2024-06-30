using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSproject
{
    public class Process
    {
        public double priority;             //why is this double???
        public double arrival;  //arrival time
        public double burst;    //burst time
        public double rbt;      //remaining burst time
        public double exit;     //exit time
        public double TAT;
        public double WT;
        public Process()
        {
            exit = 0;
        }
        
        public void run (ref double clock , double q)  //run for q amount of time
        {
            if (rbt < q)     //if the rbt is smaller than the time slot  
                q = rbt;     //run only for the rbt
            rbt -= q;        
            clock += q;
            if (rbt == 0)   //it means the process is done running
                exit = clock;
        }
    }
}
