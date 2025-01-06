using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using Task_9;
using System.Reflection.Emit;
using System;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eye_Protection
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            groupBox1 = new GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1.MaxLength = 19;
            textBox2.MaxLength = 19;
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 171);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 27);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(39, 116);
            button2.Name = "button2";
            button2.Size = new Size(149, 36);
            button2.TabIndex = 6;
            button2.Text = "Open";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnOpenProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(65, 23);
            label1.Name = "label1";
            label1.Size = new Size(254, 23);
            label1.TabIndex = 3;
            label1.Text = "Your new name and nickname:";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(194, 116);
            button1.Name = "button1";
            button1.Size = new Size(149, 36);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSaveProfile_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(10, 27);
            textBox2.TabIndex = 7;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(407, 195);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form8";
            Text = "Change Profile";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public Form8(Form1 parent)
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

        private void LoadProfile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] profileData = File.ReadAllLines(filePath);
                if (profileData.Length >= 2)
                {
                    textBox1.Text = profileData[0];
                    textBox2.Text = profileData[1];
                }
            }
        }

        private void SaveProfile(string filePath)
        {
            string newName = textBox1.Text;
            string newNick = textBox2.Text;
            File.WriteAllLines(filePath, new string[] { newName, newNick });
        }

        private void btnOpenProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Profile Files (*.profile)|*.profile|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadProfile(openFileDialog.FileName);
                }
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Profile Files (*.profile)|*.profile|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveProfile(saveFileDialog.FileName);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Зберігаємо ім'я і нік, введені в текстові поля
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Form1 parentForm;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
    }
}