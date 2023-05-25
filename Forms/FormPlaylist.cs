using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player.Forms
{
    public partial class FormPlaylist : Form
    {
        private DatabaseConnector _db;
        private List<string> _playlists;
        private List<string> _currentPlaylistSongs;
        private string _currentPlaylistName;
        
        private void FormPlaylist_Load_1(object sender, EventArgs e)
        {
            _db = new DatabaseConnector();
            LoadPlaylists();
        }
        public FormPlaylist()
        {
            InitializeComponent();
        }

        public void LoadPlaylists()
        {
            playlistWindow.Items.Clear();
            playlistWindow.Items.Add("- YOUR PLAYLISTS -");
            _playlists = _db.ListPlaylists();
            int i = 1;
            foreach (string title in _playlists)
            {
                playlistWindow.Items.Add(i + ") " + title);
                i++;
            }
        }

        private void LoadSongs()
        {
            playlistWindow.Items.Clear();
            playlistWindow.Items.Add("- SONGS FROM " + _currentPlaylistName + " -");
            int i = 1;
            foreach (string title in _currentPlaylistSongs)
            {
                playlistWindow.Items.Add(i + ") " + title);
                i++;
            }
        }

        private void loadPlaylistButton_click(object sender, EventArgs e) //TO DO NU VA ATINGETI
        {
            try
            {
                _currentPlaylistName = playlistWindow.GetItemText(playlistWindow.SelectedItem).Split()[1];
                string query = String.Format("SELECT SongName, SongAuthor FROM [{0}]", _currentPlaylistName);
                _currentPlaylistSongs = _db.RetrieveQueryData(query);
                LoadSongs();
                buttonBack.Enabled = true;
            } catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please select a playlist.", "Error");
            }

        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            string playlistName = Prompt.ShowDialog("Enter a name: ", "New Playlist");
            string query = String.Format("CREATE TABLE [{0}] " +
                "(SongID int not null IDENTITY(1,1)," +
                "SongName varchar(50) unique not null," +
                "SongAuthor varchar(50) not null," +
                "SongData varbinary(MAX) not null)", playlistName);
            _db.ExecuteQuery(query);
            LoadPlaylists();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonBack.Enabled = false;
            LoadPlaylists();
        }
    }
}
