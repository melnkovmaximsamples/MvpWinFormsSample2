using MVP_Sample.Views;
using MVP_Sample.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Sample
{
    public partial class Form1 : Form, ICalculator
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string TxtNumberOne { get => txtNumberOne.Text; set => txtNumberTwo.Text = value; }
        public string TxtNumberTwo { get => txtNumberTwo.Text; set => txtNumberTwo.Text = value; }
        public string TxtResult { get => txtResult.Text; set => txtResult.Text = value; }

        private CalculatorPresenter presenter;

        private void btnSum_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresenter(this);
            presenter.CalcSum();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresenter(this);
            presenter.CalcSub();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresenter(this);
            presenter.CalcMultiplication();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            presenter = new CalculatorPresenter(this);
            presenter.CalcDivition();
        }
    }
}
