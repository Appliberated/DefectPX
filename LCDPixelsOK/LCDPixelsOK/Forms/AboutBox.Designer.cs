
namespace LCDPixelsOK
{
    partial class AboutBox
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
            this.infoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.freeLabel = new System.Windows.Forms.Label();
            this.donateButton = new System.Windows.Forms.Button();
            this.actionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.helpButton = new System.Windows.Forms.Button();
            this.infoFlowLayoutPanel.SuspendLayout();
            this.actionsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoFlowLayoutPanel
            // 
            this.infoFlowLayoutPanel.AutoSize = true;
            this.infoFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoFlowLayoutPanel.Controls.Add(this.appNameLabel);
            this.infoFlowLayoutPanel.Controls.Add(this.versionLabel);
            this.infoFlowLayoutPanel.Controls.Add(this.copyrightLabel);
            this.infoFlowLayoutPanel.Controls.Add(this.freeLabel);
            this.infoFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.infoFlowLayoutPanel.Name = "infoFlowLayoutPanel";
            this.infoFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 60);
            this.infoFlowLayoutPanel.Size = new System.Drawing.Size(366, 386);
            this.infoFlowLayoutPanel.TabIndex = 0;
            // 
            // appNameLabel
            // 
            this.appNameLabel.BackColor = System.Drawing.Color.Black;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.appNameLabel.ForeColor = System.Drawing.Color.White;
            this.appNameLabel.Location = new System.Drawing.Point(33, 30);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(96, 96);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "LCD PixelsOK";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.Location = new System.Drawing.Point(33, 146);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(66, 15);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version {0}";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.Location = new System.Drawing.Point(33, 161);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(149, 15);
            this.copyrightLabel.TabIndex = 3;
            this.copyrightLabel.Text = "Copyright © Appliberated";
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.freeLabel.Location = new System.Drawing.Point(33, 196);
            this.freeLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.freeLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(298, 80);
            this.freeLabel.TabIndex = 0;
            this.freeLabel.Text = "LCD PixelsOK is free and open-source. Donations are the only way to maintain the " +
    "application and support its future development.";
            // 
            // donateButton
            // 
            this.donateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donateButton.AutoSize = true;
            this.donateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.donateButton.FlatAppearance.BorderSize = 0;
            this.donateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.donateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donateButton.ForeColor = System.Drawing.Color.White;
            this.donateButton.Location = new System.Drawing.Point(0, 0);
            this.donateButton.Margin = new System.Windows.Forms.Padding(0);
            this.donateButton.Name = "donateButton";
            this.donateButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.donateButton.Size = new System.Drawing.Size(183, 60);
            this.donateButton.TabIndex = 2;
            this.donateButton.Text = "Make a donation";
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // actionsTableLayoutPanel
            // 
            this.actionsTableLayoutPanel.AutoSize = true;
            this.actionsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionsTableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.actionsTableLayoutPanel.ColumnCount = 2;
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionsTableLayoutPanel.Controls.Add(this.helpButton, 1, 0);
            this.actionsTableLayoutPanel.Controls.Add(this.donateButton, 0, 0);
            this.actionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsTableLayoutPanel.Location = new System.Drawing.Point(0, 386);
            this.actionsTableLayoutPanel.Name = "actionsTableLayoutPanel";
            this.actionsTableLayoutPanel.RowCount = 1;
            this.actionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionsTableLayoutPanel.Size = new System.Drawing.Size(366, 60);
            this.actionsTableLayoutPanel.TabIndex = 3;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.AutoSize = true;
            this.helpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(183, 0);
            this.helpButton.Margin = new System.Windows.Forms.Padding(0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.helpButton.Size = new System.Drawing.Size(183, 60);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(366, 446);
            this.Controls.Add(this.infoFlowLayoutPanel);
            this.Controls.Add(this.actionsTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About LCD PixelsOK";
            this.infoFlowLayoutPanel.ResumeLayout(false);
            this.infoFlowLayoutPanel.PerformLayout();
            this.actionsTableLayoutPanel.ResumeLayout(false);
            this.actionsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel infoFlowLayoutPanel;
        private System.Windows.Forms.Label freeLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.TableLayoutPanel actionsTableLayoutPanel;
        private System.Windows.Forms.Button helpButton;
        internal System.Windows.Forms.Label appNameLabel;
    }
}