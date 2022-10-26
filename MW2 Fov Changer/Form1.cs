using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace MW2_Fov_Changer
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        #region hooking + winform styling


        Mem m = new Mem();

        bool ProcOpen = false;
        string processName = "iw4mp";  // process handle name here

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess(processName);
            if (!ProcOpen)
            {
                Thread.Sleep(1500);

                return;
            }
            Thread.Sleep(1500);

            backgroundWorker1.ReportProgress(0);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private async void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                gameStatusLabel.ForeColor = Color.SeaGreen;
                gameStatusLabel.Text = "Game Found!";
                m.OpenProcess(processName);
            }
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Point offset;
        bool mousedown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        #endregion

        #region setting FPS

        private void setFPS_CheckedChanged(object sender, EventArgs e)
        {
            if (setFPS.Checked)
            {
                FPSTimer.Start();
            }
            else
            {
                FPSTimer.Stop();
            }
        }
        private void FPS_Tick(object sender, EventArgs e)
        {
            Fps();
        }

        void Fps()
        {
            try
            {
                if (m.ReadInt("0x063815AC").ToString() != fpsVal.Text)
                {
                    m.WriteMemory("0x063815AC", "int", fpsVal.Text);
                }

            }
            catch
            {

            }
        }

        #endregion

        void FOV()
        {
            try
            {
                if (m.ReadInt("063932AC").ToString() != fovVal.Text)
                {
                    m.WriteMemory("063932AC", "float", fovVal.Text);
                }
            }
            catch
            {

            }
        }

        private void Fov_Tick(object sender, EventArgs e)
        {
            FOV();
        }

        private void setFOV_CheckedChanged(object sender, EventArgs e)
        {
            if (setFOV.Checked)
            {
                Fov.Start();
            }
            else
            {
                Fov.Stop();
            }
        }


    }
}
