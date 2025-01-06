using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;
using Task_9;
using Eye_Protection;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static System.Windows.Forms.DataFormats;

namespace Eye_Protection
{
    public partial class Form4 : Form
    {
        private Form1 mainForm;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 64, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(6, 91);
            button4.Name = "button4";
            button4.Size = new Size(121, 31);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnOrange_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.ForeColor = Color.White;
            button3.Location = new Point(6, 56);
            button3.Name = "button3";
            button3.Size = new Size(121, 31);
            button3.TabIndex = 15;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnBrown_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.Location = new Point(6, 19);
            button2.Name = "button2";
            button2.Size = new Size(121, 31);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnRed_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(261, 128);
            button1.Name = "button1";
            button1.Size = new Size(121, 31);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPink_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.ForeColor = Color.White;
            button6.Location = new Point(261, 91);
            button6.Name = "button6";
            button6.Size = new Size(121, 31);
            button6.TabIndex = 22;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnWhite_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 192);
            button7.ForeColor = Color.White;
            button7.Location = new Point(133, 128);
            button7.Name = "button7";
            button7.Size = new Size(121, 31);
            button7.TabIndex = 21;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnPurple_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            button8.Location = new Point(261, 19);
            button8.Name = "button8";
            button8.Size = new Size(121, 31);
            button8.TabIndex = 20;
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnBlack_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Blue;
            button9.ForeColor = Color.White;
            button9.Location = new Point(133, 91);
            button9.Name = "button9";
            button9.Size = new Size(121, 31);
            button9.TabIndex = 19;
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnBlue_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Cyan;
            button10.ForeColor = Color.WhiteSmoke;
            button10.Location = new Point(134, 56);
            button10.Name = "button10";
            button10.Size = new Size(121, 31);
            button10.TabIndex = 18;
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnCyan_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Lime;
            button11.ForeColor = Color.White;
            button11.Location = new Point(134, 19);
            button11.Name = "button11";
            button11.Size = new Size(121, 31);
            button11.TabIndex = 23;
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnLime_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gray;
            button12.ForeColor = Color.White;
            button12.Location = new Point(261, 56);
            button12.Name = "button12";
            button12.Size = new Size(121, 31);
            button12.TabIndex = 24;
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnGray_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumBlue;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button9);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 178);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.ForeColor = Color.White;
            button5.Location = new Point(6, 128);
            button5.Name = "button5";
            button5.Size = new Size(121, 31);
            button5.TabIndex = 25;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnYellow_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(416, 199);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            Text = "Background Color";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
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

        [DllImport("gdi32.dll")]
        static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [StructLayout(LayoutKind.Sequential)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] blue;
        }

        public Form4(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(1.2f, 0.8f, 0.8f);
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.6f, 0.4f, 0.3f);
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(1.0f, 0.6f, 0.3f);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.5f, 1.0f, 0.5f);
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(1.3f, 1.3f, 1.3f);
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.6f, 0.4f, 0.8f);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.4f, 0.4f, 0.4f);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.5f, 0.5f, 1.0f);
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.5f, 1.0f, 1.0f);
        }

        private void btnLime_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.5f, 1.0f, 0.5f);
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(0.6f, 0.6f, 0.6f);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(1.0f, 1.0f, 0.5f);
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(1.0f, 0.6f, 0.8f);
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private Form1 mainForm2;
    }
}