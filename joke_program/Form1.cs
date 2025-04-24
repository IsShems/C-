using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Size = new Size(97, 150);
        }

        private string CoordToString(MouseEventArgs mouseEvent)
        {
            return $"Mouse coordX = {mouseEvent.X} \n      coord Y = {mouseEvent.Y}";
        }

        private void Form1_MouseMove (object sender, MouseEventArgs e)
        {
            Text = CoordToString(e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hellooo", "Hihi",
              //      MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I kNEW IT!!!", "Hihi");
        }

        private void button2_Capture(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button2.Location = new Point(rnd.Next(1, 300), rnd.Next(1, 300));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
