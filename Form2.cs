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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		} //form2_exit_btn

		private void form2_compute_btn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 f3 = new Form3();
			f3.Show();
		}//form 2 single queue

		private void form2_view_btn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form4 f4 = new Form4();
			f4.Show();
		}//form2 multiple queue

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	} //partial class
} //namespace
