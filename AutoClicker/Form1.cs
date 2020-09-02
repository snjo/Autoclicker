using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        uint startX = 0;
        bool lastCapsLockState;

        public int clickCount = 0;

        public Form1()
        {
            InitializeComponent();            
        }

        private void onTimer(object sender, EventArgs e)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            bool currentCapsLockState = Control.IsKeyLocked(Keys.CapsLock);
            
            if (StopWhenMouseMovesInput.Checked)
            {
                if (Math.Abs(startX - X) > 3) stopClicking();
            }
            
            if (StopWhenControlIsPressed.Checked)
            {
                if (currentCapsLockState != lastCapsLockState)
                {
                    stopClicking();
                }
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    stopClicking();
                }
            }
            
            
            
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void toggleTimerEvent(object sender, EventArgs e)
        {
            waitForStart.Interval = (int)(startDelayInput.Value * 1000);
            waitForStart.Start();
        }

        private void disableClickingEvent(object sender, EventArgs e)
        {
            stopClicking();            
        }

        private void stopClicking()
        {
            clickInterval.Stop();
            waitForStart.Stop();
            clickDuration.Stop();
        }

        private void startClicking()
        {
            startX = (uint)Cursor.Position.X;
            lastCapsLockState = Control.IsKeyLocked(Keys.CapsLock);
            clickDuration.Interval = ((int)durationInput.Value) * 1000;
            clickInterval.Interval = (int)(1000 / clicksPerSecondInput.Value);            
            clickInterval.Start();
            if (UseCountdownInput.Checked) clickDuration.Start();
            waitForStart.Stop();
        }

        private void startClickingEvent(object sender, EventArgs e)
        {
            startClicking();
        }

        private void countOneClick(object sender, EventArgs e)
        {
            clickCount++;
            clickCountLabel.Text = clickCount.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkSafety(object sender, EventArgs e)
        {
            if (!StopWhenMouseMovesInput.Checked && !UseCountdownInput.Checked && !StopWhenControlIsPressed.Checked)
            {
                ((CheckBox)sender).Checked = true;                
                System.Media.SystemSounds.Exclamation.Play();          
            }
        }

        private void toggleAlwaysOnTopEvent(object sender, EventArgs e)
        {
            Form1.ActiveForm.TopMost = alwaysOnTopCheck.Checked;
        }


    }
}