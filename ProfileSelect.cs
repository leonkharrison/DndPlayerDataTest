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
using System.Runtime.Serialization.Formatters.Binary;

namespace DndPlayerDataTest
{
    public partial class ProfileSelect : Form
    {
        string[] profilefiles;
        PlayerView playerView;
        public ProfileSelect()
        {
            InitializeComponent();
            directoryInfo = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}Player profiles");
        }

        private void ProfileSelect_Shown(object sender, EventArgs e)
        {
            GetProfiles();
        }

        public void GetProfiles()
        {
            listBox1.Items.Clear();
            profilefiles = Directory.GetFiles(directoryInfo.ToString(), "*.plyr");

            foreach (string profile in profilefiles)
            {
                string[] profilepathsplit = profile.Split('\\');
                string[] profilename = profilepathsplit[profilepathsplit.Length - 1].Split('.');
                listBox1.Items.Add(profilename[0]);
            }
        }

        DirectoryInfo _outputDir = null;
        public DirectoryInfo directoryInfo
        {
            get
            {
                return _outputDir;
            }
            set
            {
                _outputDir = value;
                if (!_outputDir.Exists)
                {
                    _outputDir.Create();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string selectedplayer = (string)listBox1.SelectedItem;

            if (File.Exists(directoryInfo.FullName + Path.DirectorySeparatorChar + selectedplayer + ".plyr"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(directoryInfo.FullName + Path.DirectorySeparatorChar + selectedplayer + ".plyr", FileMode.Open);
                PlayerInfo playerInfo = (PlayerInfo)bf.Deserialize(file);
                file.Close();

                playerView = new PlayerView(this, playerInfo);
                playerView.Show();
                this.Hide();
            }
        }
    }

    
}
