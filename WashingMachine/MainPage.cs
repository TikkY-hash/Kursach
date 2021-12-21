using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashingMachine
{
	public partial class MainPage : Form
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			EnterData enterData = new EnterData();
			enterData.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
