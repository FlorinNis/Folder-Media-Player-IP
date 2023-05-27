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
using System.Collections;
using Microsoft.Data.SqlClient;
using Models;
using View.MediaFile;
using View.Playlist;

namespace Media_Player.Forms
{
    public partial class FormPlaylist : Form
    {
        private DatabaseConnector _db;
        private IMediaFileView _mediaFileView;
        private IPlaylistView _playlistView;
        private List<string> _playlists;
        private List<string> _currentPlaylistSongs;
        private string _currentPlaylistName;

        private void FormPlaylist_Load(object sender, EventArgs e) //ok
        {
            ShowAllSongs(songsWindow);
            ShowPlaylists(playlistsWindow);
        }
        public FormPlaylist()
        {
            _db = new DatabaseConnector();
            MediaFileRepository mrep = new MediaFileRepository(_db);
            PlaylistRepository prep = new PlaylistRepository(_db);
            _mediaFileView = new MediaFileView(mrep);
            _playlistView = new PlaylistView(prep);
            InitializeComponent();
        }


        private void loadPlaylistButton_click(object sender, EventArgs e) //ok
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(".\\UserSongs\\");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            ShowPlaylistSongs(playlistsWindow);
        }

        private void createPlaylistButton_Click(object sender, EventArgs e) //ok
        {
            string playlistName = Prompt.ShowDialog("Enter a name: ", "New Playlist");
            _playlistView.CreatePlaylist(playlistName);
            ShowPlaylists(playlistsWindow);
        }

        private void buttonBack_Click(object sender, EventArgs e) //ok
        {
            buttonBack.Enabled = false;
            labelPlaylists.Text = "Your Playlists";
            ShowPlaylists(playlistsWindow);
        }

        private void addToPlaylistButton_Click(object sender, EventArgs e) //ok
        {
            if (_currentPlaylistName != null) {
                try
                {
                    string name = songsWindow.SelectedItem.ToString().Split('-')[0].Trim();
                    string author = songsWindow.SelectedItem.ToString().Split('-')[1].Trim();
                    _mediaFileView.AddMediaFileToPlaylist(_currentPlaylistName, _mediaFileView.RetrieveFile(name, author));
                    ShowPlaylistSongs(playlistsWindow);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Please select a valid playlist.", "Error");
                }
            } else
            {
                MessageBox.Show("No valid playlist selected!", "Error");
            }
        }

        private void ShowPlaylists(ListBox window) //ok
        {
            window.Items.Clear();
            _playlists = _playlistView.GetPlaylists();
            int i = 1;
            foreach (string title in _playlists)
            {
                Console.WriteLine(title);
                window.Items.Add(title);
                i++;
            }
        }

        private void ShowPlaylistSongs(ListBox window) //ok
        {
            _currentPlaylistSongs = _mediaFileView.GetPlaylistMediaFileNames(_currentPlaylistName).ToList();
            labelPlaylists.Text = "Songs in " + _currentPlaylistName;
            window.Items.Clear();
            int i = 0;
            foreach (string title in _currentPlaylistSongs)
            {
                _mediaFileView.LoadMediaFile(_currentPlaylistSongs[i].Split('-')[0].Trim(), _currentPlaylistSongs[i].Split('-')[1].Trim());
                window.Items.Add(title);
                i++;
            }
            buttonBack.Enabled = true;

        }

        private void ShowAllSongs(ListBox window) //ok
        {
            try
            {
                _currentPlaylistSongs = _mediaFileView.GetAllMediaFileNames().ToList();

            } catch(NullReferenceException)
            {

                Console.WriteLine("No songs in database.");
            }

                window.Items.Clear();
                int i = 1;
                foreach (string title in _currentPlaylistSongs)
                {
                    window.Items.Add(title);
                    i++;
                }     
        }

        private void playlistWindow_SelectedIndexChanged(object sender, EventArgs e) //ok
        {
            if (buttonBack.Enabled == false)
            {
                _currentPlaylistName = playlistsWindow.GetItemText(playlistsWindow.SelectedItem);
            }
        }

        private void buttonAddSongs_Click(object sender, EventArgs e) //ok
        {
                try
                {
                    List<string> filteredFiles = new List<string>();
                    FolderBrowserDialog browser = new FolderBrowserDialog();
                    if (filteredFiles.Count > 1)
                    {
                        filteredFiles.Clear();
                        filteredFiles = null;
                    }

                    DialogResult result = browser.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("webm") ||
                        file.ToLower().EndsWith("mp3") || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv") || file.ToLower().EndsWith("mkv") || file.ToLower().EndsWith("avi")).ToList();
                    }
                    byte[] buffer = new byte[10000000]; // pana la 10 MB
                    for (int i = 0; i < filteredFiles.Count; i++)
                    {
                            Stream video = File.OpenRead(filteredFiles[i]);
                            video.Read(buffer, 0, buffer.Length);
                            string name = Prompt.ShowDialog("Enter a name for " + filteredFiles[i].Split('\\').Last() + ": ", "Add to Playlist"); ;
                            string author = Prompt.ShowDialog("Enter an author: ", "Add to Playlist");
                            MediaFile file = new MediaFile(name, author);
                            _mediaFileView.AddMediaFile(file, buffer);
                            Array.Clear(buffer, 0, buffer.Length);
                    }
                    ShowAllSongs(songsWindow);
                }
                catch (IndexOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }

        private void deleteFromPlaylistButton_Click(object sender, EventArgs e) 
        {
            if (_currentPlaylistName != null)
            {
                try
                {
                    string name = playlistsWindow.SelectedItem.ToString().Split('-')[0].Trim();
                    string author = playlistsWindow.SelectedItem.ToString().Split('-')[1].Trim();
                    Console.WriteLine(name);
                    Console.WriteLine(author);
                    _mediaFileView.DeleteMediaFileFromPlaylist(_currentPlaylistName, _mediaFileView.RetrieveFile(name, author));
                    ShowPlaylistSongs(playlistsWindow);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Please select a valid playlist.", "Error");
                }
            }
            else
            {
                MessageBox.Show("No valid playlist selected!", "Error");
            }
        }

        private void deletePlaylistButton_Click(object sender, EventArgs e) //ok
        {
            if (_currentPlaylistName != null)
            {
                try
                {
                    _playlistView.DeletePlaylist(_currentPlaylistName);
                    ShowPlaylists(playlistsWindow);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Please select a valid playlist.", "Error");
                }
            }
            else
            {
                MessageBox.Show("No valid playlist selected!", "Error");
            }
        }
    }
    }
