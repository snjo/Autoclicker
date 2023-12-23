using AutoClicker.Properties;
using Hotkeys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace AutoClicker
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class MainForm : Form
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

        public MainForm()
        {
            InitializeComponent();

            ApplySettings();

            LoadHotkeysFromSetting();
        }

        public void LoadHotkeysFromSetting()
        {
            HotkeyList = HotkeyTools.LoadHotkeys(HotkeyList, HotkeyNames, this);
            if (settings.RegisterHotkeys) // optional
            {
                HotkeyTools.UpdateHotkeys(HotkeyList, HotkeyNames, this);
                //if (HotkeyList.Count <= 0)
                //{
                //    HotkeyTools.RegisterHotkeys(HotkeyList);
                //}
                //else
                //{
                    
                //}
                
                // RegisterHotkeys returns a string[] with any failed hotkey registrations that can be used to output an error message
            }
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
            updateCheckboxSettings();
            SaveSetting();
        }

        private void updateCheckboxSettings()
        {
            settings.StopWhenCtrlPressed = StopWhenControlIsPressed.Checked;
            settings.StopWhenMouseMoves = StopWhenMouseMovesInput.Checked;
            settings.StopWhenCapsPressed = StopWhenControlIsPressed.Checked;
            settings.UseCountdown = UseCountdownInput.Checked;
        }

        private void toggleAlwaysOnTopEvent(object sender, EventArgs e)
        {
            if (MainForm.ActiveForm != null)
                MainForm.ActiveForm.TopMost = alwaysOnTopCheck.Checked;
            settings.AlwaysOnTop = alwaysOnTopCheck.Checked;
            SaveSetting();
        }

        #region Hotkeys -----------------------------------------------------------------------------

        Settings settings = Settings.Default;


        // For each hotkey below, add entries in Settings, hk???Key, hk???Ctrl, hk???Alt, hk???Shift, hk???Win
        public List<string> HotkeyNames = new List<string>
        {
            "StartClicking",
            "StopClicking",
            "ToggleClicking"
        };

        public Dictionary<string, Hotkey> HotkeyList = new Dictionary<string, Hotkey>();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            HotkeyTools.ReleaseHotkeys(HotkeyList);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.
                //MessageBox.Show("Hotkey " + id + " has been pressed!");
                HandleHotkey(id);
            }
        }

        private void HandleHotkey(int id)
        {
            if (HotkeyList["StartClicking"] != null) // else so using the same hotkey for stop and start works
            {
                if (id == HotkeyList["StartClicking"].ghk.id)
                {
                    Debug.WriteLine("Start clicking hotkey pressed");
                    startClicking();
                }
            }
            if (HotkeyList["StopClicking"] != null)
            {
                if (id == HotkeyList["StopClicking"].ghk.id)
                {
                    Debug.WriteLine("Stop clicking hotkey pressed");
                    stopClicking();
                }
            }

            if (HotkeyList["ToggleClicking"] != null)
            {
                if (id == HotkeyList["ToggleClicking"].ghk.id)
                {
                    Debug.WriteLine("Toggle clicking hotkey pressed");
                    if (clickInterval.Enabled)
                    {
                        stopClicking();
                    }
                    else
                    {
                        startClicking();
                    }
                }
            }
        }

        #endregion

        Options? options;
        private void OpenOptions()
        {
            if (options == null || options.IsDisposed)
                options = new Options(this);
            options.Show();
            options.WindowState = FormWindowState.Normal;
            //SetForegroundWindow(options.Handle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }

        private void durationInput_ValueChanged(object sender, EventArgs e)
        {
            settings.Duration = (int)durationInput.Value;
            SaveSetting();
        }

        private void clicksPerSecondInput_ValueChanged(object sender, EventArgs e)
        {
            settings.ClicksPerSecond = (int)clicksPerSecondInput.Value;
            SaveSetting();
        }

        private void startDelayInput_ValueChanged(object sender, EventArgs e)
        {
            settings.StartDelay = (int)startDelayInput.Value;
            SaveSetting();
        }

        public void ApplySettings()
        {
            StopWhenControlIsPressed.Checked = settings.StopWhenCtrlPressed;
            StopWhenMouseMovesInput.Checked = settings.StopWhenMouseMoves;
            UseCountdownInput.Checked = settings.UseCountdown;
            durationInput.Value = settings.Duration;
            clicksPerSecondInput.Value = settings.ClicksPerSecond;
            startDelayInput.Value = settings.StartDelay;
            alwaysOnTopCheck.Checked = settings.AlwaysOnTop;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            Debug.WriteLine("Saving settings");
            settings.Save();
        }
    }
}