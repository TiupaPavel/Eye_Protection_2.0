using Eye_Protection;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NAudio.Wave;

namespace Task_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemHide;
        private ToolStripMenuItem toolStripMenuItemShow;
        private Timer filterTimer = new Timer();

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            button6 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            label6 = new Label();
            button10 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button7 = new System.Windows.Forms.Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            changeToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            musicToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            restartStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            programToolStripMenuItem = new ToolStripMenuItem();
            developerToolStripMenuItem = new ToolStripMenuItem();
            version19ToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 277);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            label2.SizeChanged += CloseToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Eye Protection";
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(115, 52);
            contextMenuStrip2.Text = "Open";
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.Gray;
            openToolStripMenuItem.ForeColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 24);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.BackColor = Color.Gray;
            closeToolStripMenuItem.ForeColor = Color.Black;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(114, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(13, 75);
            button1.Name = "button1";
            button1.Size = new Size(149, 36);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(13, 117);
            button2.Name = "button2";
            button2.Size = new Size(149, 36);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(219, 117);
            button3.Name = "button3";
            button3.Size = new Size(149, 36);
            button3.TabIndex = 9;
            button3.Text = "Local Time";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 477);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(7, 23);
            label7.Name = "label7";
            label7.Size = new Size(83, 37);
            label7.TabIndex = 29;
            label7.Text = "User:";
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(219, 201);
            button6.Name = "button6";
            button6.Size = new Size(149, 36);
            button6.TabIndex = 28;
            button6.Text = "Select Music";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnSelectTrack_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gray;
            button9.ForeColor = Color.Black;
            button9.Location = new Point(13, 201);
            button9.Name = "button9";
            button9.Size = new Size(149, 36);
            button9.TabIndex = 27;
            button9.Text = "Custom Color";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button13_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(79, 23);
            label6.Name = "label6";
            label6.Size = new Size(38, 37);
            label6.TabIndex = 26;
            label6.Text = "...";
            // 
            // button10
            // 
            button10.BackColor = Color.Gray;
            button10.ForeColor = Color.Black;
            button10.Location = new Point(219, 159);
            button10.Name = "button10";
            button10.Size = new Size(149, 36);
            button10.TabIndex = 25;
            button10.Text = "Color Mix";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button14_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(13, 243);
            button5.Name = "button5";
            button5.Size = new Size(149, 36);
            button5.TabIndex = 23;
            button5.Text = "Disco Mode";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button9_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(219, 75);
            button4.Name = "button4";
            button4.Size = new Size(149, 36);
            button4.TabIndex = 22;
            button4.Text = "Notification";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button10_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(219, 243);
            button8.Name = "button8";
            button8.Size = new Size(149, 36);
            button8.TabIndex = 21;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(80, 210, 250);
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 364);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 20;
            label1.Text = "00:00:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(76, 228);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 64, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(199, 163);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 64, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(191, 155);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 17;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(13, 159);
            button7.Name = "button7";
            button7.Size = new Size(149, 36);
            button7.TabIndex = 16;
            button7.Text = "Background Color";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, musicToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(406, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = Color.Gray;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.BackColor = Color.Gray;
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(128, 26);
            openToolStripMenuItem1.Text = "Open";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Gray;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += buttonExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeToolStripMenuItem, saveToolStripMenuItem, deleteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // changeToolStripMenuItem
            // 
            changeToolStripMenuItem.BackColor = Color.Gray;
            changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            changeToolStripMenuItem.Size = new Size(142, 26);
            changeToolStripMenuItem.Text = "Change";
            changeToolStripMenuItem.Click += button12_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.Gray;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(142, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = Color.Gray;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(142, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += buttonDelete_Click;
            // 
            // musicToolStripMenuItem
            // 
            musicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem, restartStripMenuItem });
            musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            musicToolStripMenuItem.Size = new Size(61, 24);
            musicToolStripMenuItem.Text = "Music";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.BackColor = Color.Gray;
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(138, 26);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += btnStartMusic_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.BackColor = Color.Gray;
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(138, 26);
            stopToolStripMenuItem.Text = "Stop";
            stopToolStripMenuItem.Click += btnStopMusic_Click;
            // 
            // restartStripMenuItem
            // 
            restartStripMenuItem.BackColor = Color.Gray;
            restartStripMenuItem.Name = "restartStripMenuItem";
            restartStripMenuItem.Size = new Size(138, 26);
            restartStripMenuItem.Text = "Restart";
            restartStripMenuItem.Click += btnRestartMusic_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programToolStripMenuItem, developerToolStripMenuItem, version19ToolStripMenuItem1 });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.BackColor = Color.Gray;
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(163, 26);
            programToolStripMenuItem.Text = "Program";
            programToolStripMenuItem.Click += button6_Click;
            // 
            // developerToolStripMenuItem
            // 
            developerToolStripMenuItem.BackColor = Color.Gray;
            developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            developerToolStripMenuItem.Size = new Size(163, 26);
            developerToolStripMenuItem.Text = "Developer";
            developerToolStripMenuItem.Click += button5_Click;
            // 
            // version19ToolStripMenuItem1
            // 
            version19ToolStripMenuItem1.BackColor = Color.Gray;
            version19ToolStripMenuItem1.Name = "version19ToolStripMenuItem1";
            version19ToolStripMenuItem1.Size = new Size(163, 26);
            version19ToolStripMenuItem1.Text = "Version 2.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(406, 532);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Eye Protection";
            Load += Form1_Load_1;
            Resize += Form1_Resize;
            contextMenuStrip2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Form1 form1 = null;

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNotifyIcon();
        }

        private void InitializeNotifyIcon()
        {
            throw new NotImplementedException();
        }

        private void HideForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Hide();
            }
        }

        private void ShowForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Show();
                form1.WindowState = FormWindowState.Normal;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (form1 == null || form1.IsDisposed)
                {
                    form1 = new Form1();
                    form1.FormClosed += (s, args) => form1 = null;
                    form1.Show();
                }
                else
                {
                    form1.WindowState = FormWindowState.Normal;
                    form1.Activate();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                this.Hide();
                notifyIcon1.Visible = true;
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void ApplyScreenFilter()
        {
            try
            {
                SetGammaRamp(selectedRedGamma, selectedGreenGamma, selectedBlueGamma);
            }
            catch (Exception)
            {
            }
        }

        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(IntPtr hdc, void* ramp);

        [DllImport("gdi32.dll")]
        private static extern bool SetDeviceGammaRamp(IntPtr hdc, ref RampParams ramp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RampParams
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Red;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Green;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Blue;
        }

        private void SetGammaRamp(float red, float green, float blue)
        {
            RampParams ramp = new RampParams
            {
                Red = CalculateGammaRamp(red),
                Green = CalculateGammaRamp(green),
                Blue = CalculateGammaRamp(blue)
            };

            IntPtr hdc = IntPtr.Zero;

            try
            {
                hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
                SetDeviceGammaRamp(hdc, ref ramp);
            }
            finally
            {
                if (hdc != IntPtr.Zero)
                    Graphics.FromHwnd(IntPtr.Zero).ReleaseHdc(hdc);
            }
        }

        private ushort[] CalculateGammaRamp(float gamma)
        {
            const int size = 256;
            ushort[] ramp = new ushort[size];

            for (int i = 0; i < size; i++)
            {
                ramp[i] = (ushort)Math.Min(65535, Math.Pow(i / 255.0, 1.0 / gamma) * 65535);
            }

            return ramp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterTimer.Start();
            ApplyScreenFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterTimer.Stop();
            RestoreDefaultGamma();
        }

        private void RestoreDefaultGamma()
        {
            try
            {
                SetGammaRamp(1.0f, 1.0f, 1.0f);
            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void SaveProfile(string filePath, string userName, string selectedColor)
        {
            var profileData = $"{userName}\n{selectedColor}";
            File.WriteAllText(filePath, profileData);
        }

        private (string userName, string selectedColor) LoadProfile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            if (lines.Length >= 2)
            {
                return (lines[0], lines[1]);
            }
            return ("", "1.0;1.0;1.0");
        }

        private string lastProfilePath = "";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profileForm = new Form7();
            if (profileForm.ShowDialog() == DialogResult.OK)
            {
                label6.Text = profileForm.UserName;
                lastProfilePath = "";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            label6.Text = "...";
            RestoreDefaultGamma();
            lastProfilePath = null;
            selectedRedGamma = 1.0f;
            selectedGreenGamma = 1.0f;
            selectedBlueGamma = 1.0f;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Виберіть профіль для видалення";
            openFileDialog.Filter = "Файли профілю (*.profile)|*.profile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    if (File.Exists(selectedFilePath))
                    {
                        File.Delete(selectedFilePath);
                        Form11 form11 = new Form11();
                        form11.ShowDialog();
                        label6.Text = "...";
                    }
                    else
                    {
                        Form10 form10 = new Form10();
                        form10.ShowDialog();
                    }
                }
                catch (Exception)
                {
                    Form10 form10 = new Form10();
                    form10.ShowDialog();
                }
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            Form8 formEdit = new Form8();
            formEdit.textBox1.Text = label6.Text.Split('(')[0].Trim();
            formEdit.textBox2.Text = label6.Text.Split('(')[1].TrimEnd(')');
            formEdit.ShowDialog();
            label6.Text = formEdit.textBox1.Text + " (" + formEdit.textBox2.Text + ")";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastProfilePath))
            {
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Profile Files (*.profile)|*.profile";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        lastProfilePath = saveDialog.FileName;
                    }
                }
            }

            if (!string.IsNullOrEmpty(lastProfilePath))
            {
                SaveProfile(lastProfilePath, label6.Text, $"{selectedRedGamma};{selectedGreenGamma};{selectedBlueGamma}");
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Profile Files (*.profile)|*.profile";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    var (userName, colorValues) = LoadProfile(openDialog.FileName);
                    label6.Text = userName;

                    var colorParts = colorValues.Split(';');
                    if (colorParts.Length == 3 &&
                        float.TryParse(colorParts[0], out float red) &&
                        float.TryParse(colorParts[1], out float green) &&
                        float.TryParse(colorParts[2], out float blue))
                    {
                        SetSelectedColor(red, green, blue);
                        ApplyScreenFilter();
                    }
                }
            }
        }

        private void btnSelectTrack_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                }

                mp3Reader = new Mp3FileReader(filePath);
                waveOut = new WaveOutEvent();
                waveOut.Init(mp3Reader);
                waveOut.Play();
            }
        }

        private void btnStartMusic_Click(object sender, EventArgs e)
        {
            if (waveOut != null && mp3Reader != null)
            {
                waveOut.Play();
            }
        }

        private void btnStopMusic_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
            }
        }

        private void btnRestartMusic_Click(object sender, EventArgs e)
        {
            if (waveOut != null && mp3Reader != null)
            {
                mp3Reader.Position = 0;
                waveOut.Play();
            }
        }

        private Form _openForm = null;

        private void OpenForm(Form form)
        {
            if (_openForm != null)
            {
                _openForm.Close();
            }

            _openForm = form;
            _openForm.FormClosed += (s, args) => _openForm = null;
            _openForm.Show();
        }

        private Form2 form2Instance;

        private void button5_Click(object sender, EventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                form2Instance = new Form2(this);
                form2Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form3 form3Instance;

        private void button6_Click(object sender, EventArgs e)
        {
            if (form3Instance == null || form3Instance.IsDisposed)
            {
                form3Instance = new Form3(this);
                form3Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form4 form4Instance;

        private void button7_Click(object sender, EventArgs e)
        {
            if (form4Instance == null || form4Instance.IsDisposed)
            {
                form4Instance = new Form4(this);
                form4Instance.Show();
            }
            else
            {
                //
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form5 form5Instance;

        private void button9_Click(object sender, EventArgs e)
        {
            if (form5Instance == null || form5Instance.IsDisposed)
            {
                form5Instance = new Form5(this);
                form5Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form6 form6Instance;

        private void button10_Click(object sender, EventArgs e)
        {
            if (form6Instance == null || form6Instance.IsDisposed)
            {
                form6Instance = new Form6(this);
                form6Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form7 form7Instance;

        private void button11_Click(object sender, EventArgs e)
        {
            if (form7Instance == null || form7Instance.IsDisposed)
            {
                form7Instance = new Form7(this);
                form7Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form8 form8Instance;

        private void button12_Click(object sender, EventArgs e)
        {
            if (form8Instance == null || form8Instance.IsDisposed)
            {
                form8Instance = new Form8(this);
                form8Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form9 form9Instance;

        private void button13_Click(object sender, EventArgs e)
        {
            if (form9Instance == null || form9Instance.IsDisposed)
            {
                form9Instance = new Form9(this);
                form9Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form12 form12Instance;

        private void button14_Click(object sender, EventArgs e)
        {
            if (form12Instance == null || form12Instance.IsDisposed)
            {
                form12Instance = new Form12(this);
                form12Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form10 form10Instance;

        private void button997_Click(object sender, EventArgs e)
        {
            if (form10Instance == null || form10Instance.IsDisposed)
            {
                form10Instance = new Form10(this);
                form10Instance.Show();
            }
            else
            {
                //
            }
        }

        public void SetSelectedColor(float redGamma, float greenGamma, float blueGamma)
        {
            selectedRedGamma = redGamma;
            selectedGreenGamma = greenGamma;
            selectedBlueGamma = blueGamma;
        }

        private Label label2;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label1;
        private float selectedRedGamma = 1.0f;
        private float selectedGreenGamma = 1.0f;
        private float selectedBlueGamma = 1.0f;
        private System.Windows.Forms.Button button8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label7;
        private ToolStripMenuItem version19ToolStripMenuItem1;
        private WaveOutEvent waveOut;
        private Mp3FileReader mp3Reader;
        private ToolStripMenuItem musicToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem restartStripMenuItem;
    }
}