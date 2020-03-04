using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndPlayerDataTest
{
    public partial class HomePage : Form
    {
        ProfileSelect profiles;
        ProfileCreate create;
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            profiles = new ProfileSelect();
            profiles.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            create = new ProfileCreate();
            create.Show();
        }
    }
}
