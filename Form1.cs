using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        Scheduler sc = new Scheduler();
        List<Process> p = new List<Process>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Scheduler sc = new Scheduler
            {
                ATm = Convert.ToDouble(ATm.Text),
                ATsd = Convert.ToDouble(ATsd.Text),
                BTm = Convert.ToDouble(BTm.Text),
                BTsd = Convert.ToDouble(BTsd.Text),
                lambda = Convert.ToDouble(LoP.Text),
                numprocess = Convert.ToInt32(num.Text)
            };
            ATAT.Text = Convert.ToString(sc.ATAT);
            AWT.Text = Convert.ToString(sc.AWT);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FCFS.Checked)
            {
                sc.FCFS(p);
                sc.calculate(p);
                sc.printall(p);
            }
            else if(npHPF.Checked)
            {

            }
        }
    }
}
