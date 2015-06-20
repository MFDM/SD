namespace Player
{
    partial class Player
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
            this.lastPlaysTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.liveslb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WOL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(110, 72);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "x:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(110, 111);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(15, 13);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "y:";
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(131, 69);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(76, 20);
            this.xValue.TabIndex = 2;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(131, 108);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(76, 20);
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
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.playButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playButton.Location = new System.Drawing.Point(239, 52);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(106, 97);
            this.playButton.TabIndex = 5;
            this.playButton.TabStop = false;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // lastPlaysTB
            // 
            this.lastPlaysTB.Location = new System.Drawing.Point(12, 53);
            this.lastPlaysTB.Name = "lastPlaysTB";
            this.lastPlaysTB.Size = new System.Drawing.Size(77, 136);
            this.lastPlaysTB.TabIndex = 6;
            this.lastPlaysTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Last moves:";
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(239, 169);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(106, 20);
            this.resultTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Results:";
            // 
            // liveslb
            // 
            this.liveslb.AutoSize = true;
            this.liveslb.Location = new System.Drawing.Point(156, 25);
            this.liveslb.Name = "liveslb";
            this.liveslb.Size = new System.Drawing.Size(16, 13);
            this.liveslb.TabIndex = 10;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // WOL
            // 
            this.WOL.AutoSize = true;
            this.WOL.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOL.Location = new System.Drawing.Point(213, 84);
            this.WOL.Name = "WOL";
            this.WOL.Size = new System.Drawing.Size(0, 28);
            this.WOL.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lives:";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(357, 205);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WOL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liveslb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastPlaysTB);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Player";
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
        private System.Windows.Forms.RichTextBox lastPlaysTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label liveslb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WOL;
        private System.Windows.Forms.Label label4;
    }
}

