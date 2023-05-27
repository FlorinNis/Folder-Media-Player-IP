
namespace Media_Player.Forms
{
    partial class MediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.currentlyPlaying = new System.Windows.Forms.ListBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shuffleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(9, -34);
            this.windowsMediaPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(521, 495);
            this.windowsMediaPlayer.TabIndex = 0;
            this.windowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.windowsMediaPlayer_PlayStateChange);
            // 
            // currentlyPlaying
            // 
            this.currentlyPlaying.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlyPlaying.FormattingEnabled = true;
            this.currentlyPlaying.ItemHeight = 21;
            this.currentlyPlaying.Location = new System.Drawing.Point(544, 33);
            this.currentlyPlaying.Name = "currentlyPlaying";
            this.currentlyPlaying.Size = new System.Drawing.Size(206, 382);
            this.currentlyPlaying.TabIndex = 1;
            this.currentlyPlaying.SelectedIndexChanged += new System.EventHandler(this.PlayListChanged);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.Black;
            this.labelDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDuration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelDuration.Location = new System.Drawing.Point(540, 7);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(95, 21);
            this.labelDuration.TabIndex = 3;
            this.labelDuration.Text = "Duration: 0";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.BackColor = System.Drawing.Color.Black;
            this.labelSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSong.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSong.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelSong.Location = new System.Drawing.Point(5, 7);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(151, 21);
            this.labelSong.TabIndex = 4;
            this.labelSong.Text = "Currently Playing: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.Color.Transparent;
            this.shuffleButton.FlatAppearance.BorderSize = 0;
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.ForeColor = System.Drawing.Color.Transparent;
            this.shuffleButton.Image = global::Media_Player.Properties.Resources.shuffle;
            this.shuffleButton.Location = new System.Drawing.Point(604, 430);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(86, 54);
            this.shuffleButton.TabIndex = 2;
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(758, 510);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.currentlyPlaying);
            this.Controls.Add(this.windowsMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MediaPlayer";
            this.Text = "MediaPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.ListBox currentlyPlaying;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.Timer timer1;
    }
}