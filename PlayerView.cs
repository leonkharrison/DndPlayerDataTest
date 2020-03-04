using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndPlayerDataTest
{
    public partial class PlayerView : Form
    {
        PlayerInfo info;
        ProfileSelect parent;
        private string OldName;
        public PlayerView(ProfileSelect profileSelect, PlayerInfo playerInfo)
        {
            InitializeComponent();
            info = playerInfo;
            parent = profileSelect;
            ShowInfo();
        }

        private void ShowInfo()
        {
            tbName.Text = info.PlayerName;
            OldName = info.PlayerName;
            tbClass.Text = info.PlayerClass;
            tbAlignment.Text = info.PlayerAlignment;
            tbRace.Text = info.PlayerRace;
            tbXP.Text = info.PlayerXP.ToString();
        }

        private void AppendNewInfo()
        {
            info.PlayerName = tbName.Text.Trim();
            info.PlayerClass = tbClass.Text.Trim();
            info.PlayerAlignment = tbAlignment.Text.Trim();
            info.PlayerRace = tbRace.Text.Trim();
            info.PlayerXP = int.Parse(tbXP.Text.Trim());
        }

        private void SaveNewInfo()
        {
            directoryInfo = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}Player profiles");
            if (File.Exists(directoryInfo.FullName + Path.DirectorySeparatorChar + OldName + ".plyr"))
            {
                File.Delete(directoryInfo.FullName + Path.DirectorySeparatorChar + OldName + ".plyr");
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(directoryInfo.FullName + Path.DirectorySeparatorChar + info.PlayerName + ".plyr");
                bf.Serialize(file, info);
                file.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).ReadOnly = false;
                    }
                }
                btnEdit.Text = "Finished";
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).ReadOnly = true;
                    }
                }

                AppendNewInfo();
                SaveNewInfo();

                btnEdit.Text = "Edit";
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

        private void PlayerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.GetProfiles();
            parent.Show();
        }
    }
}
