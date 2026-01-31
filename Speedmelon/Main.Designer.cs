namespace Speedmelon
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            openFileDialog1 = new OpenFileDialog();
            textBoxGamePath = new TextBox();
            statusLabel = new Label();
            pathLabel = new Label();
            melonButton1 = new MelonButton();
            navButton = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxGamePath
            // 
            textBoxGamePath.ForeColor = SystemColors.InfoText;
            textBoxGamePath.Location = new Point(119, 54);
            textBoxGamePath.Name = "textBoxGamePath";
            textBoxGamePath.Size = new Size(280, 23);
            textBoxGamePath.TabIndex = 1;
            textBoxGamePath.TextChanged += textBoxGamePath_TextChanged;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Location = new Point(119, 80);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(280, 16);
            statusLabel.TabIndex = 3;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(119, 36);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(145, 15);
            pathLabel.TabIndex = 4;
            pathLabel.Text = "Select SpeedRunners 2.exe";
            // 
            // melonButton1
            // 
            melonButton1.BackColor = Color.Tomato;
            melonButton1.BorderRadius = 40;
            melonButton1.FlatAppearance.BorderSize = 0;
            melonButton1.FlatStyle = FlatStyle.Flat;
            melonButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            melonButton1.ForeColor = Color.White;
            melonButton1.Location = new Point(290, 141);
            melonButton1.Name = "melonButton1";
            melonButton1.Size = new Size(150, 50);
            melonButton1.TabIndex = 5;
            melonButton1.Text = "Install";
            melonButton1.UseVisualStyleBackColor = false;
            melonButton1.Click += buttonInstall_Click;
            // 
            // navButton
            // 
            navButton.Location = new Point(405, 55);
            navButton.Name = "navButton";
            navButton.Size = new Size(33, 22);
            navButton.TabIndex = 6;
            navButton.Text = "...";
            navButton.UseVisualStyleBackColor = true;
            navButton.Click += buttonBrowse_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(452, 205);
            Controls.Add(navButton);
            Controls.Add(melonButton1);
            Controls.Add(pathLabel);
            Controls.Add(statusLabel);
            Controls.Add(textBoxGamePath);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Speedmelon";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxGamePath;
        private Label statusLabel;
        private Label pathLabel;
        private MelonButton melonButton1;
        private Button navButton;
    }
}
