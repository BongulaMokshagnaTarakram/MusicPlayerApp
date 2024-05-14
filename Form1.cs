using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Music_Player_App
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        // Global Variables of Stringtype Array to save the titles or name of the tracks
        String[] paths, files;

        private void button1_Click(object sender, EventArgs e)
        {
           //select songs button
           OpenFileDialog ofd = new OpenFileDialog();
            //multiple select
            ofd.Multiselect = true;

            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;//to save
                paths = ofd.FileNames;//to save
                    //display the music tracks
                for (int i = 0; i < files.Length; i++) 
                {
                    Songs.Items.Add(files[i]);
                }

            }
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to play music
            WindowsMediaPlayer.URL = paths[Songs.SelectedIndex];

        }

        private void WindowsMediaPlayer_Enter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //close button
            this.Close();
        }
    }
}
