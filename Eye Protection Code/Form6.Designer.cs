using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using Task_9;
using System;

namespace Eye_Protection
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Timer timer1;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            button7 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(224, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 52);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 18);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 4;
            label8.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 18);
            label7.Name = "label7";
            label7.Size = new Size(12, 20);
            label7.TabIndex = 3;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 21);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 2;
            label6.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 21);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 1;
            label5.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 21);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 0;
            label4.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(86, 208);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 25;
            label3.Text = "Seconds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(86, 171);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 24;
            label2.Text = "Minutes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(86, 130);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 23;
            label1.Text = "Hours";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(21, 202);
            numericUpDown3.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(43, 27);
            numericUpDown3.TabIndex = 22;
            numericUpDown3.ValueChanged += numericUpDownSeconds_ValueChanged;
            numericUpDown3.KeyPress += numericUpDown1_KeyPress;
            numericUpDown3.Minimum = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(21, 165);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(43, 27);
            numericUpDown2.TabIndex = 21;
            numericUpDown2.ValueChanged += numericUpDownMinutes_ValueChanged;
            numericUpDown2.KeyPress += numericUpDown1_KeyPress;
            numericUpDown2.Minimum = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(21, 126);
            numericUpDown1.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 27);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.ValueChanged += numericUpDownHours_ValueChanged;
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
            numericUpDown1.Minimum = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(18, 66);
            button7.Name = "button7";
            button7.Size = new Size(132, 36);
            button7.TabIndex = 19;
            button7.Text = "Reset";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonReset_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(18, 24);
            button1.Name = "button1";
            button1.Size = new Size(132, 36);
            button1.TabIndex = 17;
            button1.Text = "Start/Stop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(430, 287);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form6";
            Text = "Notification";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        public Form6(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                groupBox1.ClientRectangle,
                Color.Purple,
                Color.Blue,
                LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradientBrush, groupBox1.ClientRectangle);
        }

        private TimeSpan remainingTime;

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));

                label4.Text = remainingTime.Hours.ToString("00");
                label5.Text = remainingTime.Minutes.ToString("00");
                label6.Text = remainingTime.Seconds.ToString("00");

                if (remainingTime.TotalSeconds % 5 == 0)
                {
                    Random random = new Random();
                    label4.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    label5.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    label6.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
            }
            else
            {
                timer1.Stop();
                Form5 form5 = new Form5();
                form5.Show();
            }
        }

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemainingTime();
        }

        private void numericUpDownMinutes_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemainingTime();
        }

        private void numericUpDownSeconds_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemainingTime();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            label4.Text = "00";
            label5.Text = "00";
            label6.Text = "00";

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        private void UpdateRemainingTime()
        {
            remainingTime = new TimeSpan((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            label4.Text = remainingTime.Hours.ToString("00");
            label5.Text = remainingTime.Minutes.ToString("00");
            label6.Text = remainingTime.Seconds.ToString("00");
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Form1 parentForm;
        private PictureBox pictureBox1;
        public NumericUpDown numericUpDown3;
        public NumericUpDown numericUpDown2;
        public NumericUpDown numericUpDown1;
        private Button button7;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
    }
}