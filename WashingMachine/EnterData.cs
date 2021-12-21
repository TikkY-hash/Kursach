using System;
using System.Windows.Forms;

namespace WashingMachine
{
    public partial class EnterData : Form
    {
        public EnterData()
        {
            InitializeComponent();
        }

        public bool checkDataInForm()
        {
            if (typeDetergent.Text.ToLower() != "рідкий" && typeDetergent.Text.ToLower() != "сухий"
                && typeDetergent.Text.ToLower() != "комбінований")
            {
                return false;
            }
            else if (!double.TryParse(sizeWaterText.Text, out sizeWaterCheck))
            {
                return false;
            }
            return true;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!checkDataInForm())
            {
                MessageBox.Show("З даними щось не так");
            }
            else
            {
                WashingProgram washingProgram = new WashingProgram(sizeWaterCheck, typeDetergent.Text);
                washingProgram.Show();
                this.Hide();
            }
        }
        private double sizeWaterCheck;

        private void Enter_Load(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
	}
}

