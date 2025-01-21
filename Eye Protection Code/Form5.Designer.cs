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
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Form1 parentForm;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            groupBox1 = new GroupBox();
            label3 = new Label();
            colorChangeTimer1 = new Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(20, 53);
            label3.Name = "label3";
            label3.Size = new Size(406, 70);
            label3.TabIndex = 15;
            label3.Text = "Until the window is closed, \r\n the disco mode will be on.";
            // 
            // colorChangeTimer1
            // 
            colorChangeTimer1.Enabled = true;
            colorChangeTimer1.Interval = 300;
            colorChangeTimer1.Tick += ColorChangeTimer_Tick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(433, 211);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            Text = "Disco Mode";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        public Form5(Form1 parent)
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

        private struct GammaColor
        {
            public float Red { get; }
            public float Green { get; }
            public float Blue { get; }

            public GammaColor(float red, float green, float blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
        }

        private readonly GammaColor[] gammaColors = new[]
        {
            new GammaColor(1.2f, 0.8f, 0.8f),
            new GammaColor(0.6f, 0.4f, 0.3f),
            new GammaColor(1.0f, 0.6f, 0.3f),
            new GammaColor(0.5f, 1.0f, 0.5f),
            new GammaColor(1.3f, 1.3f, 1.3f),
            new GammaColor(0.6f, 0.4f, 0.8f),
            new GammaColor(0.4f, 0.4f, 0.4f),
            new GammaColor(0.5f, 0.5f, 1.0f)
        };

        private void InitializeColorChangeTimer()
        {
            colorChangeTimer1 = new Timer();
            colorChangeTimer1.Interval = 300;
            colorChangeTimer1.Tick += ColorChangeTimer_Tick;
            colorChangeTimer1.Start();
        }

        private void ColorChangeTimer_Tick(object sender, EventArgs e)
        {
            ApplyGamma(gammaColors[currentColorIndex]);
            currentColorIndex = (currentColorIndex + 1) % gammaColors.Length;
        }

        private void ApplyGamma(GammaColor gamma)
        {
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr hDC = g.GetHdc();
                RAMP ramp = new RAMP
                {
                    red = new ushort[256],
                    green = new ushort[256],
                    blue = new ushort[256]
                };

                for (int i = 0; i < 256; i++)
                {
                    ramp.red[i] = (ushort)Math.Min(65535, (int)(i * gamma.Red) << 8);
                    ramp.green[i] = (ushort)Math.Min(65535, (int)(i * gamma.Green) << 8);
                    ramp.blue[i] = (ushort)Math.Min(65535, (int)(i * gamma.Blue) << 8);
                }

                SetDeviceGammaRamp(hDC, ref ramp);
                g.ReleaseHdc(hDC);
            }
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private object colorChangeTimer;
        private int currentColorIndex;
        private Timer colorChangeTimer1;
    }
}