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
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            KeyDown += Window_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            screen.Text = "";
            history.Text = "";
        }

        private void one_button_Click(object sender, EventArgs e) { screen.Text += "1"; }		// click the '1' button
        private void two_button_Click(object sender, EventArgs e) { screen.Text += "2"; }		// click the '2' button
        private void three_button_Click(object sender, EventArgs e) { screen.Text += "3"; }		// click the '3' button
        private void four_button_Click(object sender, EventArgs e) { screen.Text += "4"; }		// click the '4' button
        private void five_button_Click(object sender, EventArgs e) { screen.Text += "5"; }		// click the '5' button
        private void six_button_Click(object sender, EventArgs e) { screen.Text += "6"; }		// click the '6' button
        private void seven_button_Click(object sender, EventArgs e) { screen.Text += "7"; }		// click the '7' button
        private void eight_button_Click(object sender, EventArgs e) { screen.Text += "8"; }		// click the '8' button
        private void nine_button_Click(object sender, EventArgs e) { screen.Text += "9"; }		// click the '9' button
        private void zero_button_Click(object sender, EventArgs e) { screen.Text += "0"; }		// click the '0' button
        private void point_button_Click(object sender, EventArgs e) { screen.Text += "."; }		// click the '.' button

        private void equals_button_Click(object sender, EventArgs e)                     		// click the '=' button
        {
            try
            {           // add a line that says if a(b) or (a)b, make it a*(b) or (a)*b
                history.Text += screen.Text + "=";
                screen.Text = Math.Round(Evaluate(screen.Text), 10).ToString();
                history.Text += screen.Text + "\n\n";
            } catch {
                screen.Text = "Error";
                history.Text += screen.Text + "\n\n";
            }
        }

        static double Evaluate(string expression)                                               // The brains of the operation
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)(loDataTable.Rows[0]["Eval"]);
        }

        private void add_button_Click(object sender, EventArgs e) { screen.Text += "+"; } 		        // click the '+' button
        private void minus_button_Click(object sender, EventArgs e) { screen.Text += "-"; }		        // click the '-' button
        private void multiply_button_Click(object sender, EventArgs e) { screen.Text += "*"; }		    // click the '*' button
        private void divide_button_Click(object sender, EventArgs e) { screen.Text += "/"; }		    // click the '/' button
        private void clear_button_Click(object sender, EventArgs e) { screen.Text = ""; }		        // click the 'C' button
        private void openbrac_button_Click(object sender, EventArgs e) { screen.Text += "("; }		    // click the '(' button
        private void closebrac_button_Click(object sender, EventArgs e) { screen.Text += ")"; }		    // click the ')' button
        private void toThePower_button_Click(object sender, EventArgs e) { screen.Text += "**"; }		// click the '^' button
        private void sqrt_button_Click(object sender, EventArgs e) { screen.Text += "Math.sqrt("; }		// click the 'sqrt' button



        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Oemplus) { screen.Text += "+"; }       // key combo for '+'
            else if (e.KeyCode == Keys.OemMinus) { screen.Text += "-"; }            // key combo for '-'
            else if (e.Shift && e.KeyCode == Keys.D8) { screen.Text += "*"; }       // key combo for '*'
            else if (e.KeyCode == Keys.OemQuestion) { screen.Text += "/"; }         // key combo for '/'
            else if (e.Shift && e.KeyCode == Keys.D9) { screen.Text += "("; }       // key combo for '('
            else if (e.Shift && e.KeyCode == Keys.D0) { screen.Text += ")"; }       // key combo for ')'
            else if (e.KeyCode == Keys.OemPeriod) { screen.Text += "."; }           // key combo for '.'
            else if (e.KeyCode == Keys.C) { screen.Text = ""; }                     // key combo for 'C'
            else if (e.KeyCode == Keys.Back) {                                      // when backspace is pressed
                screen.Text = screen.Text.Substring(0, screen.Text.Length - 1); }
            else if (e.KeyCode == Keys.Oemplus) {                                     // key combo for '='
                try
                {
                    // add a line that says if a(b) or (a)b, make it a*(b) or (a)*b
                    history.Text += screen.Text + "=";
                    screen.Text = Math.Round(Evaluate(screen.Text), 10).ToString();
                    history.Text += screen.Text + "\n\n";
                }
                catch
                {
                    screen.Text = "Error";
                    history.Text += screen.Text + "\n\n";
                }
            }
            else if (e.KeyCode == Keys.D0) { screen.Text += "0"; }      // 0 key
            else if (e.KeyCode == Keys.D1) { screen.Text += "1"; }      // 1 key
            else if (e.KeyCode == Keys.D2) { screen.Text += "2"; }      // 2 key
            else if (e.KeyCode == Keys.D3) { screen.Text += "3"; }      // 3 key
            else if (e.KeyCode == Keys.D4) { screen.Text += "4"; }      // 4 key
            else if (e.KeyCode == Keys.D5) { screen.Text += "5"; }      // 5 key
            else if (e.KeyCode == Keys.D6) { screen.Text += "6"; }      // 6 key
            else if (e.KeyCode == Keys.D7) { screen.Text += "7"; }      // 7 key
            else if (e.KeyCode == Keys.D8) { screen.Text += "8"; }      // 8 key
            else if (e.KeyCode == Keys.D9) { screen.Text += "9"; }      // 9 key
        }
    }
}
