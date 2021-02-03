namespace LCDPixelsOK
{
    using System.Windows.Forms;

    public partial class ControlPanelForm : Form
    {
        private MainForm MainForm
        {
            get => this.Owner as MainForm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlPanelForm"/> class.
        /// </summary>
        public ControlPanelForm()
        {
            this.InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape: this.Hide(); return true;
                case Keys.Left: this.MainForm.GotoPreviousColor(); return true;
                case Keys.Right: this.MainForm.GotoNextColor(); return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
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

        private void nextColorButton_Click(object sender, System.EventArgs e)
        {
            this.MainForm.GotoNextColor();
        }
    }
}
