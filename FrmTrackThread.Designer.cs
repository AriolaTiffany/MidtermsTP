namespace MidtermsTP
{
    partial class FrmTrackThread
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
            lblStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Maroon;
            lblStatus.Location = new Point(85, 79);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(394, 50);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "- Thread Status-";
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Maroon;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRun.ForeColor = SystemColors.ButtonHighlight;
            btnRun.Location = new Point(174, 164);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(222, 43);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // FrmTrackThread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(569, 282);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmTrackThread";
            Text = "FrmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
    }
}
