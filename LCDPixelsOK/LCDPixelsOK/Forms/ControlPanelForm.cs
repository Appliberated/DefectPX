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

        private void ControlPanelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

        private void ColorButtons_Click(object sender, System.EventArgs e)
        {
            (this.Owner as MainForm).ColorIndex = (sender as Button).TabIndex;
        }
    }
}
