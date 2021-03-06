﻿using Microsoft.Win32;

using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Thief__2014__FOV_Changer
{
    public partial class Form1 : Form
    {
        public int FOVBarValue = 0;
        string RegValueName = "FOVCorrection";

        public Form1()
        {
            InitializeComponent();
        }

        private static bool IsGameInstalled(string softwareName)
        {
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall") ?? Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");

            if (key == null)
            {
                return false;
            }

            return key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)).Select(subkey => subkey.GetValue("DisplayName") as string).Any(displayName => displayName != null && displayName.Contains(softwareName));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Eidos Montreal\Thief\Graphics", true);

            int FOVBarValueConverted = fov_Bar.Value * 1000;

            string ConvertFOVNumberToHex = FOVBarValueConverted.ToString("X");
            int FOVToIntAgain = int.Parse(ConvertFOVNumberToHex, System.Globalization.NumberStyles.HexNumber);

            myKey.SetValue(RegValueName, FOVToIntAgain, RegistryValueKind.DWord);
            MessageBox.Show("Added " + FOVBarValue + " (" + ConvertFOVNumberToHex + ")" + " to the base FOV!", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!IsGameInstalled("Thief"))
            {
                MessageBox.Show("Thief (2014) Steam version is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Eidos Montreal\Thief\Graphics", true);
            var ReadFOV = myKey.GetValue(RegValueName);

            fov_Bar.Value = (Convert.ToInt32(ReadFOV) / 1000);
            FOVBarValue = fov_Bar.Value;

            lbl_FOV.Text = "Field of View (FOV)" + Environment.NewLine + "            " + FOVBarValue + "°";
            lbl_NewFov.Text = "New FOV will be: " + (90 + FOVBarValue);

            fov_Bar.TickStyle = TickStyle.BottomRight;
            fov_Bar.TickFrequency = 10;
        }

        private void fov_Bar_Scroll(object sender, EventArgs e)
        {
            FOVBarValue = fov_Bar.Value;

            lbl_FOV.Text = "Field of View (FOV)" + Environment.NewLine + "            " + FOVBarValue + "°";
            lbl_NewFov.Text = "New FOV will be: " + (90 + FOVBarValue);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/tutyamxx");
        }
    }
}


