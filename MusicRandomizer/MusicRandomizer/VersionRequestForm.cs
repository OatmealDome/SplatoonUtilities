using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRandomizer
{
    public partial class VersionRequestForm : Form
    {
        public SplatoonRegion chosenRegion;

        public VersionRequestForm()
        {
            InitializeComponent();
        }

        private void VersionRequestForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!radNorthAmerica.Checked && !radEurope.Checked && !radJapan.Checked)
            {
                MessageBox.Show("Please choose a region.");
                return;
            }

            if (Directory.Exists("other_files"))
            {
                MessageBox.Show("The files inside other_files will be moved to a new folder called cafiine_root.");
            }

            if (radNorthAmerica.Checked)
            {
                chosenRegion = SplatoonRegion.NorthAmerica;
            }
            else if (radEurope.Checked)
            {
                chosenRegion = SplatoonRegion.Europe;
            }
            else
            {
                chosenRegion = SplatoonRegion.Japan;
            }

            this.Close();
        }
    }
}
