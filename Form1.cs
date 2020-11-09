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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		} //public form1

		private void Form1_Load(object sender, EventArgs e)
		{

		} //form1_Load

		private void form1_start_btn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 f2 = new Form2();
			f2.Show();
		}//start_btn_form1
	} //public partial class
} //end namespace
