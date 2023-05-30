using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_form_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // to Prevent making an object from Class
        //static class clsCalculator
        class clsCalculator

        {
            
            //public clsCalculator(double fstNmb, double sndNmb)
            //{
            //    this._frstnumber = fstNmb;
            //    this._scndnumber = sndNmb;
            //}

            private clsCalculator()
            {

            }

            //private double _frstnumber { get; set; }
            //private double _scndnumber { get; set; }
            private double _result = 0.0;

            private bool isZero(double Nmb)
            {
                return (Nmb == 0);
            }


            public static double Add( double frstnumber, double scndnumber)
            {
                return frstnumber + scndnumber;
            }

            public static double Sub(double frstnumber, double scndnumber)
            {
                return frstnumber - scndnumber;
            }

            public static double Mlt(double frstnumber, double scndnumber)
            {
                return frstnumber * scndnumber;
            }

            //public void clear()
            //{
            //    _frstnumber = 0.0;
            //    _scndnumber = 0.0;
            //    _result = 0.0;
            //}

            //public double FinalResult()
            //{
            //    return _result;
            //}

            public static double Div(double frstnumber, double scndnumber)
            {
                if (frstnumber == 0) frstnumber = 1;
                if (scndnumber == 0) scndnumber = 1;

                return frstnumber / scndnumber;
            }
        }

        private bool frstNmb = true;
        private bool scndNmb = true;
        private double results = 0; 

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblfrst.Text = ""; lblscnd.Text = ""; op_stat = 'g';

            frstNmb = true; scndNmb = false;

            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMulti.Enabled = true;
            btnDivid.Enabled = true;
        }

        private void bzero_Click(object sender, EventArgs e)
        {
            if(frstNmb) lblfrst.Text += 0;
            else lblscnd.Text += 0; 
        }

        private char op_stat = 'g';

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (frstNmb && lblfrst.Text != "")
            {
                frstNmb = false; scndNmb = true; 
                btnMinus.Enabled = false;
                btnMulti.Enabled = false;
                btnDivid.Enabled = false;
                btnPlus.Enabled = false; op_stat = 'p'; // p = plus
            }
            else
            {
                lblfrst.Text = "0";
                frstNmb = false; scndNmb = true;
                btnMinus.Enabled = false;
                btnMulti.Enabled = false;
                btnDivid.Enabled = false;
                btnPlus.Enabled = false; op_stat = 'p'; // p = plus
            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (frstNmb && lblfrst.Text != "")
            {
                frstNmb = false; scndNmb = true;
                btnPlus.Enabled = false;
                btnMulti.Enabled = false;
                btnDivid.Enabled = false;
                btnMinus.Enabled = false; op_stat = 'n'; // n = minus
            }
            else
            {
                lblfrst.Text = "0";
                frstNmb = false; scndNmb = true;
                btnPlus.Enabled = false;
                btnMulti.Enabled = false;
                btnDivid.Enabled = false;
                btnMinus.Enabled = false; op_stat = 'n'; // n = minus
            }


        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (frstNmb && lblfrst.Text != "")
            {
                frstNmb = false; scndNmb = true;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDivid.Enabled = false;
                btnMulti.Enabled = false; op_stat = 'm'; // m = multi
            }
            else
            {
                lblfrst.Text = "0";
                frstNmb = false; scndNmb = true;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDivid.Enabled = false;
                btnMulti.Enabled = false; op_stat = 'm'; // m = multi
            }

        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            if (frstNmb && lblfrst.Text != "")
            {
                frstNmb = false; scndNmb = true;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnMulti.Enabled = false;
                btnDivid.Enabled = false; op_stat = 'd'; // d = divid

            }
            else
            {
                lblfrst.Text = "0";
                frstNmb = false; scndNmb = true;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnMulti.Enabled = false;
                btnDivid.Enabled = false; op_stat = 'd'; // d = divid
            }

        }

        private void bone_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 1;
            else lblscnd.Text += 1; 
        }

        private void btwo_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 2;
            else lblscnd.Text += 2; 
        }

        private void bthree_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 3; 
            else lblscnd.Text += 3;
        }

        private void bfour_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 4; 
            else lblscnd.Text += 4;
        }

        private void bfive_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 5;
            else lblscnd.Text += 5;
        }

        private void bsix_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 6;             
            else lblscnd.Text += 6;
        }

        private void bseven_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 7;
            else lblscnd.Text += 7;
        }

        private void beight_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 8;
            else lblscnd.Text += 8;
        }

        private void bnine_Click(object sender, EventArgs e)
        {
            if (frstNmb) lblfrst.Text += 9;
            else lblscnd.Text += 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frstNmb = true;

            op_stat = 'g';

            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMulti.Enabled = true;
            btnDivid.Enabled = true;

        }



        private void btnEqual_Click(object sender, EventArgs e)
        {

            //clsCalculator cal = new clsCalculator(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));

            if (lblscnd.Text == "") lblscnd.Text = "0";

            if (op_stat == 'p' )
            {
                results = 0;                 
                results = clsCalculator.Add(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));
            
            } 
            else if (op_stat == 'n')
            {
                results = 0;
                results = clsCalculator.Sub(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));
            
            } 
            else if (op_stat == 'm')
            {
                results = 0;
                results = clsCalculator.Mlt(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));                        
            } 
            else if (op_stat == 'd')
            {
                results = 0;
                results = clsCalculator.Div(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));
            } 
            else
            {
                MessageBox.Show("Choose your operation","What do you wanna do?", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            lblresult.Text = results.ToString();

            lblfrst.Text = ""; lblscnd.Text = ""; op_stat = 'g';

            frstNmb = true; scndNmb = false;
            
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMulti.Enabled = true;
            btnDivid.Enabled = true;
        }
    }
}
