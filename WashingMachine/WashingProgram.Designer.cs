namespace WashingMachine
{
	partial class WashingProgram
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnModeSport = new System.Windows.Forms.Button();
			this.btnModeLight = new System.Windows.Forms.Button();
			this.btnModeDelicacy = new System.Windows.Forms.Button();
			this.btnModeFullLoop = new System.Windows.Forms.Button();
			this.btnModeFast = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.label43 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBoxTemp1 = new System.Windows.Forms.CheckBox();
			this.checkBoxTemp2 = new System.Windows.Forms.CheckBox();
			this.checkBoxTemp3 = new System.Windows.Forms.CheckBox();
			this.checkBoxRotationSpeed1 = new System.Windows.Forms.CheckBox();
			this.checkBoxRotationSpeed2 = new System.Windows.Forms.CheckBox();
			this.checkBoxRotationSpeed3 = new System.Windows.Forms.CheckBox();
			this.checkBoxTime1 = new System.Windows.Forms.CheckBox();
			this.checkBoxTime2 = new System.Windows.Forms.CheckBox();
			this.checkBoxTime3 = new System.Windows.Forms.CheckBox();
			this.checkBoxTypeDetergent1 = new System.Windows.Forms.CheckBox();
			this.checkBoxTypeDetergent2 = new System.Windows.Forms.CheckBox();
			this.checkBoxTypeDetergent3 = new System.Windows.Forms.CheckBox();
			this.textWashProccess = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnStop = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnModeSport
			// 
			this.btnModeSport.BackColor = System.Drawing.Color.Green;
			this.btnModeSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnModeSport.ForeColor = System.Drawing.Color.White;
			this.btnModeSport.Location = new System.Drawing.Point(26, 73);
			this.btnModeSport.Name = "btnModeSport";
			this.btnModeSport.Size = new System.Drawing.Size(113, 35);
			this.btnModeSport.TabIndex = 0;
			this.btnModeSport.Text = "\"Спорт\"";
			this.btnModeSport.UseVisualStyleBackColor = false;
			this.btnModeSport.Click += new System.EventHandler(this.btnModeSport_Click);
			// 
			// btnModeLight
			// 
			this.btnModeLight.BackColor = System.Drawing.Color.Green;
			this.btnModeLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnModeLight.ForeColor = System.Drawing.Color.White;
			this.btnModeLight.Location = new System.Drawing.Point(25, 122);
			this.btnModeLight.Name = "btnModeLight";
			this.btnModeLight.Size = new System.Drawing.Size(114, 35);
			this.btnModeLight.TabIndex = 1;
			this.btnModeLight.Text = "\"Лайт\"";
			this.btnModeLight.UseVisualStyleBackColor = false;
			this.btnModeLight.Click += new System.EventHandler(this.btnModeLight_Click);
			// 
			// btnModeDelicacy
			// 
			this.btnModeDelicacy.BackColor = System.Drawing.Color.Green;
			this.btnModeDelicacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnModeDelicacy.ForeColor = System.Drawing.Color.White;
			this.btnModeDelicacy.Location = new System.Drawing.Point(25, 169);
			this.btnModeDelicacy.Name = "btnModeDelicacy";
			this.btnModeDelicacy.Size = new System.Drawing.Size(114, 35);
			this.btnModeDelicacy.TabIndex = 2;
			this.btnModeDelicacy.Text = "\"Делікатність\"";
			this.btnModeDelicacy.UseVisualStyleBackColor = false;
			this.btnModeDelicacy.Click += new System.EventHandler(this.btnModeDelicacy_Click);
			// 
			// btnModeFullLoop
			// 
			this.btnModeFullLoop.BackColor = System.Drawing.Color.Green;
			this.btnModeFullLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnModeFullLoop.ForeColor = System.Drawing.Color.White;
			this.btnModeFullLoop.Location = new System.Drawing.Point(25, 216);
			this.btnModeFullLoop.Name = "btnModeFullLoop";
			this.btnModeFullLoop.Size = new System.Drawing.Size(114, 35);
			this.btnModeFullLoop.TabIndex = 3;
			this.btnModeFullLoop.Text = "\"Повний цикл\"";
			this.btnModeFullLoop.UseVisualStyleBackColor = false;
			this.btnModeFullLoop.Click += new System.EventHandler(this.btnModeFullLoop_Click);
			// 
			// btnModeFast
			// 
			this.btnModeFast.BackColor = System.Drawing.Color.Green;
			this.btnModeFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnModeFast.ForeColor = System.Drawing.Color.White;
			this.btnModeFast.Location = new System.Drawing.Point(25, 268);
			this.btnModeFast.Name = "btnModeFast";
			this.btnModeFast.Size = new System.Drawing.Size(114, 35);
			this.btnModeFast.TabIndex = 4;
			this.btnModeFast.Text = "\"Швидке прання\"";
			this.btnModeFast.UseVisualStyleBackColor = false;
			this.btnModeFast.Click += new System.EventHandler(this.btnModeFast_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(21, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(251, 20);
			this.label12.TabIndex = 5;
			this.label12.Text = "Автоматичні режими прання";
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Green;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStart.ForeColor = System.Drawing.Color.White;
			this.btnStart.Location = new System.Drawing.Point(416, 360);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(96, 50);
			this.btnStart.TabIndex = 8;
			this.btnStart.Text = "Пуск";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label43.Location = new System.Drawing.Point(330, 23);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(226, 20);
			this.label43.TabIndex = 10;
			this.label43.Text = "Настройка прання вручну";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(344, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Температура";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(483, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Швидкість обертів";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(345, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Час";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(483, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Тип порошку";
			// 
			// checkBoxTemp1
			// 
			this.checkBoxTemp1.AutoSize = true;
			this.checkBoxTemp1.Location = new System.Drawing.Point(347, 96);
			this.checkBoxTemp1.Name = "checkBoxTemp1";
			this.checkBoxTemp1.Size = new System.Drawing.Size(38, 17);
			this.checkBoxTemp1.TabIndex = 15;
			this.checkBoxTemp1.Text = "90";
			this.checkBoxTemp1.UseVisualStyleBackColor = true;
			// 
			// checkBoxTemp2
			// 
			this.checkBoxTemp2.AutoSize = true;
			this.checkBoxTemp2.Location = new System.Drawing.Point(347, 133);
			this.checkBoxTemp2.Name = "checkBoxTemp2";
			this.checkBoxTemp2.Size = new System.Drawing.Size(38, 17);
			this.checkBoxTemp2.TabIndex = 16;
			this.checkBoxTemp2.Text = "60";
			this.checkBoxTemp2.UseVisualStyleBackColor = true;
			// 
			// checkBoxTemp3
			// 
			this.checkBoxTemp3.AutoSize = true;
			this.checkBoxTemp3.Location = new System.Drawing.Point(347, 169);
			this.checkBoxTemp3.Name = "checkBoxTemp3";
			this.checkBoxTemp3.Size = new System.Drawing.Size(38, 17);
			this.checkBoxTemp3.TabIndex = 17;
			this.checkBoxTemp3.Text = "30";
			this.checkBoxTemp3.UseVisualStyleBackColor = true;
			// 
			// checkBoxRotationSpeed1
			// 
			this.checkBoxRotationSpeed1.AutoSize = true;
			this.checkBoxRotationSpeed1.Location = new System.Drawing.Point(486, 96);
			this.checkBoxRotationSpeed1.Name = "checkBoxRotationSpeed1";
			this.checkBoxRotationSpeed1.Size = new System.Drawing.Size(50, 17);
			this.checkBoxRotationSpeed1.TabIndex = 18;
			this.checkBoxRotationSpeed1.Text = "1200";
			this.checkBoxRotationSpeed1.UseVisualStyleBackColor = true;
			// 
			// checkBoxRotationSpeed2
			// 
			this.checkBoxRotationSpeed2.AutoSize = true;
			this.checkBoxRotationSpeed2.Location = new System.Drawing.Point(486, 133);
			this.checkBoxRotationSpeed2.Name = "checkBoxRotationSpeed2";
			this.checkBoxRotationSpeed2.Size = new System.Drawing.Size(44, 17);
			this.checkBoxRotationSpeed2.TabIndex = 19;
			this.checkBoxRotationSpeed2.Text = "800";
			this.checkBoxRotationSpeed2.UseVisualStyleBackColor = true;
			// 
			// checkBoxRotationSpeed3
			// 
			this.checkBoxRotationSpeed3.AutoSize = true;
			this.checkBoxRotationSpeed3.Location = new System.Drawing.Point(486, 169);
			this.checkBoxRotationSpeed3.Name = "checkBoxRotationSpeed3";
			this.checkBoxRotationSpeed3.Size = new System.Drawing.Size(44, 17);
			this.checkBoxRotationSpeed3.TabIndex = 20;
			this.checkBoxRotationSpeed3.Text = "600";
			this.checkBoxRotationSpeed3.UseVisualStyleBackColor = true;
			// 
			// checkBoxTime1
			// 
			this.checkBoxTime1.AutoSize = true;
			this.checkBoxTime1.Location = new System.Drawing.Point(348, 242);
			this.checkBoxTime1.Name = "checkBoxTime1";
			this.checkBoxTime1.Size = new System.Drawing.Size(53, 17);
			this.checkBoxTime1.TabIndex = 21;
			this.checkBoxTime1.Text = "30:00";
			this.checkBoxTime1.UseVisualStyleBackColor = true;
			// 
			// checkBoxTime2
			// 
			this.checkBoxTime2.AutoSize = true;
			this.checkBoxTime2.Location = new System.Drawing.Point(348, 279);
			this.checkBoxTime2.Name = "checkBoxTime2";
			this.checkBoxTime2.Size = new System.Drawing.Size(68, 17);
			this.checkBoxTime2.TabIndex = 22;
			this.checkBoxTime2.Text = "01:00:00";
			this.checkBoxTime2.UseVisualStyleBackColor = true;
			// 
			// checkBoxTime3
			// 
			this.checkBoxTime3.AutoSize = true;
			this.checkBoxTime3.Location = new System.Drawing.Point(348, 315);
			this.checkBoxTime3.Name = "checkBoxTime3";
			this.checkBoxTime3.Size = new System.Drawing.Size(68, 17);
			this.checkBoxTime3.TabIndex = 23;
			this.checkBoxTime3.Text = "01:30:00";
			this.checkBoxTime3.UseVisualStyleBackColor = true;
			// 
			// checkBoxTypeDetergent1
			// 
			this.checkBoxTypeDetergent1.AutoSize = true;
			this.checkBoxTypeDetergent1.Location = new System.Drawing.Point(486, 242);
			this.checkBoxTypeDetergent1.Name = "checkBoxTypeDetergent1";
			this.checkBoxTypeDetergent1.Size = new System.Drawing.Size(97, 17);
			this.checkBoxTypeDetergent1.TabIndex = 24;
			this.checkBoxTypeDetergent1.Text = "Комбінований";
			this.checkBoxTypeDetergent1.UseVisualStyleBackColor = true;
			// 
			// checkBoxTypeDetergent2
			// 
			this.checkBoxTypeDetergent2.AutoSize = true;
			this.checkBoxTypeDetergent2.Location = new System.Drawing.Point(486, 279);
			this.checkBoxTypeDetergent2.Name = "checkBoxTypeDetergent2";
			this.checkBoxTypeDetergent2.Size = new System.Drawing.Size(59, 17);
			this.checkBoxTypeDetergent2.TabIndex = 25;
			this.checkBoxTypeDetergent2.Text = "Рідкий";
			this.checkBoxTypeDetergent2.UseVisualStyleBackColor = true;
			// 
			// checkBoxTypeDetergent3
			// 
			this.checkBoxTypeDetergent3.AutoSize = true;
			this.checkBoxTypeDetergent3.Location = new System.Drawing.Point(486, 315);
			this.checkBoxTypeDetergent3.Name = "checkBoxTypeDetergent3";
			this.checkBoxTypeDetergent3.Size = new System.Drawing.Size(55, 17);
			this.checkBoxTypeDetergent3.TabIndex = 26;
			this.checkBoxTypeDetergent3.Text = "Сухий";
			this.checkBoxTypeDetergent3.UseVisualStyleBackColor = true;
			// 
			// textWashProccess
			// 
			this.textWashProccess.BackColor = System.Drawing.Color.White;
			this.textWashProccess.Location = new System.Drawing.Point(26, 339);
			this.textWashProccess.Multiline = true;
			this.textWashProccess.Name = "textWashProccess";
			this.textWashProccess.ReadOnly = true;
			this.textWashProccess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textWashProccess.Size = new System.Drawing.Size(235, 149);
			this.textWashProccess.TabIndex = 27;
			this.textWashProccess.TextChanged += new System.EventHandler(this.textWashProccess_TextChanged_1);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Red;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStop.ForeColor = System.Drawing.Color.White;
			this.btnStop.Location = new System.Drawing.Point(416, 360);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(96, 50);
			this.btnStop.TabIndex = 10;
			this.btnStop.Text = "Зупинити";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(393, 445);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 37);
			this.label7.TabIndex = 31;
			this.label7.Text = "00";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(452, 445);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 37);
			this.label8.TabIndex = 32;
			this.label8.Text = ":";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(484, 445);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 37);
			this.label9.TabIndex = 33;
			this.label9.Text = "00";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Green;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(171, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 31);
			this.button1.TabIndex = 34;
			this.button1.Text = "Опис режимів";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(168, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 20);
			this.label5.TabIndex = 35;
			this.label5.Text = "Опис режимів";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DodgerBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(171, 242);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 26);
			this.button2.TabIndex = 36;
			this.button2.Text = "Змінити";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(167, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 40);
			this.label6.TabIndex = 37;
			this.label6.Text = "Змінити кількість\r\nводи";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(168, 283);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 13);
			this.label10.TabIndex = 38;
			this.label10.Text = "Кількість води:";
			// 
			// WashingProgram
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(647, 507);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.textWashProccess);
			this.Controls.Add(this.checkBoxTypeDetergent3);
			this.Controls.Add(this.checkBoxTypeDetergent2);
			this.Controls.Add(this.checkBoxTypeDetergent1);
			this.Controls.Add(this.checkBoxTime3);
			this.Controls.Add(this.checkBoxTime2);
			this.Controls.Add(this.checkBoxTime1);
			this.Controls.Add(this.checkBoxRotationSpeed3);
			this.Controls.Add(this.checkBoxRotationSpeed2);
			this.Controls.Add(this.checkBoxRotationSpeed1);
			this.Controls.Add(this.checkBoxTemp3);
			this.Controls.Add(this.checkBoxTemp2);
			this.Controls.Add(this.checkBoxTemp1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label43);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnModeFast);
			this.Controls.Add(this.btnModeFullLoop);
			this.Controls.Add(this.btnModeDelicacy);
			this.Controls.Add(this.btnModeLight);
			this.Controls.Add(this.btnModeSport);
			this.Name = "WashingProgram";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.WashingProgram_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnModeSport;
		private System.Windows.Forms.Button btnModeLight;
		private System.Windows.Forms.Button btnModeDelicacy;
		private System.Windows.Forms.Button btnModeFullLoop;
		private System.Windows.Forms.Button btnModeFast;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxTemp1;
		private System.Windows.Forms.CheckBox checkBoxTemp2;
		private System.Windows.Forms.CheckBox checkBoxTemp3;
		private System.Windows.Forms.CheckBox checkBoxRotationSpeed1;
		private System.Windows.Forms.CheckBox checkBoxRotationSpeed2;
		private System.Windows.Forms.CheckBox checkBoxRotationSpeed3;
		private System.Windows.Forms.CheckBox checkBoxTime1;
		private System.Windows.Forms.CheckBox checkBoxTime2;
		private System.Windows.Forms.CheckBox checkBoxTime3;
		private System.Windows.Forms.CheckBox checkBoxTypeDetergent1;
		private System.Windows.Forms.CheckBox checkBoxTypeDetergent2;
		private System.Windows.Forms.CheckBox checkBoxTypeDetergent3;
		private System.Windows.Forms.TextBox textWashProccess;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
	}
}