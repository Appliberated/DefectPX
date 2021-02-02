
namespace LCDPixelsOK
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.blackButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.customColorButton = new System.Windows.Forms.Button();
            this.statusBarFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.colorButtonsFlowLayoutPanel.SuspendLayout();
            this.statusBarFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorButtonsFlowLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusBarFlowLayoutPanel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(202, 184);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.label1.MaximumSize = new System.Drawing.Size(716, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "To test for dead or stuck pixels, cycle throgh all the colors below and carefully" +
    " inspect the screen for pixels that do not match the selected color:";
            // 
            // colorButtonsFlowLayoutPanel
            // 
            this.colorButtonsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorButtonsFlowLayoutPanel.AutoSize = true;
            this.colorButtonsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorButtonsFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.colorButtonsFlowLayoutPanel.Controls.Add(this.blackButton);
            this.colorButtonsFlowLayoutPanel.Controls.Add(this.whiteButton);
            this.colorButtonsFlowLayoutPanel.Controls.Add(this.redButton);
            this.colorButtonsFlowLayoutPanel.Controls.Add(this.greenButton);
            this.colorButtonsFlowLayoutPanel.Controls.Add(this.blueButton);
            this.colorButtonsFlowLayoutPanel.Controls.Add(this.customColorButton);
            this.colorButtonsFlowLayoutPanel.Location = new System.Drawing.Point(30, 80);
            this.colorButtonsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(30, 0, 30, 20);
            this.colorButtonsFlowLayoutPanel.Name = "colorButtonsFlowLayoutPanel";
            this.colorButtonsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.colorButtonsFlowLayoutPanel.Size = new System.Drawing.Size(716, 136);
            this.colorButtonsFlowLayoutPanel.TabIndex = 1;
            this.colorButtonsFlowLayoutPanel.WrapContents = false;
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.FlatAppearance.BorderSize = 0;
            this.blackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.blackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blackButton.ForeColor = System.Drawing.Color.White;
            this.blackButton.Location = new System.Drawing.Point(20, 20);
            this.blackButton.Margin = new System.Windows.Forms.Padding(10);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(96, 96);
            this.blackButton.TabIndex = 0;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = false;
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.FlatAppearance.BorderSize = 0;
            this.whiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whiteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.whiteButton.ForeColor = System.Drawing.Color.Black;
            this.whiteButton.Location = new System.Drawing.Point(136, 20);
            this.whiteButton.Margin = new System.Windows.Forms.Padding(10);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(96, 96);
            this.whiteButton.TabIndex = 1;
            this.whiteButton.Text = "White";
            this.whiteButton.UseVisualStyleBackColor = false;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatAppearance.BorderSize = 0;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redButton.ForeColor = System.Drawing.Color.Black;
            this.redButton.Location = new System.Drawing.Point(252, 20);
            this.redButton.Margin = new System.Windows.Forms.Padding(10);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(96, 96);
            this.redButton.TabIndex = 2;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Lime;
            this.greenButton.FlatAppearance.BorderSize = 0;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greenButton.ForeColor = System.Drawing.Color.Black;
            this.greenButton.Location = new System.Drawing.Point(368, 20);
            this.greenButton.Margin = new System.Windows.Forms.Padding(10);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(96, 96);
            this.greenButton.TabIndex = 3;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = false;
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.FlatAppearance.BorderSize = 0;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blueButton.ForeColor = System.Drawing.Color.White;
            this.blueButton.Location = new System.Drawing.Point(484, 20);
            this.blueButton.Margin = new System.Windows.Forms.Padding(10);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(96, 96);
            this.blueButton.TabIndex = 4;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = false;
            // 
            // customColorButton
            // 
            this.customColorButton.BackColor = System.Drawing.Color.Orange;
            this.customColorButton.FlatAppearance.BorderSize = 0;
            this.customColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customColorButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customColorButton.ForeColor = System.Drawing.Color.Black;
            this.customColorButton.Location = new System.Drawing.Point(600, 20);
            this.customColorButton.Margin = new System.Windows.Forms.Padding(10);
            this.customColorButton.Name = "customColorButton";
            this.customColorButton.Size = new System.Drawing.Size(96, 96);
            this.customColorButton.TabIndex = 5;
            this.customColorButton.Text = "Custom";
            this.customColorButton.UseVisualStyleBackColor = false;
            // 
            // statusBarFlowLayoutPanel
            // 
            this.statusBarFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBarFlowLayoutPanel.AutoSize = true;
            this.statusBarFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusBarFlowLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.statusBarFlowLayoutPanel.Controls.Add(this.button1);
            this.statusBarFlowLayoutPanel.Controls.Add(this.button2);
            this.statusBarFlowLayoutPanel.Controls.Add(this.button3);
            this.statusBarFlowLayoutPanel.Controls.Add(this.button4);
            this.statusBarFlowLayoutPanel.Controls.Add(this.exitButton);
            this.statusBarFlowLayoutPanel.Location = new System.Drawing.Point(0, 236);
            this.statusBarFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarFlowLayoutPanel.Name = "statusBarFlowLayoutPanel";
            this.statusBarFlowLayoutPanel.Size = new System.Drawing.Size(776, 56);
            this.statusBarFlowLayoutPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "LCD PixelsOK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(141, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(158, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "🠈 Previous Color";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(305, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(132, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "🠊 Next Color";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(443, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(179, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "↩ Toggle This Panel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(628, 3);
            this.exitButton.MinimumSize = new System.Drawing.Size(132, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10);
            this.exitButton.Size = new System.Drawing.Size(132, 50);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1241, 602);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "LCD PixelsOK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.colorButtonsFlowLayoutPanel.ResumeLayout(false);
            this.statusBarFlowLayoutPanel.ResumeLayout(false);
            this.statusBarFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel colorButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button customColorButton;
        private System.Windows.Forms.FlowLayoutPanel statusBarFlowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button exitButton;
    }
}

