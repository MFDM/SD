namespace Remoting
{
    partial class SearchMusic
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.Format = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MusicFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.Location = new System.Drawing.Point(31, 35);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(51, 17);
            this.Album.TabIndex = 1;
            this.Album.Text = "Album:";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(488, 79);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(42, 17);
            this.Year.TabIndex = 2;
            this.Year.Text = "Year:";
            this.Year.Click += new System.EventHandler(this.Year_Click);
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.Location = new System.Drawing.Point(368, 35);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(44, 17);
            this.Artist.TabIndex = 3;
            this.Artist.Text = "Artist:";
            // 
            // Format
            // 
            this.Format.AutoSize = true;
            this.Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Format.Location = new System.Drawing.Point(26, 82);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(56, 17);
            this.Format.TabIndex = 4;
            this.Format.Text = "Format:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(244, 82);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(39, 17);
            this.Title.TabIndex = 5;
            this.Title.Text = "Title:";
            this.Title.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(536, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(418, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(289, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 20);
            this.textBox5.TabIndex = 9;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(247, 128);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(148, 34);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search!";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(620, 152);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // MusicFound
            // 
            this.MusicFound.AutoSize = true;
            this.MusicFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicFound.Location = new System.Drawing.Point(31, 183);
            this.MusicFound.Name = "MusicFound";
            this.MusicFound.Size = new System.Drawing.Size(92, 17);
            this.MusicFound.TabIndex = 13;
            this.MusicFound.Text = "Music Found:";
            // 
            // SearchMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 394);
            this.Controls.Add(this.MusicFound);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.textBox1);
            this.Name = "SearchMusic";
            this.Text = "SearchMusic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label Format;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label MusicFound;
    }
}