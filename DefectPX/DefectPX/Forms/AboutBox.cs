// <copyright file="AboutBox.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace DefectPX
{
    using System.Diagnostics;
    using System.Windows.Forms;

    /// <summary>
    /// The About dialog box class.
    /// </summary>
    public partial class AboutBox : Form
    {
        private const string DonateUrl = "http://www.appliberated.com/defectpx/donate/";
        private const string HelpUrl = "http://www.appliberated.com/defectpx/";

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBox"/> class.
        /// </summary>
        public AboutBox()
        {
            this.InitializeComponent();
            this.versionLabel.Text = string.Format("Version {0}", Application.ProductVersion);
        }

        /// <summary>
        /// Processes a dialog box key. Closes the About dialog box when Escape is pressed.
        /// </summary>
        /// <param name="keyData">The key to process.</param>
        /// <returns>True if the keystroke was processed; false otherwise.</returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Open the Donate url in the default browser when the user clicks the Donate button.
        /// </summary>
        private void DonateButton_Click(object sender, System.EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = DonateUrl, UseShellExecute = true });
        }

        /// <summary>
        /// Open the Help url in the default browser when the user clicks the Help button.
        /// </summary>
        private void HelpButton_Click(object sender, System.EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = HelpUrl, UseShellExecute = true });
        }
    }
}
