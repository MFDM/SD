namespace Remoting
{
    partial class PeerRegistration
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
            this.PortValue = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.XMLFile = new System.Windows.Forms.Label();
            this.xml = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortValue
            // 
            this.PortValue.Location = new System.Drawing.Point(93, 42);
            this.PortValue.Name = "PortValue";
            this.PortValue.Size = new System.Drawing.Size(66, 20);
            this.PortValue.TabIndex = 0;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(49, 43);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(38, 17);
            this.Port.TabIndex = 1;
            this.Port.Text = "Port:";
            // 
            // XMLFile
            // 
            this.XMLFile.AutoSize = true;
            this.XMLFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XMLFile.Location = new System.Drawing.Point(201, 44);
            this.XMLFile.Name = "XMLFile";
            this.XMLFile.Size = new System.Drawing.Size(62, 17);
            this.XMLFile.TabIndex = 2;
            this.XMLFile.Text = "XMLFile:";
            // 
            // xml
            // 
            this.xml.Location = new System.Drawing.Point(269, 43);
            this.xml.Name = "xml";
            this.xml.Size = new System.Drawing.Size(226, 20);
            this.xml.TabIndex = 3;
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(501, 42);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(60, 21);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(204, 91);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(171, 32);
            this.register.TabIndex = 5;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // PeerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 135);
            this.Controls.Add(this.register);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.xml);
            this.Controls.Add(this.XMLFile);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.PortValue);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PeerRegistration";
            this.Text = "Peer Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortValue;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label XMLFile;
        private System.Windows.Forms.TextBox xml;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button register;
    }
}

