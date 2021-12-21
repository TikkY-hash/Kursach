 using System.Threading;
using System;
using System.Windows.Forms;

namespace WashingMachine
{
/*    Потрібно розробити об'єктну модель програмного забезпечення вбудовано-го мікропроцесора пральної машини.
    Машина призначена для автоматичного прання білизни.У машині є бак для білизни, клапани для забору й зливу води, 
    мотор, обладнання піді-гріву води, термометр, таймер, дверцята для доступу в бак, кілька ємностей для різних 
    мийних засобів, панель керування із кнопками й індикатором. У пам'яті машини зберігаються 5 програм прання, 
    задані виготовлювачем. Ко-ристувачі не можуть вносити в них зміни. Кожна програма визначає темпе-ратуру води, 
    тривалість прання, використовувані мийні засоби (номер ємно-сті й час подачі), швидкість обертання бака під час 
    прання й отжима.
    Для використання машини необхідно відкрити дверцята, помістити бі-лизну в бак, помістити мийні засоби в ємності, 
    закрити дверцята, вибрати програму прання й натиснути на кнопку «Пуск». Перед тим як приступити до прання 
    машина відкриває клапан для забору води, набирає необхідну кі-лькість води, після чого закриває клапан. 
    Далі, машина діє по обраній корис-тувачем програмі: підігріває, якщо необхідно воду до потрібної температу-ри; 
    вмикає таймер і запускає обертання бака для прання; по таймеру подає в бак мийні засоби, передбачені програмою; 
    по закінченню прання зливає во-ду й запускає віджим.
    Під час роботи на індикаторі висвітлюється час, що пройшов від поча-тку прання (хвилини й секунди), поточний режим 
    роботи(прання або ві-джим), номер поточної програми прання.Користувач має можливість у будь-який момент натиснути 
    на кнопку «Останов», щоб примусово зупинити прання й злити воду.*/

    public partial class WashingProgram : Form
    {
        private int m, s;
        public WaterTank wt;
        public WashingProgram(double sizeWater, string typeDetergent)
        {
            InitializeComponent();
            this.sizeWater = sizeWater;
            this.typeDetergent = typeDetergent;
            timer1.Interval = 500;
            m = 0;
            s = 0;
            label7.Text = "00";
            label9.Text = "00";
            label8.Visible = true;
        }

        public double sizeWater = 0;
        string typeDetergent;
        public double sizeNeedWater = 0;
        
        public string StartMotor()
        {
            return "\r\nМотор почав працювати.";
        }
        public string EndMotor()
        {
            return "\r\nМотор закінчив працювати.";
        }

        public string StartBaraban()
        {
            return "\r\nБарабан почав крутитися.";
        }
        public string EndBaraban()
        {
            return "\r\nБарабан закінчив крутитися.";
        }

        public void StartTank()
        {
            if (checkBoxTypeDetergent3.Checked == true) 
            {
                textWashProccess.Text += "\r\nТип порошку: " + checkBoxTypeDetergent3.Text;
            }
            else if(checkBoxTypeDetergent2.Checked == true)
            {
                textWashProccess.Text += "\r\nТип порошку: " + checkBoxTypeDetergent2.Text;
            }
            else if (checkBoxTypeDetergent1.Checked == true)
            {
                textWashProccess.Text += "\r\nТип порошку: " + checkBoxTypeDetergent1.Text;
            }
        }

        public string EndTank()
        {
            return "\r\nПорошок використаний";
        }

        public class WaterTank
        {
            public double sizeWater;
            public double sizeNeedWater;

            public WaterTank(double sizeNeedWater, double sizeWater)
            {
                this.sizeNeedWater = sizeNeedWater;
                this.sizeWater = sizeWater;
            }
            public string Start(double sizeNeedWater, double sizeWater)
            {
                if (sizeWater > sizeNeedWater)
                    return "У баці достатньо води.";
                else
                {
                    MessageBox.Show("Недостатня кілкість води, воду було автоматично долито.");
                    return "У баці достатньо води.";
                }
            }
            public string End()
            {
                return "Бак пустий.";
            }
        }

