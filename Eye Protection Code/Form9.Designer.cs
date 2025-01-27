using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using Task_9;
using System;
using static System.Windows.Forms.DataFormats;

namespace Eye_Protection
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(113, 116);
            button1.Name = "button1";
            button1.Size = new Size(149, 36);
            button1.TabIndex = 5;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnApplyColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(76, 14);
            label1.Name = "label1";
            label1.Size = new Size(243, 46);
            label1.TabIndex = 4;
            label1.Text = "      Enter your hex-color:\r\n(not all colors are supported)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 27);
            textBox1.TabIndex = 0;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(407, 195);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form9";
            Text = "Custom Color";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        public Form9(Form1 form1)
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

        private void btnApplyColor_Click(object sender, EventArgs e)
        {
            string hexColor = textBox1.Text.Trim();

            if (IsValidHexColor(hexColor))
            {
                var color = System.Drawing.ColorTranslator.FromHtml(hexColor);
                float redGamma = color.R / 255f * 2.2f;
                float greenGamma = color.G / 255f * 2.2f;
                float blueGamma = color.B / 255f * 2.2f;

                mainForm.SetSelectedColor(redGamma, greenGamma, blueGamma);
            }
            else
            {
                Form10 form10 = new Form10();
                form10.ShowDialog();
            }
        }

        private bool IsValidHexColor(string hex)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(hex, "^#([A-Fa-f0-9]{6})$");
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Form1 mainForm;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}