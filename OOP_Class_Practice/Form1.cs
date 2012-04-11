using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_Class_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               /* car mycar = new car();
                mycar.trunkspace = 100;
                mycar.storegroceries(99);
                MessageBox.Show(drivecar.drive().ToString());
            */
                List<car> mycars = new List<car>();
                
                car myfirstcar = new car();
                myfirstcar.name = "Volvo";
                car mysecondcar = new car();
                mysecondcar.name = "Ford";

                mycars.Add(myfirstcar);
                mycars.Add(mysecondcar);

                foreach (car icar in mycars)
                {
                    richTextBox1.Text += icar.name + "\n";
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class car : vehicle
    {
        int _trunkspace = 0;
        public int trunkspace
        {

            get {
                return _trunkspace;
            }
            set {
                _trunkspace = value;
            }
        }
        public void storegroceries(int squarefootageofyourjunkfood)
        {
            if (squarefootageofyourjunkfood > _trunkspace)
            {
                throw new Exception("You have too much junk food to store!");
            }
        }
    }
    public abstract class vehicle
    {
        public string name { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string vin { get; set; }
        public engine myengine{ get; set; }
    }

   public class engine
    {
       public int horses { get; set; }
       public int cylinders { get; set; }
       public bool turbo { get; set; }
       public bool super { get; set; }
    }

    public static class drivecar
    {
        public static int drive()
        {
            return 100;
        }
    }
}











