using AutoClicker.Properties;
using Hotkeys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class Options : Form
    {
        MainForm mainForm;

        public Options(MainForm parent)
        {
            InitializeComponent();
            mainForm = parent;
            FillSettings();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ApplySettings();
            Close();
        }

        private void ApplySettings()
        {
            Settings.Default.RegisterHotkeys = checkBoxRegisterHotkeys.Checked;

            int i = 0;
            foreach (KeyValuePair<string, Hotkey> kvp in mainForm.HotkeyList)
            {
                string keyName = kvp.Key;
                if (HotkeyGrid.Rows[i].Cells[1].Value == null)
                {
                    HotkeyGrid.Rows[i].Cells[1].Value = "";
                }
                Properties.Settings.Default["hk" + keyName + "Key"] = HotkeyGrid.Rows[i].Cells[1].Value.ToString();

                Properties.Settings.Default["hk" + keyName + "Ctrl"] = Convert.ToBoolean(HotkeyGrid.Rows[i].Cells[2].Value);
                Properties.Settings.Default["hk" + keyName + "Alt"] = Convert.ToBoolean(HotkeyGrid.Rows[i].Cells[3].Value);
                Properties.Settings.Default["hk" + keyName + "Shift"] = Convert.ToBoolean(HotkeyGrid.Rows[i].Cells[4].Value);
                Properties.Settings.Default["hk" + keyName + "Win"] = Convert.ToBoolean(HotkeyGrid.Rows[i].Cells[5].Value);

                mainForm.HotkeyList[keyName] = GetHotkeyFromGrid(mainForm.HotkeyList[keyName], HotkeyGrid.Rows[i].Cells);

                i++;
            }

            Settings.Default.Save();

            reloadHotkeys();
        }



        private void FillSettings()
        {
            //textBoxFilename.Text = Settings.Default.Filename;
            checkBoxRegisterHotkeys.Checked = Settings.Default.RegisterHotkeys;
            fillHotkeyGrid();
        }

        private Hotkey GetHotkeyFromGrid(Hotkey hotkey, DataGridViewCellCollection settingRow)
        {
            string settingKey = string.Empty;
            DataGridViewCell cell = settingRow[1];
            if (cell != null)
            {
                if (cell.Value != null)
                    settingKey = (string)cell.Value;
                if (settingKey == null) settingKey = string.Empty;
            }

            if (settingKey.Length > 0)
                hotkey.Key = settingKey;
            else
                hotkey.Key = new string("");

            hotkey.Ctrl = Convert.ToBoolean(settingRow[2].Value);
            hotkey.Alt = Convert.ToBoolean(settingRow[3].Value);
            hotkey.Shift = Convert.ToBoolean(settingRow[4].Value);
            hotkey.Win = Convert.ToBoolean(settingRow[5].Value);

            return hotkey;
        }

        private void fillHotkeyGrid()
        {
            HotkeyGrid.Rows.Clear();
            HotkeyGrid.Rows.Add(mainForm.HotkeyList.Count);

            int i = 0;
            foreach (KeyValuePair<string, Hotkey> kvp in mainForm.HotkeyList)
            {
                string keyName = kvp.Key;
                Hotkey hotkey = kvp.Value;
                HotkeyGrid.Rows[i].Cells[0].Value = keyName;
                HotkeyGrid.Rows[i].Cells[1].Value = hotkey.Key;
                HotkeyGrid.Rows[i].Cells[2].Value = hotkey.Ctrl;
                HotkeyGrid.Rows[i].Cells[3].Value = hotkey.Alt;
                HotkeyGrid.Rows[i].Cells[4].Value = hotkey.Shift;
                HotkeyGrid.Rows[i].Cells[5].Value = hotkey.Win;
                i++;
            }
        }

        private void reloadHotkeys()
        {
            if (checkBoxRegisterHotkeys.Checked)
            {
                HotkeyTools.UpdateHotkeys(mainForm.HotkeyList, mainForm.HotkeyNames, mainForm);
            }
            else
            {
                HotkeyTools.ReleaseHotkeys(mainForm.HotkeyList);
            }
            Debug.WriteLine("Released and re-registered hotkeys");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            mainForm.LoadHotkeysFromSetting();
            mainForm.ApplySettings();
            FillSettings();
        }
    }
}
