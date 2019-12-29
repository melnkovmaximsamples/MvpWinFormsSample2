using MVP_Sample.Models;
using MVP_Sample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Sample.Presenters
{
    class CalculatorPresenter
    {
        Calculator _calculator = new Calculator();

        private ICalculator calculatorView;

        public CalculatorPresenter(ICalculator view)
        {
            calculatorView = view;
        }

        public void ConnectBetweenModelAndView()
        {
            _calculator.NumberOne = Convert.ToDouble(calculatorView.TxtNumberOne);
            _calculator.NumberTwo = Convert.ToDouble(calculatorView.TxtNumberTwo);
        }

        public void CalcSum()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = _calculator.CalculateSumation().ToString();
        }

        public void CalcSub()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = _calculator.CalculateSubtraction().ToString();
        }

        public void CalcMultiplication()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = _calculator.CalculateMultiplication().ToString();
        }

        public void CalcDivition()
        {
            ConnectBetweenModelAndView();
            if (Convert.ToDouble(calculatorView.TxtNumberTwo) == 0)
            {
                MessageBox.Show("Can't Divide into Zero");
            }
            else
            {
                calculatorView.TxtResult = _calculator.CalculateDiviton().ToString();
            }
        }
    }
}
