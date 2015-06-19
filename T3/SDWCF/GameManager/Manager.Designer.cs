namespace GameManager
{
    partial class Manager
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
            this.xValue = new System.Windows.Forms.TextBox();
            this.yValue = new System.Windows.Forms.TextBox();
            this.startgameButton = new System.Windows.Forms.Button();
            this.endgameButton = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(97, 45);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(100, 20);
            this.xValue.TabIndex = 0;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(97, 98);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(100, 20);
            this.yValue.TabIndex = 1;
            // 
            // startgameButton
            // 
            this.startgameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startgameButton.Location = new System.Drawing.Point(271, 40);
            this.startgameButton.Name = "startgameButton";
            this.startgameButton.Size = new System.Drawing.Size(130, 31);
            this.startgameButton.TabIndex = 2;
            this.startgameButton.Text = "Start Game!";
            this.startgameButton.UseVisualStyleBackColor = true;
            // 
            // endgameButton
            // 
            this.endgameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endgameButton.Location = new System.Drawing.Point(271, 96);
            this.endgameButton.Name = "endgameButton";
            this.endgameButton.Size = new System.Drawing.Size(130, 30);
            this.endgameButton.TabIndex = 3;
            this.endgameButton.Text = "End Game!";
            this.endgameButton.UseVisualStyleBackColor = true;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(60, 45);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 20);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "x:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yLabel.Location = new System.Drawing.Point(60, 101);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(20, 20);
            this.yLabel.TabIndex = 5;
            this.yLabel.Text = "y:";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 174);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.endgameButton);
            this.Controls.Add(this.startgameButton);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Name = "Manager";
            this.Text = "Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.Button startgameButton;
        private System.Windows.Forms.Button endgameButton;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
    }
}

