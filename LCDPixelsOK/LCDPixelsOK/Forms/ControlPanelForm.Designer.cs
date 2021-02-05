
namespace LCDPixelsOK
{
    partial class ControlPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tipLabel = new System.Windows.Forms.Label();
            this.colorButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.blackButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.customColorButton = new System.Windows.Forms.Button();
            this.actionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.previousColorButton = new System.Windows.Forms.Button();
            this.selectCustomColorButton = new System.Windows.Forms.Button();
            this.nextColorButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.mainTableLayoutPanel.SuspendLayout();
            this.colorButtonsFlowLayoutPanel.SuspendLayout();
            this.actionsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.AutoSize = true;
            this.mainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.tipLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.colorButtonsFlowLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.actionsTableLayoutPanel, 0, 2);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(776, 296);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // tipLabel
            // 
            this.tipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipLabel.Location = new System.Drawing.Point(49, 20);
            this.tipLabel.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.tipLabel.MaximumSize = new System.Drawing.Size(716, 0);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(678, 40);
            this.tipLabel.TabIndex = 0;
            this.tipLabel.Text = "Press Escape to close this dialog box and cycle through colors to check for dead " +
    "or stuck pixels. Press Escape again, or right-click to show this dialog box agai" +
    "n.";
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
            this.blackButton.Click += new System.EventHandler(this.ColorButtons_Click);
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
            this.whiteButton.Click += new System.EventHandler(this.ColorButtons_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatAppearance.BorderSize = 0;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redButton.ForeColor = System.Drawing.Color.White;
            this.redButton.Location = new System.Drawing.Point(252, 20);
            this.redButton.Margin = new System.Windows.Forms.Padding(10);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(96, 96);
            this.redButton.TabIndex = 2;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.ColorButtons_Click);
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
            this.greenButton.Click += new System.EventHandler(this.ColorButtons_Click);
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
            this.blueButton.Click += new System.EventHandler(this.ColorButtons_Click);
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
            this.customColorButton.Click += new System.EventHandler(this.ColorButtons_Click);
            // 
            // actionsTableLayoutPanel
            // 
            this.actionsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsTableLayoutPanel.AutoSize = true;
            this.actionsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionsTableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.actionsTableLayoutPanel.ColumnCount = 5;
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.actionsTableLayoutPanel.Controls.Add(this.previousColorButton, 0, 0);
            this.actionsTableLayoutPanel.Controls.Add(this.selectCustomColorButton, 2, 0);
            this.actionsTableLayoutPanel.Controls.Add(this.nextColorButton, 1, 0);
            this.actionsTableLayoutPanel.Controls.Add(this.aboutButton, 3, 0);
            this.actionsTableLayoutPanel.Controls.Add(this.exitButton, 4, 0);
            this.actionsTableLayoutPanel.Location = new System.Drawing.Point(0, 236);
            this.actionsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.actionsTableLayoutPanel.Name = "actionsTableLayoutPanel";
            this.actionsTableLayoutPanel.RowCount = 1;
            this.actionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.actionsTableLayoutPanel.Size = new System.Drawing.Size(776, 60);
            this.actionsTableLayoutPanel.TabIndex = 3;
            // 
            // previousColorButton
            // 
            this.previousColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.previousColorButton.AutoSize = true;
            this.previousColorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousColorButton.FlatAppearance.BorderSize = 0;
            this.previousColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.previousColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousColorButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.previousColorButton.ForeColor = System.Drawing.Color.White;
            this.previousColorButton.Location = new System.Drawing.Point(0, 0);
            this.previousColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.previousColorButton.Name = "previousColorButton";
            this.previousColorButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.previousColorButton.Size = new System.Drawing.Size(186, 60);
            this.previousColorButton.TabIndex = 1;
            this.previousColorButton.Text = "🠈 Previous Color";
            this.previousColorButton.UseVisualStyleBackColor = true;
            this.previousColorButton.Click += new System.EventHandler(this.PreviousColorButton_Click);
            // 
            // selectCustomColorButton
            // 
            this.selectCustomColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectCustomColorButton.AutoSize = true;
            this.selectCustomColorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectCustomColorButton.FlatAppearance.BorderSize = 0;
            this.selectCustomColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.selectCustomColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectCustomColorButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectCustomColorButton.ForeColor = System.Drawing.Color.White;
            this.selectCustomColorButton.Location = new System.Drawing.Point(372, 0);
            this.selectCustomColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.selectCustomColorButton.Name = "selectCustomColorButton";
            this.selectCustomColorButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.selectCustomColorButton.Size = new System.Drawing.Size(186, 60);
            this.selectCustomColorButton.TabIndex = 3;
            this.selectCustomColorButton.Text = "Custom Color...";
            this.selectCustomColorButton.UseVisualStyleBackColor = true;
            this.selectCustomColorButton.Click += new System.EventHandler(this.SelectCustomColorButton_Click);
            // 
            // nextColorButton
            // 
            this.nextColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nextColorButton.AutoSize = true;
            this.nextColorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextColorButton.FlatAppearance.BorderSize = 0;
            this.nextColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nextColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextColorButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextColorButton.ForeColor = System.Drawing.Color.White;
            this.nextColorButton.Location = new System.Drawing.Point(186, 0);
            this.nextColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextColorButton.Name = "nextColorButton";
            this.nextColorButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.nextColorButton.Size = new System.Drawing.Size(186, 60);
            this.nextColorButton.TabIndex = 2;
            this.nextColorButton.Text = "🠊 Next Color";
            this.nextColorButton.UseVisualStyleBackColor = true;
            this.nextColorButton.Click += new System.EventHandler(this.NextColorButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.AutoSize = true;
            this.aboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Location = new System.Drawing.Point(558, 0);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(0);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.aboutButton.Size = new System.Drawing.Size(108, 60);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(666, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.exitButton.Size = new System.Drawing.Size(110, 60);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(887, 369);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanelForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCD PixelsOK";
            this.Load += new System.EventHandler(this.ControlPanelForm_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.colorButtonsFlowLayoutPanel.ResumeLayout(false);
            this.actionsTableLayoutPanel.ResumeLayout(false);
            this.actionsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.FlowLayoutPanel colorButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button customColorButton;
        private System.Windows.Forms.Button previousColorButton;
        private System.Windows.Forms.Button nextColorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel actionsTableLayoutPanel;
        private System.Windows.Forms.Button selectCustomColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button aboutButton;
    }
}