// <copyright file="MainForm.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace LCDPixelsOK
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {

        private static readonly Color[] Colors = { Color.Black, Color.White, Color.Red, Color.Lime, Color.Blue, Color.Orange };

        private int colorIndex;

        internal int ColorIndex
        {
            get => this.colorIndex;

            set
            {
                this.colorIndex = value;
                this.BackColor = Colors[this.colorIndex];
            }
        }

        private ControlPanelForm controlPanelForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.controlPanelForm = new ControlPanelForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Bounds = SystemInformation.VirtualScreen;
            //this.controlPanelForm.Show(this);
            //this.controlPanelForm.Activate();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.controlPanelForm.Show(this);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.controlPanelForm.Visible = !this.controlPanelForm.Visible;
            }
        }
    }
}
