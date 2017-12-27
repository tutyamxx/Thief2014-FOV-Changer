using Microsoft.Win32;

using System;
using System.Diagnostics;
using System.Globalization;
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

        RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Eidos Montreal\Thief\Graphics", true);

        private void button1_Click(object sender, EventArgs e)
        {
            if (Registry.GetValue(myKey.ToString(), RegValueName, null) == null)
            {
                MessageBox.Show("It seems you don't have Thief (2014) installed!" + Environment.NewLine + "Registry not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }

            int FOVBarValueConverted = fov_Bar.Value * 1000;

            string ConvertFOVNumberToHex = FOVBarValueConverted.ToString("X");
            int FOVToIntAgain = int.Parse(ConvertFOVNumberToHex, System.Globalization.NumberStyles.HexNumber);

            myKey.SetValue(RegValueName, FOVToIntAgain, RegistryValueKind.DWord);
            MessageBox.Show("Added " + FOVBarValue + " (" + ConvertFOVNumberToHex + ")" + " to the base FOV!", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int FromHex(string value)
        {
            // strip the leading 0x
            if (value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(2);
            }
            return Int32.Parse(value, NumberStyles.HexNumber);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Registry.GetValue(myKey.ToString(), RegValueName, null) == null)
            {
                MessageBox.Show("It seems you don't have Thief (2014) installed!" + Environment.NewLine + "Registry not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }

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


