using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaRenamer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (WorkingDirectory.Text != "")
            {
                dlg.SelectedPath = WorkingDirectory.Text;
            }
            dlg.ShowDialog();
            if (dlg.SelectedPath != "")
            {
                WorkingDirectory.Text = dlg.SelectedPath;
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(WorkingDirectory.Text);

            FileInfo[] files = di.GetFiles();

            foreach (FileInfo fi in files)
            {
                string filename = fi.Name;
                string path = di.FullName;

                if (AddText.Checked)
                {
                    filename = AddTextValue.Text + filename;
                }

                if (RemoveText.Checked && TextValues.Items.Count > 0)
                {
                    foreach (string value in TextValues.Items)
                    {
                        filename = filename.Replace(value, "");
                    }
                }

                if (ReplaceText.Checked)
                {
                    filename = filename.Replace(ReplaceFrom.Text, ReplaceTo.Text);
                }

                if (KillHyphens.Checked)
                {
                    filename = filename.Replace("-", "");
                } 
                
                if (ReplaceSpaces.Checked)
                {
                    filename = filename.Replace(" ", ".");
                }

                if (RemoveDoubleDot.Checked)
                {
                    while (filename.Contains(".."))
                    {
                        filename = filename.Replace("..", ".");
                    }
                }

                fi.MoveTo(path + "\\" + filename);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (TextValue.Text != "" && !TextValues.Items.Contains(TextValue.Text))
            {
                TextValues.Items.Add(TextValue.Text);
                TextValue.Text = "";
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (TextValues.SelectedItem != null)
            {
                TextValues.Items.Remove(TextValues.SelectedItem);
            }
        }
    }
}
