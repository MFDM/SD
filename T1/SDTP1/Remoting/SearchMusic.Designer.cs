using System.Net.Mime;
using System.Windows.Forms;

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
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Album = new System.Windows.Forms.TextBox();
            this.Artist = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.LAlbum = new System.Windows.Forms.Label();
            this.LArtist = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.LRefs = new System.Windows.Forms.Label();
            this.NoSearchText = new System.Windows.Forms.Label();
            this.peerinfo = new System.Windows.Forms.Label();
            this.MusicInfo = new System.Windows.Forms.DataGridView();
            this.Peer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeepBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMusicButton = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.RichTextBox();
            this.Lconnect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MusicInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(88, 119);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(279, 20);
            this.Album.TabIndex = 0;
            // 
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(88, 83);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(279, 20);
            this.Artist.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(88, 158);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(279, 20);
            this.Title.TabIndex = 3;
            // 
            // LAlbum
            // 
            this.LAlbum.AutoSize = true;
            this.LAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlbum.Location = new System.Drawing.Point(31, 122);
            this.LAlbum.Name = "LAlbum";
            this.LAlbum.Size = new System.Drawing.Size(51, 17);
            this.LAlbum.TabIndex = 5;
            this.LAlbum.Text = "Album:";
            // 
            // LArtist
            // 
            this.LArtist.AutoSize = true;
            this.LArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LArtist.Location = new System.Drawing.Point(38, 86);
            this.LArtist.Name = "LArtist";
            this.LArtist.Size = new System.Drawing.Size(44, 17);
            this.LArtist.TabIndex = 6;
            this.LArtist.Text = "Artist:";
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(38, 158);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(39, 17);
            this.LTitle.TabIndex = 8;
            this.LTitle.Text = "Title:";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(420, 117);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(164, 63);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LRefs
            // 
            this.LRefs.AutoSize = true;
            this.LRefs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LRefs.Location = new System.Drawing.Point(38, 212);
            this.LRefs.Name = "LRefs";
            this.LRefs.Size = new System.Drawing.Size(129, 17);
            this.LRefs.TabIndex = 12;
            this.LRefs.Text = "Found References:";
            // 
            // NoSearchText
            // 
            this.NoSearchText.AutoSize = true;
            this.NoSearchText.ForeColor = System.Drawing.Color.DarkRed;
            this.NoSearchText.Location = new System.Drawing.Point(417, 203);
            this.NoSearchText.Name = "NoSearchText";
            this.NoSearchText.Size = new System.Drawing.Size(0, 13);
            this.NoSearchText.TabIndex = 13;
            // 
            // peerinfo
            // 
            this.peerinfo.AutoSize = true;
            this.peerinfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peerinfo.Location = new System.Drawing.Point(38, 40);
            this.peerinfo.Name = "peerinfo";
            this.peerinfo.Size = new System.Drawing.Size(45, 13);
            this.peerinfo.TabIndex = 14;
            this.peerinfo.Text = "peerinfo";
            // 
            // MusicInfo
            // 
            this.MusicInfo.AllowDrop = true;
            this.MusicInfo.AllowUserToOrderColumns = true;
            this.MusicInfo.BackgroundColor = System.Drawing.Color.White;
            this.MusicInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MusicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusicInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Peer,
            this.MArtist,
            this.MTitle,
            this.MYear,
            this.MAlbum,
            this.MFormat});
            this.MusicInfo.GridColor = System.Drawing.Color.White;
            this.MusicInfo.Location = new System.Drawing.Point(41, 251);
            this.MusicInfo.Name = "MusicInfo";
            this.MusicInfo.Size = new System.Drawing.Size(479, 100);
            this.MusicInfo.TabIndex = 15;
            // 
            // Peer
            // 
            this.Peer.HeaderText = "Peer";
            this.Peer.Name = "Peer";
            // 
            // MArtist
            // 
            this.MArtist.HeaderText = "Artist";
            this.MArtist.Name = "MArtist";
            // 
            // MTitle
            // 
            this.MTitle.HeaderText = "Title";
            this.MTitle.Name = "MTitle";
            // 
            // MYear
            // 
            this.MYear.HeaderText = "Year";
            this.MYear.Name = "MYear";
            // 
            // MAlbum
            // 
            this.MAlbum.HeaderText = "Album";
            this.MAlbum.Name = "MAlbum";
            // 
            // MFormat
            // 
            this.MFormat.HeaderText = "Format";
            this.MFormat.Name = "MFormat";
            // 
            // DeepBox
            // 
            this.DeepBox.Location = new System.Drawing.Point(459, 80);
            this.DeepBox.Name = "DeepBox";
            this.DeepBox.Size = new System.Drawing.Size(53, 20);
            this.DeepBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Deep:";
            // 
            // addMusicButton
            // 
            this.addMusicButton.Location = new System.Drawing.Point(544, 275);
            this.addMusicButton.Name = "addMusicButton";
            this.addMusicButton.Size = new System.Drawing.Size(66, 37);
            this.addMusicButton.TabIndex = 18;
            this.addMusicButton.Text = "Add";
            this.addMusicButton.UseVisualStyleBackColor = true;
            this.addMusicButton.Click += new System.EventHandler(this.addMusicButton_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(41, 390);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(569, 95);
            this.connect.TabIndex = 19;
            this.connect.Text = "";
            // 
            // Lconnect
            // 
            this.Lconnect.AutoSize = true;
            this.Lconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lconnect.Location = new System.Drawing.Point(38, 370);
            this.Lconnect.Name = "Lconnect";
            this.Lconnect.Size = new System.Drawing.Size(135, 17);
            this.Lconnect.TabIndex = 20;
            this.Lconnect.Text = "Connections Online:";
            // 
            // SearchMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 536);
            this.Controls.Add(this.Lconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.addMusicButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeepBox);
            this.Controls.Add(this.MusicInfo);
            this.Controls.Add(this.peerinfo);
            this.Controls.Add(this.NoSearchText);
            this.Controls.Add(this.LRefs);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.LArtist);
            this.Controls.Add(this.LAlbum);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.Album);
            this.Name = "SearchMusic";
            this.Text = "SearchMusic";
            ((System.ComponentModel.ISupportInitialize)(this.MusicInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.TextBox Artist;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label LAlbum;
        private System.Windows.Forms.Label LArtist;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label LRefs;
        private Label NoSearchText;
        private Label peerinfo;
        private DataGridView MusicInfo;
        public DataGridViewTextBoxColumn Peer;
        private DataGridViewTextBoxColumn MArtist;
        private DataGridViewTextBoxColumn MTitle;
        private DataGridViewTextBoxColumn MYear;
        private DataGridViewTextBoxColumn MAlbum;
        private TextBox DeepBox;
        private Label label1;
        private Button addMusicButton;
        private DataGridViewTextBoxColumn MFormat;
        private RichTextBox connect;
        private Label Lconnect;
    }
}