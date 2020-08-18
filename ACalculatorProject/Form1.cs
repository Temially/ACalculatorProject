using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACalculatorProject
{
	public partial class Form1 : Form
	{
		double FirstNum, SecondNum, Result;
		

		public Form1()
		{
			InitializeComponent();
		}

		private void butClear_Click(object sender, EventArgs e)
		{
			txtFirstNum.Text = "";
			txtsecNum.Text = "";
			txtResult.Text = "";
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			FirstNum = Convert.ToDouble(txtFirstNum.Text);
			SecondNum = Convert.ToDouble(txtsecNum.Text);
			Result = FirstNum - SecondNum;
			txtResult.Text = Result.ToString();
		}

		private void btnDiv_Click(object sender, EventArgs e)
		{
			FirstNum = Convert.ToDouble(txtFirstNum.Text);
			SecondNum = Convert.ToDouble(txtsecNum.Text);
			Result = FirstNum / SecondNum;
			txtResult.Text = Result.ToString();
		}

		private void btnMin_Click(object sender, EventArgs e)
		{
			FirstNum = Convert.ToDouble(txtFirstNum.Text);
			SecondNum = Convert.ToDouble(txtsecNum.Text);
			Result = FirstNum * SecondNum;
			txtResult.Text = Result.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FirstNum = Convert.ToDouble(txtFirstNum.Text);
			SecondNum = Convert.ToDouble(txtsecNum.Text);
			Result = FirstNum + SecondNum;
			txtResult.Text =  Result.ToString();
		}


	}
}
