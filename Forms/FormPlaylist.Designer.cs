
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
            this.playlistWindow = new System.Windows.Forms.ListBox();
            this.deletePlaylistButton = new System.Windows.Forms.Button();
            this.deleteFromPlaylistButton = new System.Windows.Forms.Button();
            this.addToPlaylistButton = new System.Windows.Forms.Button();
            this.loadPlaylistButton = new System.Windows.Forms.Button();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playlistWindow
            // 
            this.playlistWindow.BackColor = System.Drawing.Color.MintCream;
            this.playlistWindow.FormattingEnabled = true;
            this.playlistWindow.Location = new System.Drawing.Point(220, 24);
            this.playlistWindow.Margin = new System.Windows.Forms.Padding(2);
            this.playlistWindow.Name = "playlistWindow";
            this.playlistWindow.Size = new System.Drawing.Size(391, 407);
            this.playlistWindow.TabIndex = 0;
            // 
            // deletePlaylistButton
            // 
            this.deletePlaylistButton.BackColor = System.Drawing.Color.Black;
            this.deletePlaylistButton.FlatAppearance.BorderSize = 0;
            this.deletePlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.deletePlaylistButton.Image = global::Media_Player.Properties.Resources.delete;
            this.deletePlaylistButton.Location = new System.Drawing.Point(9, 347);
            this.deletePlaylistButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePlaylistButton.Name = "deletePlaylistButton";
            this.deletePlaylistButton.Size = new System.Drawing.Size(186, 84);
            this.deletePlaylistButton.TabIndex = 4;
            this.deletePlaylistButton.Text = "Delete Playlist";
            this.deletePlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deletePlaylistButton.UseVisualStyleBackColor = false;
            // 
            // deleteFromPlaylistButton
            // 
            this.deleteFromPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.deleteFromPlaylistButton.FlatAppearance.BorderSize = 0;
            this.deleteFromPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFromPlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFromPlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.deleteFromPlaylistButton.Image = global::Media_Player.Properties.Resources.minus;
            this.deleteFromPlaylistButton.Location = new System.Drawing.Point(9, 259);
            this.deleteFromPlaylistButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteFromPlaylistButton.Name = "deleteFromPlaylistButton";
            this.deleteFromPlaylistButton.Size = new System.Drawing.Size(178, 84);
            this.deleteFromPlaylistButton.TabIndex = 3;
            this.deleteFromPlaylistButton.Text = "Delete from Playlist";
            this.deleteFromPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteFromPlaylistButton.UseVisualStyleBackColor = false;
            // 
            // addToPlaylistButton
            // 
            this.addToPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.addToPlaylistButton.FlatAppearance.BorderSize = 0;
            this.addToPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToPlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToPlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.addToPlaylistButton.Image = global::Media_Player.Properties.Resources.plus;
            this.addToPlaylistButton.Location = new System.Drawing.Point(9, 171);
            this.addToPlaylistButton.Margin = new System.Windows.Forms.Padding(2);
            this.addToPlaylistButton.Name = "addToPlaylistButton";
            this.addToPlaylistButton.Size = new System.Drawing.Size(186, 84);
            this.addToPlaylistButton.TabIndex = 2;
            this.addToPlaylistButton.Text = "Add to Playlist";
            this.addToPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addToPlaylistButton.UseVisualStyleBackColor = false;
            // 
            // loadPlaylistButton
            // 
            this.loadPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.loadPlaylistButton.FlatAppearance.BorderSize = 0;
            this.loadPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPlaylistButton.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.loadPlaylistButton.ForeColor = System.Drawing.Color.MintCream;
            this.loadPlaylistButton.Image = global::Media_Player.Properties.Resources.LoadPl1;
            this.loadPlaylistButton.Location = new System.Drawing.Point(9, 83);
            this.loadPlaylistButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadPlaylistButton.Name = "loadPlaylistButton";
            this.loadPlaylistButton.Size = new System.Drawing.Size(186, 84);
            this.loadPlaylistButton.TabIndex = 1;
            this.loadPlaylistButton.Text = "Load Playlist";
            this.loadPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.loadPlaylistButton.UseVisualStyleBackColor = false;
            this.loadPlaylistButton.Click += new System.EventHandler(this.loadPlaylistButton_click);
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.Location = new System.Drawing.Point(27, 12);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(160, 66);
            this.createPlaylistButton.TabIndex = 5;
            this.createPlaylistButton.Text = "Create Playlist razvan fa butonu asta ms pup pui si tu icon cu o foaie goala cu p" +
    "lus pe ea\r\n";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(220, 396);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(121, 35);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 452);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.createPlaylistButton);
            this.Controls.Add(this.deletePlaylistButton);
            this.Controls.Add(this.deleteFromPlaylistButton);
            this.Controls.Add(this.addToPlaylistButton);
            this.Controls.Add(this.loadPlaylistButton);
            this.Controls.Add(this.playlistWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPlaylist";
            this.Text = "FormPlaylist";
            this.Load += new System.EventHandler(this.FormPlaylist_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox playlistWindow;
        private System.Windows.Forms.Button loadPlaylistButton;
        private System.Windows.Forms.Button addToPlaylistButton;
        private System.Windows.Forms.Button deleteFromPlaylistButton;
        private System.Windows.Forms.Button deletePlaylistButton;
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.Button buttonBack;
    }
}