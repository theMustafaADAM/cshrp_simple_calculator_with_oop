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

        private class Calculator 
        {

            double _lastNmbr = 0.0;
            double _lastResult = 0.0;
            double _result = 0.0;

            private bool isZero(double Nmb)
            {
                return (Nmb == 0);
            }


            public double Add(double fn , double sn)
            {
                _lastNmbr = fn;
                _lastResult = _result;
                _result += fn + sn;
                return _result;
            }

            public double Sub(double fn, double sn)
            {
                _lastNmbr = fn;
                _lastResult = _result;
                _result += fn - sn;
                return _result;
            }

            public double Mlt(double fn, double sn)
            {
                _lastNmbr = fn;
                _lastResult = _result;
                _result += fn * sn;
                return _result;
            }

            public void clear()
            {
                _lastNmbr = 0.0;
                _lastResult = 0.0;
                _result = 0.0;
            }

            public void CancelLastOperation()
            {
                _lastNmbr = 0.0;
                _result = _lastResult;

            }

            public double FinalResult()
            {
                return _result;
            }

            public double Div(double fn, double sn)
            {
                if (isZero(sn)) sn = 1;
                _lastNmbr = fn;
                _lastResult = _result;
                _result += fn / sn;
                return _result;
            }

        }

        private bool frstNmb = true;
        private bool scndNmb = true;
        private double results = 0; 

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(frstNmb) lblfrst.Text = ""; lblfrst.Text += 0;
            if(scndNmb) lblscnd.Text = ""; lblscnd.Text += 0;
        }

        private void bzero_Click(object sender, EventArgs e)
        {
            if(frstNmb) lblfrst.Text += 0;
            else lblscnd.Text += 0; 
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (frstNmb)  frstNmb = false; scndNmb = true; 

            btnMinus.Enabled = false;
            btnMulti.Enabled = false;
            btnDivid.Enabled = false;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(frstNmb) frstNmb = false; scndNmb = true;

            btnPlus.Enabled = false;
            btnMulti.Enabled = false;
            btnDivid.Enabled = false;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (frstNmb) frstNmb = false; scndNmb = true;

            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnDivid.Enabled = false;
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            if (frstNmb) frstNmb = false; scndNmb = true;

            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnMulti.Enabled = false;
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

            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMulti.Enabled = true;
            btnDivid.Enabled = true;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblfrst.Text = ""; lblfrst.Text += 0; lblscnd.Text = ""; lblscnd.Text += 0;

            Calculator cal = new Calculator();

            if (btnPlus.Enabled)
            {
                results = 0;                 
                results = cal.Add(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));
            
            } 
            else if (btnMinus.Enabled)
            {
                results = 0;
                results = cal.Sub(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));
            
            } 
            else if (btnMulti.Enabled)
            {
                results = 0;
                results = cal.Mlt(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));                        
            } 
            else
            {
                results = 0;
                results = cal.Div(Convert.ToDouble(lblfrst.Text), Convert.ToDouble(lblscnd.Text));
            }        

            lblresult.Text = results.ToString();

            frstNmb = true; scndNmb = false;
            
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMulti.Enabled = true;
            btnDivid.Enabled = true;
        }
    }
}
