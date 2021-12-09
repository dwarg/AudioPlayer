using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using System.IO;

namespace player
{
    public partial class Form1 : Form
    {
        IWavePlayer waveOut;
        AudioFileReader audioFileReader;
        bool isPaused = false;
        bool isMuted = false;
        bool loop = false;
        bool shuffle = false;
        float volume = 0.5f;
        List<Song> songs = new List<Song>();

        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count!=0)
            {
                try
                {
                    if (!isPaused)
                    {
                        CloseWave();
                        waveOut = new WaveOut();
                        waveOut.PlaybackStopped += WaveOutStopped;
                        for (int i = 0; i < songs.Count; i++)
                        {
                            if (songs[i].FileName == listBox_songs.SelectedItem.ToString())
                            {
                                audioFileReader = new AudioFileReader(songs[i].FilePath);
                                audioFileReader.Volume = volume;

                                waveOut.Init(audioFileReader);
                                break;
                            }
                        }
                        waveOut.Init(audioFileReader);
                    }
                    waveOut.Play();
                    isPaused = false;

                    label1.Text = audioFileReader.TotalTime.ToString(@"m\:ss");

                    timer1.Start();
                }
                catch (Exception)
                {
                    listBox_songs.SelectedIndex = 0;
                }
            }
            else
            {
                btn_add_Click(sender, e);
                if (listBox_songs.Items.Count != 0)
                {
                    listBox_songs.SelectedIndex = 0;
                }
                isPaused = false;
             }
        }

        private void CloseWave()
        {
            if (listBox_songs.Items.Count!=0)
            {
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }
                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                    audioFileReader = null;
                }
                isPaused = false;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            CloseWave();
            timer1.Stop(); 
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 files (*.mp3)|*.mp3";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] paths = dialog.FileNames;
                string[] names = dialog.SafeFileNames;
                for (int i = 0; i < names.Length; i++)
                {
                    Song song = new Song(names[i], paths[i]);
                    if (!CheckRepeatedSong(paths[i]))
                    {
                        songs.Add(song);
                    }
                }
                RefreshList();
            }
        }
        private void RefreshList()
        {
            listBox_songs.Items.Clear();
            
            for (int i = 0; i < songs.Count; i++)
            {
                listBox_songs.Items.Add(songs[i].FileName);
            }
        }
        private void listBox_songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_songs.SelectedItem!=null)
            {
                CloseWave();
                waveOut = new WaveOut();
                waveOut.PlaybackStopped += WaveOutStopped;
                for (int i = 0; i < songs.Count; i++)
                {
                    if (songs[i].FileName == listBox_songs.SelectedItem.ToString())
                    {
                        audioFileReader = new AudioFileReader(songs[i].FilePath);
                        audioFileReader.Volume = volume;

                        var tfile = TagLib.File.Create(songs[i].FilePath);
                        string title = tfile.Tag.Title;
                        string artist = tfile.Tag.FirstPerformer;
                        label4.Text = title;
                        label5.Text = artist;

                        try
                        {
                            MemoryStream ms = new MemoryStream(tfile.Tag.Pictures[0].Data.Data);
                            Image image = Image.FromStream(ms);
                            pictureBox1.Image = image;
                        }
                        catch { }

                        break;
                    }
                }
                waveOut.Init(audioFileReader);
                waveOut.Play();
                label1.Text = audioFileReader.TotalTime.ToString(@"m\:ss");


                timer1.Start();
            }
        }

        private void WaveOutStopped(object sender, EventArgs e)
        {
            if(loop)
                btn_play_Click(sender, e);
            else
                btn_next_Click(sender, e);
        }

        private void btn_Previousbtn_Previous_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count!=0)
            {
                try
                {
                    //int index = listBox_songs.SelectedIndex;
                    //listBox_songs.SelectedItem = listBox_songs.Items[index - 1];
                    if (loop)
                        btn_play_Click(sender, e);
                    else
                        listBox_songs.SelectedIndex--;
                }
                catch (ArgumentOutOfRangeException)
                {
                    listBox_songs.SelectedItem = listBox_songs.Items[listBox_songs.Items.Count - 1];
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count!=0)
            {
                try
                {
                    //int index = listBox_songs.SelectedIndex;
                    //listBox_songs.SelectedItem = listBox_songs.Items[index + 1];
                    if (loop)
                        btn_play_Click(sender, e);
                    if (shuffle && !loop) 
                    {
                        if (listBox_songs.Items.Count > 0)
                        {
                            Random rnd = new Random();
                            listBox_songs.SelectedIndex = rnd.Next(0, listBox_songs.Items.Count);
                            btn_play_Click(sender, e);
                        }
                    }
                    else
                        listBox_songs.SelectedIndex++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    listBox_songs.SelectedItem = listBox_songs.Items[0];
                }
            }
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count!=0 && listBox_songs.SelectedItem!=null)
            {
                try
                {
                    if (isPaused)
                    {
                        waveOut.Play();
                        isPaused = false;
                    }
                    else
                    {
                        waveOut.Pause();
                        isPaused = true;
                    }
                }
                catch (NullReferenceException)
                {
                    
                }
            }
        }

        private void singleSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSong formAddSong = new FormAddSong();
            formAddSong.ShowDialog();
            if (formAddSong.DialogResult == DialogResult.OK)
            {
                if (CheckRepeatedSong(formAddSong.NewSong.FilePath))
                {
                    MessageBox.Show("Song already exists!", "Can not be added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    songs.Add(formAddSong.NewSong);
                    if (listBox_songs.Items.Count != 0)
                    {
                        DialogResult dialog = MessageBox.Show("Do you want to clear your songs list?", "Adding...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            songs.Clear();
                            songs.Add(formAddSong.NewSong);
                        }
                    }
                    RefreshList();
                }
            }
        }

        private void songsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool CheckRepeatedSong(string path)
        {
            bool isExist = false;
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].FilePath == path)
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            volume = trackBar_volume.Value / 10.0f;
            if (audioFileReader!=null)
            {
                audioFileReader.Volume = volume;
            }
            if (volume==0)
            {
                btn_mute.BackgroundImage = Properties.Resources.mute;
            }
            else
            {
                btn_mute.BackgroundImage = Properties.Resources.mute_no;
            }
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            if (audioFileReader!=null)
            {
                if (isMuted == false)
                {
                    audioFileReader.Volume = 0;
                    trackBar_volume.Value = 0;
                    btn_mute.BackgroundImage = Properties.Resources.mute;
                    isMuted = true;
                }
                else
                {
                    audioFileReader.Volume = volume;
                    trackBar_volume.Value = (int)(volume * 10);
                    btn_mute.BackgroundImage = Properties.Resources.mute_no;
                    isMuted = false;
                }
            }
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            if (waveOut!=null)
            {
                audioFileReader.CurrentTime = audioFileReader.CurrentTime.Add(TimeSpan.FromSeconds(-3));   
            }
        }

        private void btn_goFor_Click(object sender, EventArgs e)
        {
            if (waveOut!=null)
            {
                audioFileReader.CurrentTime = audioFileReader.CurrentTime.Add(TimeSpan.FromSeconds(3));   
            }
        }

        private void listBox_songs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox_songs_DragDrop(object sender, DragEventArgs e)
        {
            List<string> DroppedPaths = new List<string>();
            foreach (var path in (string[])e.Data.GetData(DataFormats.FileDrop,false))
            {
                if (Directory.Exists(path))
                {
                    DroppedPaths.AddRange(Directory.GetFiles(path));
                }
                else
                {
                    DroppedPaths.Add(path);
                }
            }
            for (int i = 0; i < DroppedPaths.Count; i++)
            {
                if (!CheckRepeatedSong(DroppedPaths[i]))
                {
                    string path = DroppedPaths[i];
                    int index = path.LastIndexOf('\\');
                    string name = path.Substring(index + 1);
                    songs.Add(new Song(name, path));
                }
            }
            RefreshList();
            DroppedPaths.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox_songs != null)
            {
                try
                {
                    for (int i = 0; i < listBox_songs.SelectedItems.Count; i++)
                    {
                        listBox_songs.Items.Remove(listBox_songs.SelectedItems[i]);
                    }
                   
                    waveOut.Stop();
                    timer1.Stop();
                }
                catch{}
            }

        }

        private void fileToolStripMenuItem_DropDownOpened_1(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void fileToolStripMenuItem_DropDownClosed_1(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.White)
            {
                shuffle = true;
                button1.BackColor = Color.Khaki;
            }
            else
            {
                shuffle = false;
                button1.BackColor = Color.White;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int value = (int)audioFileReader.CurrentTime.TotalMilliseconds;
            label2.Text = TimeSpan.FromMilliseconds(value).ToString(@"m\:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.White)
            {
                loop = true;
                button2.BackColor = Color.Khaki;
            }
            else
            {
                loop = false;
                button2.BackColor = Color.White;
            }
        }

        private void PlaybackStopped(object sender, StoppedEventArgs args)
        {
            waveOut.Dispose();
            audioFileReader.Dispose();
            timer1.Stop();

            if (isPaused == false)
            {
                if (listBox_songs.Items != null && listBox_songs.SelectedIndex != listBox_songs.Items.Count - 1 && !loop && !shuffle)
                {
                    listBox_songs.SelectedIndex += 1;
                    waveOut.Play();
                    //loop = false;
                }
                if (loop)
                {
                    waveOut.Play();
                }
                if(shuffle && !loop)
                {
                    if (listBox_songs.Items.Count > 0)
                    {
                        Random rnd = new Random();
                        listBox_songs.SelectedIndex = rnd.Next(0, listBox_songs.Items.Count);
                        waveOut.Play();
                    }
                }
            }
        }

        public void MoveItem(int direction, ListBox listBox_songs)
        {
            if (listBox_songs.SelectedItem == null || listBox_songs.SelectedIndex < 0)
                return; 

            int newIndex = listBox_songs.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBox_songs.Items.Count)
                return; 

            object selected = listBox_songs.SelectedItem;

            listBox_songs.Items.Remove(selected);
            listBox_songs.Items.Insert(newIndex, selected);
            listBox_songs.SetSelected(newIndex, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveItem(-1, listBox_songs);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveItem(1, listBox_songs);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
