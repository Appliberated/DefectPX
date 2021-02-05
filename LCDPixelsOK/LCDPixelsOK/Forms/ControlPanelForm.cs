// <copyright file="ControlPanelForm.cs" company="Appliberated">
// Copyright © Appliberated. All rights reserved.
// </copyright>

namespace LCDPixelsOK
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The Control Panel form class.
    /// </summary>
    public partial class ControlPanelForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlPanelForm"/> class.
        /// </summary>
        public ControlPanelForm()
        {
            this.InitializeComponent();
        }

        private MainForm MainForm
        {
            get => this.Owner as MainForm;
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
                case Keys.Escape: this.Close(); return true;
                case Keys.Left: this.MainForm.GotoPreviousColor(); return true;
                case Keys.Right: this.MainForm.GotoNextColor(); return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Performs some initialization when the form is loaded.
        /// </summary>
        private void ControlPanelForm_Load(object sender, EventArgs e)
        {
            this.UpdateCustomColor(this.MainForm.CustomColor);

            // Make sure the autosized tip label is left-aligned with the color buttons panel below
            this.tipLabel.MinimumSize = new Size(this.colorButtonsFlowLayoutPanel.Width, 0);
        }

        // -----------------------------------------------------------------------------------------
        // Color Buttons
        // -----------------------------------------------------------------------------------------

        /// <summary>
        /// Changes the color index on the main form when one of the color buttons is pressed.
        /// </summary>
        private void ColorButtons_Click(object sender, EventArgs e)
        {
            this.MainForm.ColorIndex = (sender as Button).TabIndex;
        }

        // -----------------------------------------------------------------------------------------
        // Status Bar Buttons
        // -----------------------------------------------------------------------------------------

        /// <summary>
        /// Cycles to the previous color when the Previous Color button is pressed.
        /// </summary>
        private void PreviousColorButton_Click(object sender, EventArgs e)
        {
            this.MainForm.GotoPreviousColor();
        }

        /// <summary>
        /// Cycles to the next color when the Next Color button is pressed.
        /// </summary>
        private void NextColorButton_Click(object sender, EventArgs e)
        {
            this.MainForm.GotoNextColor();
        }

        /// <summary>
        /// Opens a Color dialog box to let the user select a custom color when the Custom Color button is pressed.
        /// </summary>
        private void SelectCustomColorButton_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = this.customColorButton.BackColor;
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.UpdateCustomColor(this.colorDialog.Color);
                this.MainForm.CustomColor = this.colorDialog.Color;
            }
        }

        /// <summary>
        /// Closes the form when the Exit button is pressed.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // -----------------------------------------------------------------------------------------
        // Private functionality
        // -----------------------------------------------------------------------------------------

        /// <summary>
        /// Updates the background and text color of the Custom Color button when the custom color changes.
        /// </summary>
        private void UpdateCustomColor(Color color)
        {
            this.customColorButton.BackColor = color;

            // Set the text color of the button to black or white based on the perceived brightness of the custom color
            double pb = Math.Sqrt((color.R * color.R * .241) + (color.G * color.G * .691) + (color.B * color.B * .068));
            this.customColorButton.ForeColor = (pb > 128) ? Color.Black : Color.White;
        }
    }
}
