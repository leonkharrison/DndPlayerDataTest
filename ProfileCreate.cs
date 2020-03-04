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
    public partial class ProfileCreate : Form
    {
        PlayerInfo playerInfo;
        public ProfileCreate()
        {
            InitializeComponent();
            directoryInfo = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}Player profiles");
        }

        private void ProfileCreate_Load(object sender, EventArgs e)
        {

        }

       

        private void btnFinished_Click(object sender, EventArgs e)
        {
            #region Disable textboxes
            tbName.Enabled = false;
            tbAlignment.Enabled = false;
            tbClass.Enabled = false;
            tbXP.Enabled = false;
            tbRace.Enabled = false;
            #endregion

            if (!File.Exists(directoryInfo.FullName + Path.DirectorySeparatorChar + tbName.Text.Trim() + ".plyr") && !string.IsNullOrWhiteSpace(tbName.Text))
            {
                // Character is new
                #region Assign character info
                playerInfo = new PlayerInfo();
                playerInfo.PlayerName = tbName.Text.Trim();
                playerInfo.PlayerXP = int.Parse(tbXP.Text.Trim());
                playerInfo.PlayerClass = tbClass.Text.Trim();
                playerInfo.PlayerAlignment = tbAlignment.Text.Trim();
                playerInfo.PlayerRace = tbRace.Text.Trim();
                #endregion

                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(directoryInfo.FullName + Path.DirectorySeparatorChar + tbName.Text.Trim() + ".plyr");
                bf.Serialize(file, playerInfo);
                file.Close();



                this.Close();
            }
            else
            {
                MessageBox.Show("A character with that name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            #region Enable textboxes
            tbName.Enabled = true;
            tbAlignment.Enabled = true;
            tbClass.Enabled = true;
            tbXP.Enabled = true;
            tbRace.Enabled = true;
            #endregion
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
    }
}
