namespace WashingMachine
{
	partial class EnterData
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.sizeWaterText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.submitBtn = new System.Windows.Forms.Button();
			this.typeDetergent = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(25, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введіть деталі прання";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(26, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Тип порошку:";
			// 
			// sizeWaterText
			// 
			this.sizeWaterText.Location = new System.Drawing.Point(254, 87);
			this.sizeWaterText.Name = "sizeWaterText";
			this.sizeWaterText.Size = new System.Drawing.Size(100, 20);
			this.sizeWaterText.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(26, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Кількість води (у літрах):";
			// 
			// submitBtn
			// 
			this.submitBtn.BackColor = System.Drawing.Color.Green;
			this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.submitBtn.ForeColor = System.Drawing.Color.White;
			this.submitBtn.Location = new System.Drawing.Point(29, 180);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.Size = new System.Drawing.Size(325, 36);
			this.submitBtn.TabIndex = 4;
			this.submitBtn.Text = "Підтвердити";
			this.submitBtn.UseVisualStyleBackColor = false;
			this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
			// 
			// typeDetergent
			// 
			this.typeDetergent.Location = new System.Drawing.Point(254, 134);
			this.typeDetergent.Name = "typeDetergent";
			this.typeDetergent.Size = new System.Drawing.Size(100, 20);
			this.typeDetergent.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(132, 260);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 42);
			this.button1.TabIndex = 6;
			this.button1.Text = "Повернутися";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// EnterData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(383, 314);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.typeDetergent);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sizeWaterText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EnterData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter";
			this.Load += new System.EventHandler(this.Enter_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox sizeWaterText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button submitBtn;
		private System.Windows.Forms.TextBox typeDetergent;
		private System.Windows.Forms.Button button1;
	}
}