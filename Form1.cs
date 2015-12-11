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

namespace LabSix
{
    public partial class Form1 : Form
    {
        const char DELIM = ',';
        public Form1()
        {
            InitializeComponent();
        }

        private void backgrounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = backgrounds.SelectedItem.ToString();
            object selectedItem = backgrounds.SelectedItem;

            this.BackColor = Color.FromName(color);

            foreach (int lastCheckedItem in backgrounds.CheckedIndices)
            {
                if (lastCheckedItem != backgrounds.SelectedIndex)
                {
                    backgrounds.SetItemCheckState(lastCheckedItem, CheckState.Unchecked);
                }
            }
        }

        private void sizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = sizes.SelectedItem;

            if (sizes.SelectedIndex == 0)
            {
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }

            else if (sizes.SelectedIndex == 1)
            {
                this.Width = 557;
                this.Height = 300;
            }

            else if (sizes.SelectedIndex == 2)
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width / 2;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
            }

            foreach (int lastCheckedItem in sizes.CheckedIndices)
            {
                if (lastCheckedItem != sizes.SelectedIndex)
                {
                    sizes.SetItemCheckState(lastCheckedItem, CheckState.Unchecked);
                }
            }
        }

        private void titles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = titles.SelectedItem.ToString();

            foreach (int lastCheckedItem in titles.CheckedIndices)
            {
                if (lastCheckedItem != titles.SelectedIndex)
                {
                    titles.SetItemCheckState(lastCheckedItem, CheckState.Unchecked);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //open file named "Lab5Settings.txt" from current directory
            FileStream file = new FileStream("Lab5Settings.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            //read from this file
            string recordIn;
            string[] settings;

            recordIn = reader.ReadLine();
            settings = recordIn.Split(DELIM);

            //back color change
            this.BackColor = Color.FromName(settings[0]);

            //window size change
            if (settings[1] == "Fullscreen")
                this.Bounds = Screen.PrimaryScreen.Bounds;

            else if (settings[1] == "Normal")
            {
                this.Width = 557;
                this.Height = 300;
            }

            else if (settings[1] == "Halfscreen")
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width / 2;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
            }

            //form title change
            this.Text = settings[2];

            saveBtn.Enabled = false;

            reader.Close();
            file.Close();
        }
    }
}
