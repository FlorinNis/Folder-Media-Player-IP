
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblDuration = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(1, 1);
            this.VideoPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(628, 477);
            this.VideoPlayer.TabIndex = 0;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(522, 455);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(59, 13);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Duration: 0";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.BackColor = System.Drawing.Color.White;
            this.fileName.Location = new System.Drawing.Point(214, 455);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(88, 13);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "Currently Playing:";
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(631, 477);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.VideoPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MediaPlayer";
            this.Text = "MediaPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label fileName;
    }
}