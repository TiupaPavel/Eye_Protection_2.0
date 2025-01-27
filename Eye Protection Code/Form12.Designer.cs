using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using Task_9;
using System;
using System.Runtime.InteropServices;

namespace Eye_Protection
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            groupBox1 = new GroupBox();
            button2 = new Button();
            button12 = new Button();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            button10 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumBlue;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button10);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 137);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(8, 19);
            button2.Name = "button2";
            button2.Size = new Size(127, 31);
            button2.TabIndex = 14;
            button2.Text = "Red + Blue";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnRedBlue_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gray;
            button12.ForeColor = Color.HotPink;
            button12.Location = new Point(141, 56);
            button12.Name = "button12";
            button12.Size = new Size(127, 31);
            button12.TabIndex = 24;
            button12.Text = "Gray + Pink";
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnGrayPink_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.ForeColor = Color.Orange;
            button3.Location = new Point(8, 93);
            button3.Name = "button3";
            button3.Size = new Size(127, 31);
            button3.TabIndex = 15;
            button3.Text = "Brown + Orange";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnBrownOrange_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 192);
            button7.ForeColor = Color.Yellow;
            button7.Location = new Point(8, 56);
            button7.Name = "button7";
            button7.Size = new Size(127, 31);
            button7.TabIndex = 21;
            button7.Text = "Purple + Yellow";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnPurpleYellow_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            button8.Location = new Point(141, 19);
            button8.Name = "button8";
            button8.Size = new Size(127, 31);
            button8.TabIndex = 20;
            button8.Text = "Black + White";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnBlackWhite_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Cyan;
            button10.ForeColor = Color.Green;
            button10.Location = new Point(141, 93);
            button10.Name = "button10";
            button10.Size = new Size(127, 31);
            button10.TabIndex = 18;
            button10.Text = "Cyan + Green";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnCyanGreen_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(301, 161);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form12";
            Text = "Color Mix";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
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

        public Form12(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
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

        private void btnRedBlue_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(
                (1.2f + 0.5f) / 2,
                (0.8f + 0.5f) / 2,
                (0.8f + 1.0f) / 2
            );
        }

        private void btnBlackWhite_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(
                (0.4f + 1.3f) / 2,
                (0.4f + 1.3f) / 2,
                (0.4f + 1.3f) / 2
            );
        }

        private void btnPurpleYellow_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(
                (0.6f + 1.0f) / 2,
                (0.4f + 1.0f) / 2,
                (0.8f + 0.5f) / 2
            );
        }

        private void btnGrayPink_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(
                (0.6f + 1.0f) / 2,
                (0.6f + 0.6f) / 2,
                (0.6f + 0.8f) / 2
            );
        }

        private void btnBrownOrange_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(
                (0.6f + 1.0f) / 2,
                (0.4f + 0.6f) / 2,
                (0.3f + 0.3f) / 2
            );
        }

        private void btnCyanGreen_Click(object sender, EventArgs e)
        {
            mainForm.SetSelectedColor(
                (0.5f + 0.5f) / 2,
                (1.0f + 1.0f) / 2,
                (1.0f + 0.5f) / 2
            );
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private Form1 mainForm;
    }
}