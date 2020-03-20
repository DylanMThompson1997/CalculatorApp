using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 7
            label1.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 8
            label1.Text += "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 9
            label1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 4
            label1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 5
            label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 6
            label1.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 1
            label1.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 2
            label1.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 3
            label1.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // 0
            label1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // .
            label1.Text += ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // =
            try
            {
                // add a line that says if a(b) or (a)b, make it a*(b) or (a)*b
                label1.Text = Math.Round(Evaluate(label1.Text), 10).ToString();
            } catch
            {
                label1.Text = "Error";
            }
        }

        static double Evaluate(string expression)
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)(loDataTable.Rows[0]["Eval"]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // plus
            label1.Text += "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // minus
            label1.Text += "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // times
            label1.Text += "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // divided
            label1.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // clear
            label1.Text = "";
        }

        private void MyForm_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D7)
            {
                label1.Text += "7";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // ^
            label1.Text += "**";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // )
            label1.Text += ")";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // (
            label1.Text += "(";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // square root
            label1.Text += "Math.sqrt(";
        }
    }
}
