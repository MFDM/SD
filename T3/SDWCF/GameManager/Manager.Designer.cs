﻿namespace GameManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(138, 34);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(55, 20);
            this.xValue.TabIndex = 0;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(138, 75);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(55, 20);
            this.yValue.TabIndex = 1;
            // 
            // startgameButton
            // 
            this.startgameButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.startgameButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startgameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startgameButton.Location = new System.Drawing.Point(169, 122);
            this.startgameButton.Name = "startgameButton";
            this.startgameButton.Size = new System.Drawing.Size(94, 69);
            this.startgameButton.TabIndex = 2;
            this.startgameButton.Text = "Start Game";
            this.startgameButton.UseVisualStyleBackColor = false;
            this.startgameButton.Click += new System.EventHandler(this.startgameButton_Click);
            // 
            // endgameButton
            // 
            this.endgameButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.endgameButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endgameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endgameButton.Location = new System.Drawing.Point(30, 122);
            this.endgameButton.Name = "endgameButton";
            this.endgameButton.Size = new System.Drawing.Size(88, 69);
            this.endgameButton.TabIndex = 3;
            this.endgameButton.Text = "End Game";
            this.endgameButton.UseVisualStyleBackColor = false;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(116, 32);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 20);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "x";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yLabel.Location = new System.Drawing.Point(116, 73);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(16, 20);
            this.yLabel.TabIndex = 5;
            this.yLabel.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Border";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(275, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.endgameButton);
            this.Controls.Add(this.startgameButton);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
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
        private System.Windows.Forms.Label label1;
    }
}

