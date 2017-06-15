namespace coordinateTextManpulator
{
	partial class Form1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tripButton = new System.Windows.Forms.Button();
            this.stopsButton = new System.Windows.Forms.Button();
            this.forbiddenButton = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.exportButton = new System.Windows.Forms.Button();
            this.toolTipOnAll = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 198);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(123, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "export red only";
            this.toolTipOnAll.SetToolTip(this.radioButton1, "choose to have only red pins appear and exported");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 225);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton2.Size = new System.Drawing.Size(127, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "red and orange";
            this.toolTipOnAll.SetToolTip(this.radioButton2, "choose to have only red and orrange pins appear and exported");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 252);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton3.Size = new System.Drawing.Size(86, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "export all";
            this.toolTipOnAll.SetToolTip(this.radioButton3, "export all red orange and forbidden");
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(141, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(249, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "stops close to forbidden spots only";
            this.toolTipOnAll.SetToolTip(this.checkBox1, "export only the stops in forbidden areas");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(265, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            this.toolTipOnAll.SetToolTip(this.numericUpDown1, "choose the nuber of minutes ABOVE witch the pins on the map will be orange ");
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(265, 41);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 5;
            this.toolTipOnAll.SetToolTip(this.numericUpDown2, "choose the nuber of minutes ABOVE witch the pins on the map will be red ");
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(190, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "red";
            this.toolTipOnAll.SetToolTip(this.textBox1, "choose the nuber of minutes ABOVE witch the pins on the map will be red ");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(190, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(69, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "orange";
            this.toolTipOnAll.SetToolTip(this.textBox2, "choose the nuber of minutes ABOVE witch the pins on the map will be orange ");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // tripButton
            // 
            this.tripButton.Location = new System.Drawing.Point(12, 12);
            this.tripButton.Name = "tripButton";
            this.tripButton.Size = new System.Drawing.Size(158, 23);
            this.tripButton.TabIndex = 8;
            this.tripButton.Text = "import trip stops";
            this.toolTipOnAll.SetToolTip(this.tripButton, "load a txt file containing the trip details, in the format of provided trip.txt");
            this.tripButton.UseVisualStyleBackColor = true;
            this.tripButton.Click += new System.EventHandler(this.tripButton_Click);
            // 
            // stopsButton
            // 
            this.stopsButton.Location = new System.Drawing.Point(12, 40);
            this.stopsButton.Name = "stopsButton";
            this.stopsButton.Size = new System.Drawing.Size(158, 23);
            this.stopsButton.TabIndex = 9;
            this.stopsButton.Text = "import expected stops";
            this.toolTipOnAll.SetToolTip(this.stopsButton, "load a txt file containing the expected trip stops, in the format of provided sto" +
        "ps.txt\r\nIf an expected is not in the stops exported a yellow pin is to be create" +
        "d\r\n");
            this.stopsButton.UseVisualStyleBackColor = true;
            this.stopsButton.Click += new System.EventHandler(this.stopsButton_Click);
            // 
            // forbiddenButton
            // 
            this.forbiddenButton.Location = new System.Drawing.Point(12, 68);
            this.forbiddenButton.Name = "forbiddenButton";
            this.forbiddenButton.Size = new System.Drawing.Size(158, 23);
            this.forbiddenButton.TabIndex = 10;
            this.forbiddenButton.Text = "import forbidden spots";
            this.toolTipOnAll.SetToolTip(this.forbiddenButton, "load a txt file with the coordinates of the spots that the trip should not stop");
            this.forbiddenButton.UseVisualStyleBackColor = true;
            this.forbiddenButton.Click += new System.EventHandler(this.forbiddenButton_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(141, 97);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(104, 96);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "export";
            this.toolTipOnAll.SetToolTip(this.exportButton, "Save a txt file with the details of the stops you have chosen and pop up a google" +
        " maps with the chosen stops pinned");
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // toolTipOnAll
            // 
            this.toolTipOnAll.Active = false;
            this.toolTipOnAll.AutoPopDelay = 5000;
            this.toolTipOnAll.InitialDelay = 500;
            this.toolTipOnAll.ReshowDelay = 200;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(283, 252);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 21);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "enable hints";
            this.toolTipOnAll.SetToolTip(this.checkBox2, "tick this if you want to kill me");
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(210, 225);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(180, 21);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "make forbidden into red";
            this.toolTipOnAll.SetToolTip(this.checkBox3, "treat stops in forbidden areas like red stops");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(265, 69);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 15;
            this.toolTipOnAll.SetToolTip(this.numericUpDown3, "length in meters of the square with center each forbidden spot, whose area will b" +
        "e considered forbidden");
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(190, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(69, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 285);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.forbiddenButton);
            this.Controls.Add(this.stopsButton);
            this.Controls.Add(this.tripButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button tripButton;
        private System.Windows.Forms.Button stopsButton;
        private System.Windows.Forms.Button forbiddenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.ToolTip toolTipOnAll;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

