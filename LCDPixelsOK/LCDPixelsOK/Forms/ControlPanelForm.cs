namespace LCDPixelsOK
{
    using System.Windows.Forms;

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

        /// <summary>
        /// Closes the Settings form when the user presses the Escape key.
        /// </summary>
        /// <param name="keyData">One of the Keys values that represents the key to process.</param>
        /// <returns>True if the key was processed by the control; otherwise, false.</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // case Keys.Escape: this.Hide(); return true;
                case Keys.Escape: this.Close(); return true;
                case Keys.Left: this.MainForm.GotoPreviousColor(); return true;
                case Keys.Right: this.MainForm.GotoNextColor(); return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ColorButtons_Click(object sender, System.EventArgs e)
        {
            this.MainForm.ColorIndex = (sender as Button).TabIndex;
        }

        private void SelectCustomColorButton_Click(object sender, System.EventArgs e)
        {
            this.colorDialog.Color = this.customColorButton.BackColor;
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.customColorButton.BackColor = this.colorDialog.Color;
                this.MainForm.CustomColor = this.colorDialog.Color;
            }
        }

        private void ControlPanelForm_Load(object sender, System.EventArgs e)
        {
            this.customColorButton.BackColor = this.MainForm.CustomColor;
        }

        private void PreviousColorButton_Click(object sender, System.EventArgs e)
        {
            this.MainForm.GotoPreviousColor();
        }

        private void NextColorButton_Click(object sender, System.EventArgs e)
        {
            this.MainForm.GotoNextColor();
        }
    }
}
