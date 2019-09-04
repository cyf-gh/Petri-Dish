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
using CellWar.Utils;

namespace PetriDish.App {
    public partial class SetProjectDirectoryForm : Form {
        public SetProjectDirectoryForm() {
            InitializeComponent();
        }

        private void btn_cancel_Click( Object sender, EventArgs e ) {
            File.WriteAllText( MainForm.ProjectDirectoryInfoPath, JsonHelper.Object2Json( ProjectDirectoryHelper.ProjectDir ) );
            Close();
        }

        private void btn_selectDirectory_Click( Object sender, EventArgs e ) {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            
            var previousPath = ProjectDirectoryHelper.ProjectDir.Basic;
            ProjectDirectoryHelper.ProjectDir.Basic = path.SelectedPath;
            string invalidDirs = "";
            
            if( !ProjectDirectoryHelper.IsProjectDirectory( ref invalidDirs ) ) {
                MessageBox.Show("Project Directory invalid.\n" + invalidDirs + "\tDoes Not Exsit", "Info");
                ProjectDirectoryHelper.ProjectDir.Basic = previousPath;
                return;
            }
            tb_directory.Text = ProjectDirectoryHelper.ProjectDir.GameData;
        }

        private void SetProjectDirectoryForm_Load( Object sender, EventArgs e ) {
            tb_directory.Text = ProjectDirectoryHelper.ProjectDir.Basic;
        }
    }
}
