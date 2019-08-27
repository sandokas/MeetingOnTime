namespace org.meetingontime.ui.wf
{
    partial class Form1
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
            this.startStopButton = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.decreasetime = new System.Windows.Forms.Button();
            this.increasetime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(179, 37);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 20);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(119, 37);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(54, 20);
            this.timeBox.TabIndex = 2;
            // 
            // decreasetime
            // 
            this.decreasetime.Location = new System.Drawing.Point(71, 37);
            this.decreasetime.Name = "decreasetime";
            this.decreasetime.Size = new System.Drawing.Size(18, 20);
            this.decreasetime.TabIndex = 3;
            this.decreasetime.Text = "-";
            this.decreasetime.UseVisualStyleBackColor = true;
            this.decreasetime.Click += new System.EventHandler(this.decreasetime_Click);
            // 
            // increasetime
            // 
            this.increasetime.Location = new System.Drawing.Point(95, 37);
            this.increasetime.Name = "increasetime";
            this.increasetime.Size = new System.Drawing.Size(18, 20);
            this.increasetime.TabIndex = 4;
            this.increasetime.Text = "+";
            this.increasetime.UseVisualStyleBackColor = true;
            this.increasetime.Click += new System.EventHandler(this.increasetime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.increasetime);
            this.Controls.Add(this.decreasetime);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.startStopButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Button decreasetime;
        private System.Windows.Forms.Button increasetime;
    }
}

