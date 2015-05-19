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
            this.Album = new System.Windows.Forms.TextBox();
            this.Fromat = new System.Windows.Forms.TextBox();
            this.Artist = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.LAlbum = new System.Windows.Forms.Label();
            this.LArtist = new System.Windows.Forms.Label();
            this.LFormat = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();
            this.LYear = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Refs = new System.Windows.Forms.RichTextBox();
            this.LRefs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(100, 34);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(234, 20);
            this.Album.TabIndex = 0;
            // 
            // Fromat
            // 
            this.Fromat.Location = new System.Drawing.Point(100, 94);
            this.Fromat.Name = "Fromat";
            this.Fromat.Size = new System.Drawing.Size(129, 20);
            this.Fromat.TabIndex = 1;
            // 
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(461, 37);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(234, 20);
            this.Artist.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(315, 94);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(163, 20);
            this.Title.TabIndex = 3;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(566, 92);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(129, 20);
            this.Year.TabIndex = 4;
            // 
            // LAlbum
            // 
            this.LAlbum.AutoSize = true;
            this.LAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlbum.Location = new System.Drawing.Point(43, 34);
            this.LAlbum.Name = "LAlbum";
            this.LAlbum.Size = new System.Drawing.Size(51, 17);
            this.LAlbum.TabIndex = 5;
            this.LAlbum.Text = "Album:";
            this.LAlbum.Click += new System.EventHandler(this.Album_Click);
            // 
            // LArtist
            // 
            this.LArtist.AutoSize = true;
            this.LArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LArtist.Location = new System.Drawing.Point(411, 37);
            this.LArtist.Name = "LArtist";
            this.LArtist.Size = new System.Drawing.Size(44, 17);
            this.LArtist.TabIndex = 6;
            this.LArtist.Text = "Artist:";
            // 
            // LFormat
            // 
            this.LFormat.AutoSize = true;
            this.LFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFormat.Location = new System.Drawing.Point(38, 95);
            this.LFormat.Name = "LFormat";
            this.LFormat.Size = new System.Drawing.Size(56, 17);
            this.LFormat.TabIndex = 7;
            this.LFormat.Text = "Format:";
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(270, 95);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(39, 17);
            this.LTitle.TabIndex = 8;
            this.LTitle.Text = "Title:";
            this.LTitle.Click += new System.EventHandler(this.Title_Click);
            // 
            // LYear
            // 
            this.LYear.AutoSize = true;
            this.LYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LYear.Location = new System.Drawing.Point(518, 95);
            this.LYear.Name = "LYear";
            this.LYear.Size = new System.Drawing.Size(42, 17);
            this.LYear.TabIndex = 9;
            this.LYear.Text = "Year:";
            this.LYear.Click += new System.EventHandler(this.label3_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(194, 160);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(284, 38);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search!";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Serach_Click);
            // 
            // Refs
            // 
            this.Refs.Location = new System.Drawing.Point(46, 247);
            this.Refs.Name = "Refs";
            this.Refs.Size = new System.Drawing.Size(649, 118);
            this.Refs.TabIndex = 11;
            this.Refs.Text = "";
            // 
            // LRefs
            // 
            this.LRefs.AutoSize = true;
            this.LRefs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LRefs.Location = new System.Drawing.Point(43, 214);
            this.LRefs.Name = "LRefs";
            this.LRefs.Size = new System.Drawing.Size(129, 17);
            this.LRefs.TabIndex = 12;
            this.LRefs.Text = "Found References:";
            // 
            // SearchMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 401);
            this.Controls.Add(this.LRefs);
            this.Controls.Add(this.Refs);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LYear);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.LFormat);
            this.Controls.Add(this.LArtist);
            this.Controls.Add(this.LAlbum);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.Fromat);
            this.Controls.Add(this.Album);
            this.Name = "SearchMusic";
            this.Text = "SearchMusic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.TextBox Fromat;
        private System.Windows.Forms.TextBox Artist;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label LAlbum;
        private System.Windows.Forms.Label LArtist;
        private System.Windows.Forms.Label LFormat;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LYear;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox Refs;
        private System.Windows.Forms.Label LRefs;
    }
}