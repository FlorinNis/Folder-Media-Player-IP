using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Media_Player.Forms
{
    public partial class MediaPlayer : Form
    {
        int currentFile = 0;
        List<string> _currentPlaylistSongsName = new List<string>();
        List<string> _playlistSongs = new List<string>();
        
        
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void InitPlaylistPlayer(object sender, EventArgs e)
        {
            //opreste daca este deja ceva ruland in player
            VideoPlayer.Ctlcontrols.stop();

            //verifica daca este ceva in lista
            if (_currentPlaylistSongsName.Count > 1)
            {
                //daca da sterge tot din lista
                _currentPlaylistSongsName.Clear();
                _currentPlaylistSongsName = null;


                //resetam fisierul curent la 0
                currentFile = 0;

                //citim din baza de date numele la melodii si le punem in lista _currentPlaylistSongsName
                //
                //to do cand e gata bd
                //

                //citim din baza de date codecu la melodii/video care o sa fie rulate efectiv in player si le punem in _playlistSongs
                //
                //to do cand e gata bd
                //
            }

            //la final incarcam playlistu in video player sa ruleze
            LoadPlayList();
        }

        private void MediaPlayerStateChangeEvent(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                //undefined loaded

                lblDuration.Text = "Media player is Ready to be loaded";
            }
            else if (e.newState == 1)
            {
                //if the file is stopped

                lblDuration.Text = "Media Player Stopped";
            }
            else if (e.newState == 3)
            {
                //if the file is playing

                lblDuration.Text = "Duration: " + VideoPlayer.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                //media has ended

                //daca nu a ajuns la final de playlist trecem la video-ul urmator
                if (currentFile >= _currentPlaylistSongsName.Count - 1)
                {
                    currentFile = 0;
                }
                else
                    currentFile += 1;

                //afisam in label numele video-ului
                ShowFileName(fileName);
            }
            else if (e.newState == 9)
            {
                //if the media player is loading a new vid
                lblDuration.Text = "Loading new video";
            }
            else if (e.newState == 10)
            {
                //media is ready to play again
                //timer1.Start();
            }
        }

        private void LoadPlayList()
        {
            //creaza un playlist pentru media player
            VideoPlayer.currentPlaylist = VideoPlayer.newPlaylist("Playlist", "");

            //adauga video-urile din lista de video-uri/melodii in playlistu media playerului
            foreach (string videos in _playlistSongs)
            {
                VideoPlayer.currentPlaylist.appendItem(VideoPlayer.newMedia(videos));
            }

            try
            {
                if (_playlistSongs.Count > 0)
                {
                    fileName.Text = "Files Found " + _playlistSongs.Count;

                    //rulam video-ul
                    PlayFile(_playlistSongs[currentFile]);
                }
            }
            catch
            {
                MessageBox.Show("No video Files Found in this folder");
            }
        }

        private void PlayFile(string url)
        {
            VideoPlayer.URL = url;
        }


        private void ShowFileName(Label name)
        {
            //va afisa in interfata numele fisierului care ruleaza
            string file = _currentPlaylistSongsName[currentFile].ToString();
            name.Text = "Currently Playing: " + file;
        }
    }
}
