
namespace Media_Player.Forms
{
    partial class FormPlaylist
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
            this.playlistsWindow = new System.Windows.Forms.ListBox();
            this.buttonAddSongs = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.deletePlaylistButton = new System.Windows.Forms.Button();
            this.deleteFromPlaylistButton = new System.Windows.Forms.Button();
            this.addToPlaylistButton = new System.Windows.Forms.Button();
            this.loadPlaylistButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlaylists = new System.Windows.Forms.Label();
            this.labelSongs = new System.Windows.Forms.Label();
            this.songsWindow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // playlistsWindow
            // 
            this.playlistsWindow.BackColor = System.Drawing.Color.MintCream;
            this.playlistsWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistsWindow.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistsWindow.FormattingEnabled = true;
            this.playlistsWindow.ItemHeight = 21;
            this.playlistsWindow.Location = new System.Drawing.Point(288, 236);
            this.playlistsWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playlistsWindow.Name = "playlistsWindow";
            this.playlistsWindow.Size = new System.Drawing.Size(456, 168);
            this.playlistsWindow.TabIndex = 0;
            this.playlistsWindow.SelectedIndexChanged += new System.EventHandler(this.playlistWindow_SelectedIndexChanged);
            // 
            // buttonAddSongs
            // 
            this.buttonAddSongs.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddSongs.FlatAppearance.BorderSize = 0;
            this.buttonAddSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSongs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSongs.ForeColor = System.Drawing.Color.MintCream;
            this.buttonAddSongs.Image = global::Media_Player.Properties.Resources.addSongs;
            this.buttonAddSongs.Location = new System.Drawing.Point(569, 416);
            this.buttonAddSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddSongs.Name = "buttonAddSongs";
            this.buttonAddSongs.Size = new System.Drawing.Size(198, 86);
            this.buttonAddSongs.TabIndex = 7;
            this.buttonAddSongs.Text = "Add Songs";
            this.buttonAddSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddSongs.UseVisualStyleBackColor = false;
            this.buttonAddSongs.Click += new System.EventHandler(this.buttonAddSongs_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Enabled = false;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.Image = global::Media_Player.Properties.Resources.back1;
            this.buttonBack.Location = new System.Drawing.Point(287, 409);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 93);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.FlatAppearance.BorderSize = 0;
            this.createPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.createPlaylistButton.Image = global::Media_Player.Properties.Resources.CreatePlaylist3;
            this.createPlaylistButton.Location = new System.Drawing.Point(19, 4);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(168, 89);
            this.createPlaylistButton.TabIndex = 5;
            this.createPlaylistButton.Text = "Create Playlist";
            this.createPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // deletePlaylistButton
            // 
            this.deletePlaylistButton.BackColor = System.Drawing.Color.Black;
            this.deletePlaylistButton.FlatAppearance.BorderSize = 0;
            this.deletePlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.deletePlaylistButton.Image = global::Media_Player.Properties.Resources.delete;
            this.deletePlaylistButton.Location = new System.Drawing.Point(9, 396);
            this.deletePlaylistButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePlaylistButton.Name = "deletePlaylistButton";
            this.deletePlaylistButton.Size = new System.Drawing.Size(186, 84);
            this.deletePlaylistButton.TabIndex = 4;
            this.deletePlaylistButton.Text = "Delete Playlist";
            this.deletePlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deletePlaylistButton.UseVisualStyleBackColor = false;
            this.deletePlaylistButton.Click += new System.EventHandler(this.deletePlaylistButton_Click);
            // 
            // deleteFromPlaylistButton
            // 
            this.deleteFromPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.deleteFromPlaylistButton.FlatAppearance.BorderSize = 0;
            this.deleteFromPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFromPlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFromPlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.deleteFromPlaylistButton.Image = global::Media_Player.Properties.Resources.minus;
            this.deleteFromPlaylistButton.Location = new System.Drawing.Point(9, 291);
            this.deleteFromPlaylistButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteFromPlaylistButton.Name = "deleteFromPlaylistButton";
            this.deleteFromPlaylistButton.Size = new System.Drawing.Size(178, 93);
            this.deleteFromPlaylistButton.TabIndex = 3;
            this.deleteFromPlaylistButton.Text = "Delete from Playlist";
            this.deleteFromPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteFromPlaylistButton.UseVisualStyleBackColor = false;
            this.deleteFromPlaylistButton.Click += new System.EventHandler(this.deleteFromPlaylistButton_Click);
            // 
            // addToPlaylistButton
            // 
            this.addToPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.addToPlaylistButton.FlatAppearance.BorderSize = 0;
            this.addToPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToPlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToPlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.addToPlaylistButton.Image = global::Media_Player.Properties.Resources.plus;
            this.addToPlaylistButton.Location = new System.Drawing.Point(9, 191);
            this.addToPlaylistButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addToPlaylistButton.Name = "addToPlaylistButton";
            this.addToPlaylistButton.Size = new System.Drawing.Size(186, 97);
            this.addToPlaylistButton.TabIndex = 2;
            this.addToPlaylistButton.Text = "Add to Playlist";
            this.addToPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addToPlaylistButton.UseVisualStyleBackColor = false;
            this.addToPlaylistButton.Click += new System.EventHandler(this.addToPlaylistButton_Click);
            // 
            // loadPlaylistButton
            // 
            this.loadPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.loadPlaylistButton.FlatAppearance.BorderSize = 0;
            this.loadPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.loadPlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.loadPlaylistButton.Image = global::Media_Player.Properties.Resources.LoadPl1;
            this.loadPlaylistButton.Location = new System.Drawing.Point(9, 89);
            this.loadPlaylistButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadPlaylistButton.Name = "loadPlaylistButton";
            this.loadPlaylistButton.Size = new System.Drawing.Size(186, 107);
            this.loadPlaylistButton.TabIndex = 1;
            this.loadPlaylistButton.Text = "Load Playlist";
            this.loadPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.loadPlaylistButton.UseVisualStyleBackColor = false;
            this.loadPlaylistButton.Click += new System.EventHandler(this.loadPlaylistButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // labelPlaylists
            // 
            this.labelPlaylists.AutoSize = true;
            this.labelPlaylists.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelPlaylists.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPlaylists.Location = new System.Drawing.Point(283, 208);
            this.labelPlaylists.Name = "labelPlaylists";
            this.labelPlaylists.Size = new System.Drawing.Size(112, 21);
            this.labelPlaylists.TabIndex = 9;
            this.labelPlaylists.Text = "Your Playlists";
            // 
            // labelSongs
            // 
            this.labelSongs.AutoSize = true;
            this.labelSongs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelSongs.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelSongs.Location = new System.Drawing.Point(283, 9);
            this.labelSongs.Name = "labelSongs";
            this.labelSongs.Size = new System.Drawing.Size(95, 21);
            this.labelSongs.TabIndex = 10;
            this.labelSongs.Text = "Your Songs";
            // 
            // songsWindow
            // 
            this.songsWindow.BackColor = System.Drawing.Color.MintCream;
            this.songsWindow.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.songsWindow.FormattingEnabled = true;
            this.songsWindow.ItemHeight = 21;
            this.songsWindow.Location = new System.Drawing.Point(287, 33);
            this.songsWindow.Name = "songsWindow";
            this.songsWindow.Size = new System.Drawing.Size(455, 172);
            this.songsWindow.TabIndex = 11;
            // 
            // FormPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(766, 513);
            this.Controls.Add(this.songsWindow);
            this.Controls.Add(this.labelSongs);
            this.Controls.Add(this.labelPlaylists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddSongs);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.createPlaylistButton);
            this.Controls.Add(this.deletePlaylistButton);
            this.Controls.Add(this.deleteFromPlaylistButton);
            this.Controls.Add(this.addToPlaylistButton);
            this.Controls.Add(this.loadPlaylistButton);
            this.Controls.Add(this.playlistsWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPlaylist";
            this.Text = "FormPlaylist";
            this.Load += new System.EventHandler(this.FormPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlistsWindow;
        private System.Windows.Forms.Button loadPlaylistButton;
        private System.Windows.Forms.Button addToPlaylistButton;
        private System.Windows.Forms.Button deleteFromPlaylistButton;
        private System.Windows.Forms.Button deletePlaylistButton;
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlaylists;
        private System.Windows.Forms.Label labelSongs;
        private System.Windows.Forms.ListBox songsWindow;
    }
}