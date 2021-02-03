// <copyright file="MainForm.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace LCDPixelsOK
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private const int MaxColorIndex = 5;

        private AppSettings appSettings;

        private Point controlPanelLocation;

        //private ControlPanelForm controlPanelForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            // this.controlPanelForm = new ControlPanelForm();

            this.appSettings = AppSettings.Load();
            Debug.WriteLine(this.appSettings.CustomColor);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Bounds = SystemInformation.VirtualScreen;

            this.ColorIndex = this.appSettings.ColorIndex;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.ShowControlPanel();

            // this.controlPanelForm.Show(this);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // case Keys.Escape: this.controlPanelForm.Visible = !this.controlPanelForm.Visible; return true;
                case Keys.Escape: this.ShowControlPanel(); return true;
                case Keys.Left: this.GotoPreviousColor(); return true;
                case Keys.Right: this.GotoNextColor(); return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.appSettings.Save();
        }

        private void ShowControlPanel()
        {
            using (ControlPanelForm controlPanelForm = new ControlPanelForm())
            {
                if (!this.controlPanelLocation.IsEmpty)
                {
                    controlPanelForm.StartPosition = FormStartPosition.Manual;
                    controlPanelForm.Location = this.controlPanelLocation;
                }

                controlPanelForm.ShowDialog(this);
                this.controlPanelLocation = controlPanelForm.Location;
            }
        }

        internal void GotoPreviousColor()
        {
            this.ColorIndex = this.ColorIndex > 0 ? this.ColorIndex - 1 : MaxColorIndex;
        }

        internal void GotoNextColor()
        {
            this.ColorIndex = this.ColorIndex < MaxColorIndex ? this.ColorIndex + 1 : 0;
        }

        internal int ColorIndex
        {
            get => this.appSettings.ColorIndex;

            set
            {
                this.appSettings.ColorIndex = value;
                this.BackColor = value switch
                {
                    0 => Color.Black,
                    1 => Color.White,
                    2 => Color.Red,
                    3 => Color.Lime,
                    4 => Color.Blue,
                    5 => this.CustomColor,
                };
            }
        }

        internal Color CustomColor
        {
            get => Color.FromArgb(this.appSettings.CustomColor);

            set
            {
                this.appSettings.CustomColor = value.ToArgb();
                this.ColorIndex = 5;
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left: this.GotoNextColor(); break;
                // case MouseButtons.Middle: this.ShowControlPanel(); break;
                // case MouseButtons.Right: this.GotoNextColor(); break;
                case MouseButtons.Right: this.ShowControlPanel(); break;
            }
        }
    }
}
