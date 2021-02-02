// <copyright file="MainForm.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace LCDPixelsOK
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Bounds = SystemInformation.VirtualScreen;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
