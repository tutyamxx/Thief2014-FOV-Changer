using Microsoft.Win32;

using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Thief__2014__FOV_Changer
{
    public partial class Form1 : Form
    {
        public int FOVBarValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int FOVBarValueConverted = fov_Bar.Value * 1000;

            string ConvertFOVNumberToHex = FOVBarValueConverted.ToString("X");
            string RegValueName = "FOVCorrection";

            int FOVToIntAgain = int.Parse(ConvertFOVNumberToHex, System.Globalization.NumberStyles.HexNumber);

            RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Eidos Montreal\Thief\Graphics", true);

            if (Registry.GetValue(myKey.ToString(), RegValueName, null) == null)
            {
                MessageBox.Show("It seems you don't have Thief (2014) installed!" + Environment.NewLine + "Registry not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            myKey.SetValue(RegValueName, FOVToIntAgain, RegistryValueKind.DWord);
            MessageBox.Show("Added " + FOVBarValue + " (" + ConvertFOVNumberToHex + ")" + " to the base FOV!", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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


