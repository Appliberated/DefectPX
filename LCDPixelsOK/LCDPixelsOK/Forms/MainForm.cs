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

        private readonly AppSettings appSettings;

        private Point controlPanelLocation;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();

            this.appSettings = AppSettings.Load();
            Debug.WriteLine(this.appSettings.CustomColor);
        }

        // -----------------------------------------------------------------------------------------
        // Color cycling functionality
        // -----------------------------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the index of the current color.
        /// </summary>
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
                    _ => Color.Black,
                };
            }
        }

        /// <summary>
        /// Gets or sets the custom color.
        /// </summary>
        internal Color CustomColor
        {
            get => Color.FromArgb(this.appSettings.CustomColor);

            set
            {
                this.appSettings.CustomColor = value.ToArgb();
                this.ColorIndex = 5;
            }
        }

        /// <summary>
        /// Goes to the previous color.
        /// </summary>
        internal void GotoPreviousColor()
        {
            this.ColorIndex = this.ColorIndex > 0 ? this.ColorIndex - 1 : MaxColorIndex;
        }

        /// <summary>
        /// Goes to the next color.
        /// </summary>
        internal void GotoNextColor()
        {
            this.ColorIndex = this.ColorIndex < MaxColorIndex ? this.ColorIndex + 1 : 0;
        }

        // -----------------------------------------------------------------------------------------
        // Form events and functionality
        // -----------------------------------------------------------------------------------------

        /// <summary>
        /// Processes a command key. Closes the form on Escape press, and cycles through colors on arrow keys press.
        /// </summary>
        /// <param name="msg">The Win32 message to process.</param>
        /// <param name="keyData">The key to process.</param>
        /// <returns>True if the keystroke was processed; false otherwise.</returns>
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

        /// <summary>
        /// Performs some initialization when the form is loaded.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Fill all available screens
            this.Bounds = SystemInformation.VirtualScreen;

            // Restore the color index from the saved app settings
            this.ColorIndex = this.appSettings.ColorIndex;
        }

        /// <summary>
        /// Show the Control Panel form when the main form is first shown.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.ShowControlPanel();
        }

        /// <summary>
        /// Cycle through colors on left-click. Show the Control Panel form on right-click.
        /// </summary>
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left: this.GotoNextColor(); break;
                case MouseButtons.Right: this.ShowControlPanel(); break;
            }
        }

        /// <summary>
        /// Save the app settings when the main form is closing.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.appSettings.Save();
        }

        // -----------------------------------------------------------------------------------------
        // Private functionality
        // -----------------------------------------------------------------------------------------

        /// <summary>
        /// Shows the Control Panel form as a modal dialog box.
        /// </summary>
        private void ShowControlPanel()
        {
            using ControlPanelForm controlPanelForm = new ControlPanelForm();
            if (!this.controlPanelLocation.IsEmpty)
            {
                controlPanelForm.StartPosition = FormStartPosition.Manual;
                controlPanelForm.Location = this.controlPanelLocation;
            }

            controlPanelForm.ShowDialog(this);
            this.controlPanelLocation = controlPanelForm.Location;
        }
    }
}
