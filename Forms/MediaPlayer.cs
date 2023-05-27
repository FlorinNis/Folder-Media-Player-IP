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
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        List<int> _shuffledSongs = new List<int>();
        int currentFile = 0;
        int cntShuffle = 0;
        bool shuffleON = false;
        public MediaPlayer()
        {
            InitializeComponent();

            windowsMediaPlayer.Ctlcontrols.stop();

            if (filteredFiles.Count > 1)
            {
                filteredFiles.Clear();
                filteredFiles = null;

                _shuffledSongs.Clear();
                _shuffledSongs = null;

                currentlyPlaying.Items.Clear();

                currentFile = 0;

            }

            string path = Path.Combine(Application.StartupPath, "UserSongs");
            Console.WriteLine(path);

            try
            {
                filteredFiles = Directory.GetFiles(path, "*.*").Where(file => file.ToLower().EndsWith("webm") ||
                file.ToLower().EndsWith("mp3") || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv") || file.ToLower().EndsWith("mkv") || file.ToLower().EndsWith("avi")).ToList();

                if (filteredFiles.Count == 0)
                {
                    MessageBox.Show("Nu aveti un playlist selectat. Va rog sa selectati un playlist din meniu si apoi sa reveniti.");
                }
                else
                {
                    _shuffledSongs.AddRange(Enumerable.Repeat(0, filteredFiles.Count));
                    LoadPlayList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O eroare a aparut la initierea playlistului");
            }
        }
        private void PlayListChanged(object sender, EventArgs e)
        {
            //Selecteaza fisierul curent ii da play in video player si afiseaza in label numele fisierului care ruleaza la momentul respectiv
            currentFile = currentlyPlaying.SelectedIndex;
            PlayFile(filteredFiles[currentFile]);
            ShowFileName(labelSong);

        }

        private void LoadPlayList()
        {

            //creaza un playlist pentru media player
            windowsMediaPlayer.currentPlaylist = windowsMediaPlayer.newPlaylist("Playlist", "");

            //adauga video-urile din lista de playlist in playlistu media playerului
            foreach (string videos in filteredFiles)
            {
                string videoTitle = Path.GetFileNameWithoutExtension(videos);
                windowsMediaPlayer.currentPlaylist.appendItem(windowsMediaPlayer.newMedia(videos));
                currentlyPlaying.Items.Add(videoTitle);
            }

            if (filteredFiles.Count > 0)
            {
                labelSong.Text = "Files Found " + filteredFiles.Count;

                currentlyPlaying.SelectedIndex = currentFile;

                PlayFile(filteredFiles[currentFile]);
            }
            else
            {
                //Se va inlocui cu un block try catch
                MessageBox.Show("No video Files Found in this folder");
            }
        }

        private void PlayFile(string url)
        {
            windowsMediaPlayer.URL = url;
        }

        private void ShowFileName(Label playing)
        {
            //va afisa in interfata numele fisierului care ruleaza
            string file = Path.GetFileName(currentlyPlaying.SelectedItem.ToString());
            playing.Text = "Currently Playing: " + file;
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            if (shuffleON == false)
            {
                shuffleON = true;
                bool ok = true;
                int cntMel = filteredFiles.Count;
                Random rnd = new Random();

                while (ok == true)
                {
                    ok = false;

                    if (cntShuffle == cntMel)
                    {
                        Console.WriteLine("intra in if");
                        _shuffledSongs.Clear();
                        _shuffledSongs.AddRange(Enumerable.Repeat(0, filteredFiles.Count));
                        cntShuffle = 0;
                    }
                    currentFile = rnd.Next(0, filteredFiles.Count);
                    if (_shuffledSongs[currentFile] == 0)
                    {
                        Console.WriteLine("intra in if shuffle");
                        _shuffledSongs[currentFile] = 1;
                        cntShuffle++;
                        currentlyPlaying.SelectedIndex = currentFile;
                        PlayFile(filteredFiles[currentFile]);
                    }
                    else
                    {
                        ok = true;
                    }
                }
            }
            else
            {
                shuffleON = false;
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.play();
            timer1.Stop();
        }

        private void windowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                //undefined loaded

                labelDuration.Text = "Media Player Ready";
            }
            else if (e.newState == 1)
            {
                //if the file is stopped

                labelDuration.Text = "Media Player Stopped";
            }
            else if (e.newState == 3)
            {
                //if the file is playing

                labelDuration.Text = "Duration: " + windowsMediaPlayer.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                //media has ended

                //daca nu a ajuns la final de playlist trecem la video-ul urmator
                if (currentFile >= filteredFiles.Count - 1 && shuffleON == false)
                {
                    currentFile = 0;
                }
                else if (shuffleON == false)
                {
                    currentFile += 1;
                }
                else if (shuffleON == true)
                {
                    bool ok = true;
                    int cntMel = filteredFiles.Count;
                    Random rnd = new Random();

                    while (ok == true)
                    {
                        ok = false;

                        if (cntShuffle == cntMel)
                        {
                            Console.WriteLine("intra in if");
                            _shuffledSongs.Clear();
                            _shuffledSongs.AddRange(Enumerable.Repeat(0, filteredFiles.Count));
                            cntShuffle = 0;
                        }
                        currentFile = rnd.Next(0, filteredFiles.Count);
                        if (_shuffledSongs[currentFile] == 0)
                        {
                            Console.WriteLine("intra in if shuffle");
                            _shuffledSongs[currentFile] = 1;
                            cntShuffle++;
                            currentlyPlaying.SelectedIndex = currentFile;
                            PlayFile(filteredFiles[currentFile]);
                        }
                        else
                        {
                            ok = true;
                        }
                    }
                }

                //dam spre rulare urm video
                currentlyPlaying.SelectedIndex = currentFile;

                //afisam in label numele video-ului
                ShowFileName(labelSong);
            }
            else if (e.newState == 9)
            {
                //if the media player is loading a new vid
                labelDuration.Text = "Loading New Video";
            }
            else if (e.newState == 10)
            {
                //media is ready to play again
                timer1.Start();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentFile <= 0 && shuffleON == false)
            {
                currentFile = filteredFiles.Count;
            }
            else if (shuffleON == false)
            {
                currentFile -= 1;
                currentlyPlaying.SelectedIndex = currentFile;
                PlayFile(filteredFiles[currentFile]);
            }
            else if (shuffleON == true)
            {
                bool ok = true;
                int cntMel = filteredFiles.Count;
                Random rnd = new Random();

                while (ok == true)
                {
                    ok = false;

                    if (cntShuffle == cntMel)
                    {
                        Console.WriteLine("intra in if");
                        _shuffledSongs.Clear();
                        _shuffledSongs.AddRange(Enumerable.Repeat(0, filteredFiles.Count));
                        cntShuffle = 0;
                    }
                    currentFile = rnd.Next(0, filteredFiles.Count);
                    if (_shuffledSongs[currentFile] == 0)
                    {
                        Console.WriteLine("intra in if shuffle");
                        _shuffledSongs[currentFile] = 1;
                        cntShuffle++;
                        currentlyPlaying.SelectedIndex = currentFile;
                        PlayFile(filteredFiles[currentFile]);
                    }
                    else
                    {
                        ok = true;
                    }
                }
            }

            ShowFileName(labelSong);
        }

        private void buttonNxt_Click(object sender, EventArgs e)
        {
            if (currentFile >= filteredFiles.Count - 1 && shuffleON == false)
            {
                currentFile = 0;
            }
            else if (shuffleON == false)
            {
                currentFile += 1;
                currentlyPlaying.SelectedIndex = currentFile;
                PlayFile(filteredFiles[currentFile]);
            }
            else if (shuffleON == true)
            {
                bool ok = true;
                int cntMel = filteredFiles.Count;
                Random rnd = new Random();

                while (ok == true)
                {
                    ok = false;

                    if (cntShuffle == cntMel)
                    {
                        Console.WriteLine("intra in if");
                        _shuffledSongs.Clear();
                        _shuffledSongs.AddRange(Enumerable.Repeat(0, filteredFiles.Count));
                        cntShuffle = 0;
                    }
                    currentFile = rnd.Next(0, filteredFiles.Count);
                    if (_shuffledSongs[currentFile] == 0)
                    {
                        Console.WriteLine("intra in if shuffle");
                        _shuffledSongs[currentFile] = 1;
                        cntShuffle++;
                        currentlyPlaying.SelectedIndex = currentFile;
                        PlayFile(filteredFiles[currentFile]);
                    }
                    else
                    {
                        ok = true;
                    }
                }
            }

            ShowFileName(labelSong);
        }
    }

}
