namespace Player
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
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.TextBox();
            this.yValue = new System.Windows.Forms.TextBox();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(38, 36);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "x:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(41, 95);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(15, 13);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "y:";
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(92, 36);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(100, 20);
            this.xValue.TabIndex = 2;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(92, 95);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(100, 20);
            this.yValue.TabIndex = 3;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Location = new System.Drawing.Point(245, 36);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(0, 13);
            this.prizeLabel.TabIndex = 4;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(248, 91);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(95, 23);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 165);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Button playButton;
    }
}

