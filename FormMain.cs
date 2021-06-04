using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duloveme.Calculator
{
    public partial class FormMain : Form
    {
        private double? _Operand1 = null;
        private double? _Operand2 = null;
        private string _CurrentOperand = null;
        private string _Operator = null;
        private double? _Result = null;
        private bool _Calculated = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (_Calculated)
            {
                lblHistory.Text = "";                
                _Operand1 = null;
            }
            var input = (sender as Button).Text;
            var newVal = $"{_CurrentOperand}{input}";
            if (input == ".")
            {
                if (!string.IsNullOrEmpty(_CurrentOperand) && _CurrentOperand.Contains("."))
                    return;
                _CurrentOperand = newVal;
            }
            else
            {
                _CurrentOperand = double.Parse(newVal).ToString();
            }
            lblCurrent.Text = _CurrentOperand;
            _Calculated = false;
        }

        private void Symbol_Click(object sender, EventArgs e)
        {
            _Calculated = false;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (_CurrentOperand == null)
                _CurrentOperand = lblCurrent.Text;
            if (_Operand1 == null)
                _Operand1 = double.Parse(_CurrentOperand);
            else if (_Operand2 == null)
                _Operand2 = double.Parse(_CurrentOperand);
            var oper = (sender as Button).Text;
            lblHistory.Text += $"{_CurrentOperand} {oper} ";
            if (_Operand1 != null && _Operand2 != null)
                Calculate();
            _CurrentOperand = null;
            _Operator = oper;
            _Calculated = false;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            _CurrentOperand = null;
            lblCurrent.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblHistory.Text = "";
            lblCurrent.Text = "0";
            _CurrentOperand = null;
            _Operand1 = null;
            _Operand2 = null;
            _Operator = null;
            _Result = null;
            _Calculated = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculate(true);
            _Calculated = true;
        }
        private void Calculate(bool resetHistory = false)
        {
            if (!string.IsNullOrEmpty(_CurrentOperand))
            {
                if (_Operand1 == null)
                    _Operand1 = double.Parse(_CurrentOperand);
                else if (_Operand2 == null)
                    _Operand2 = double.Parse(_CurrentOperand);                
            }
            if (_Operator != null && _Operand1 != null)
            {
                if (_Operand2 == null)
                {
                    if (_CurrentOperand != null)
                        _Operand2 = double.Parse(_CurrentOperand);
                    else
                        _Operand2 = _Operand1;
                }
                if (resetHistory)
                    lblHistory.Text = $"{_Operand1} {_Operator} {_Operand2} = ";

                switch (_Operator)
                {
                    case "÷":
                        _Result = _Operand1 % _Operand2;
                        break;
                    case "×":
                        _Result = _Operand1 * _Operand2;
                        break;
                    case "+":
                        _Result = _Operand1 + _Operand2;
                        break;
                    case "-":
                        _Result = _Operand1 - _Operand2;
                        break;
                }
                _Operand1 = _Result;
                _CurrentOperand = null;
                
                lblCurrent.Text = $"{_Result}";
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            _CurrentOperand = _CurrentOperand.Substring(0, _CurrentOperand.Length - 1);
            if (string.IsNullOrEmpty(_CurrentOperand))
                _CurrentOperand = null;
            lblCurrent.Text = _CurrentOperand??"0";
        }
    }
}
