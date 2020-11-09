using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void f4_clear_btn1_Click(object sender, EventArgs e)
		{

		}//clear

		private void f4_proceed_btn2_Click(object sender, EventArgs e)
		{

		}//proceed

		private void f4_back_btn3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 f2 = new Form2();
			f2.Show();
		}//back

		private void f4_addnew_btn4_Click(object sender, EventArgs e)
		{

		}//add new

		private void f4_done_btn5_Click(object sender, EventArgs e)
		{
			this.Close();
			Environment.Exit(0);
		}//done
	}
}//namespace
