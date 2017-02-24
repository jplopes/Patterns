namespace Flyweight
{
    partial class WindowDemo
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
            this.lblObjectCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblObjectCounter
            // 
            this.lblObjectCounter.AutoSize = true;
            this.lblObjectCounter.Location = new System.Drawing.Point(12, 9);
            this.lblObjectCounter.Name = "lblObjectCounter";
            this.lblObjectCounter.Size = new System.Drawing.Size(0, 13);
            this.lblObjectCounter.TabIndex = 0;
            // 
            // WindowDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblObjectCounter);
            this.Name = "WindowDemo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WindowDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjectCounter;
    }
}