        private void clearCheckBox()
        {
            checkBoxRotationSpeed1.Checked = false;
            checkBoxRotationSpeed2.Checked = false;
            checkBoxRotationSpeed3.Checked = false;
            checkBoxTime1.Checked = false;
            checkBoxTime2.Checked = false;
            checkBoxTime3.Checked = false;
            checkBoxTemp1.Checked = false;
            checkBoxTemp2.Checked = false;
            checkBoxTemp3.Checked = false;
            checkBoxTypeDetergent1.Checked = false;
            checkBoxTypeDetergent2.Checked = false;
            checkBoxTypeDetergent3.Checked = false;
        }
        private void StartWork()
        {
            textWashProccess.Text = null;
            textWashProccess.Text = "Початок прання.\r\n";
            StartTank();
            textWashProccess.Text += StartMotor();
            textWashProccess.Text += StartBaraban();
            Thread.Sleep(1000);
            textWashProccess.Text = textWashProccess.Text + "\r\n" + "Починаємо полоскання.";
            Thread.Sleep(1000);
            textWashProccess.Text = textWashProccess.Text + "\r\n" + "Починаємо полоскання.";
        }
        private void btnModeSport_Click(object sender, EventArgs e)
        {
            clearCheckBox();
            this.sizeNeedWater = 70.0;
            checkBoxTemp2.Checked = true;
            checkBoxRotationSpeed1.Checked = true;
            checkBoxTime1.Checked = true;
            checkTypeDetergent();
        }

        private void btnModeLight_Click(object sender, EventArgs e)
        {
            clearCheckBox();
            this.sizeNeedWater = 60.0;
            checkBoxTemp3.Checked = true;
            checkBoxRotationSpeed3.Checked = true;
            checkBoxTime1.Checked = true;
            checkTypeDetergent();
        }

        private void btnModeDelicacy_Click(object sender, EventArgs e)
        {
            clearCheckBox();
            this.sizeNeedWater = 100.0;
            checkBoxTemp2.Checked = true;
            checkBoxRotationSpeed2.Checked = true;
            checkBoxTime2.Checked = true;
            checkTypeDetergent();
        }
        public void checkTypeDetergent()
        {
            if (typeDetergent == checkBoxTypeDetergent1.Text)
            {
                checkBoxTypeDetergent1.Checked = true;
            }
            else if (typeDetergent == checkBoxTypeDetergent2.Text)
            {
                checkBoxTypeDetergent2.Checked = true;
            }
            else if (typeDetergent == checkBoxTypeDetergent3.Text)
            {
                checkBoxTypeDetergent3.Checked = true;
            }
        }


        private void btnModeFullLoop_Click(object sender, EventArgs e)
        {
            clearCheckBox();
            this.sizeNeedWater = 150.0;
            checkBoxTemp2.Checked = true;
            checkBoxRotationSpeed2.Checked = true;
            checkBoxTime3.Checked = true;
            checkTypeDetergent();
        }

        private void btnModeFast_Click(object sender, EventArgs e)
        {
            clearCheckBox();
            this.sizeNeedWater = 130.0;
            checkBoxTemp1.Checked = true;
            checkBoxRotationSpeed1.Checked = true;
            checkBoxTime1.Checked = true;
            checkTypeDetergent();
        }

