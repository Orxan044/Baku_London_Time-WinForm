namespace Baku___London_Time_WinForm
{
    partial class Form1
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
            lblTime = new Label();
            btnBaku = new Button();
            btnLondon = new Button();
            lblPicture = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.BackColor = SystemColors.ActiveBorder;
            lblTime.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(0, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(491, 60);
            lblTime.TabIndex = 0;
            lblTime.Text = "label1";
            // 
            // btnBaku
            // 
            btnBaku.BackColor = Color.Lime;
            btnBaku.Location = new Point(27, 379);
            btnBaku.Name = "btnBaku";
            btnBaku.Size = new Size(180, 65);
            btnBaku.TabIndex = 3;
            btnBaku.Text = "BAKU";
            btnBaku.UseVisualStyleBackColor = false;
            btnBaku.Click += btnBaku_Click;
            // 
            // btnLondon
            // 
            btnLondon.BackColor = Color.IndianRed;
            btnLondon.Location = new Point(287, 379);
            btnLondon.Name = "btnLondon";
            btnLondon.Size = new Size(180, 65);
            btnLondon.TabIndex = 4;
            btnLondon.Text = "LONDON";
            btnLondon.UseVisualStyleBackColor = false;
            btnLondon.Click += btnLondon_Click;
            // 
            // lblPicture
            // 
            lblPicture.BackColor = SystemColors.ControlLightLight;
            lblPicture.Image = Properties.Resources.London;
            lblPicture.Location = new Point(0, 60);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(491, 316);
            lblPicture.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(491, 450);
            Controls.Add(lblPicture);
            Controls.Add(btnLondon);
            Controls.Add(btnBaku);
            Controls.Add(lblTime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTime;
        private Button btnBaku;
        private Button btnLondon;
        private Label lblPicture;
    }
}