        private int stopCheck1 = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((checkBoxTemp1.Checked != false || checkBoxTemp2.Checked != false
                || checkBoxTemp3.Checked != false) && (checkBoxRotationSpeed1.Checked != false
                || checkBoxRotationSpeed2.Checked != false || checkBoxRotationSpeed3.Checked != false)
                && (checkBoxTime1.Checked != false || checkBoxTime2.Checked != false
                || checkBoxTime3.Checked != false) && (checkBoxTypeDetergent1.Checked != false
                || checkBoxTypeDetergent2.Checked != false || checkBoxTypeDetergent3.Checked != false))
            {
                btnStop.Show();
                if (sizeNeedWater > sizeWater)
                {
                    textWashProccess.Text = null;
                    textWashProccess.Text += "Статус помилок:\n\nНедостача води";
                }
                else
                {
                    if (checkBoxTime1.Checked)
                    {
                        m = 0;
                        s = 30;
                    }
                    else if (checkBoxTime2.Checked)
                    {
                        m = 1;
                        s = 0;
                    }
                    else if (checkBoxTime3.Checked)
                    {
                        m = 1;
                        s = 30;
                    }
                    timer1.Start();
                    btnStart.Hide();
                    WashingProgram.WaterTank wt = new WashingProgram.WaterTank(this.sizeNeedWater, this.sizeWater);
                    stopCheck1 = 1;
                    StartWork();
                }
            }
            else
            {
                MessageBox.Show("Ви вибрали не всі параметри прання.");
            }
        }

        private void textWashProccess_TextChanged(object sender, EventArgs e)
        {

        }

		private void WashingProgram_Load(object sender, EventArgs e)
		{
			if (typeDetergent == checkBoxTypeDetergent1.Text)
			{
				checkBoxTypeDetergent1.Checked = true;
			}
			else if (typeDetergent == checkBoxTypeDetergent2.Text)
			{
				checkBoxTypeDetergent2.Checked = true;
			}
			else if (typeDetergent == checkBoxTypeDetergent3.Text)
			{
				checkBoxTypeDetergent3.Checked = true;
			}
			label10.Text = "Кількість води: " + sizeWater + "л";
            btnStop.Hide();
            btnStart.Show();
        }

		private void textWashProccess_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            ModeDescription modeDescription = new ModeDescription();
            modeDescription.Show();
        }

		private void button2_Click(object sender, EventArgs e)
		{
            EnterData enterData = new EnterData();
            this.Hide();
            enterData.Show();
        }

		private void btnStop_Click(object sender, EventArgs e)
        {
            if (stopCheck1 == 1)
            {
                btnStart.Show();
                m = 0;
                s = 0;
                textWashProccess.Text = null;
                textWashProccess.Text += "Машина вимкнена.\r\n\r\n";
                textWashProccess.Text += "Усі механізми відключені.\r\n";
                timer1.Stop();
                label7.Text = "00";
                label9.Text = "00";
                stopCheck1 = 0;
            }
            btnStop.Hide();
            btnStart.Show();
        }
        private int tickCheck = 0;
		private void timer1_Tick(object sender, EventArgs e)
        {
            if (label8.Visible)
            {
                if (m < 10)
                    label7.Text = "0" + m.ToString();
                else
                    label7.Text = m.ToString();

                if (s <= 59 && s > 0)
                {
                    s--;
                    if (s < 10)
                        label9.Text = "0" + s.ToString();
                    else
                        label9.Text = s.ToString();
                }
                else
                {
                    if (m < 59 && m > 0)
                    {
                        m--;
                        if (m < 10)
                            label7.Text = "0" + m.ToString();
                        else
                            label7.Text = m.ToString();
                        s = 59;
                        label9.Text = "00";
                    }
                    else
                    {
                        m = 0;
                        label7.Text = "00";
                    }

                }
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }

            if (label7.Text == "00" && label9.Text == "00" && label8.Visible == true)
            {
                switch (tickCheck) 
                {
                    case 1:
                        textWashProccess.Text += "\r\nЗапустився віджим.";
                        break;
                    case 4:
                        textWashProccess.Text += "\r\nВода злита.";
                        break;
                    case 8:
                        textWashProccess.Text += "Кінець прання.\r\n";
                        break;
                    case 12:
                        textWashProccess.Text += EndTank() + "\r\n";
                        break;
                    case 16:
                        textWashProccess.Text += EndMotor() + "\r\n";
                        break;
                    case 20:
                        textWashProccess.Text += EndBaraban() + "\r\n";
                        break;
                }
                tickCheck++;
            }
        }
    }
}