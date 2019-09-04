using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CellWar.Utils;
using System.IO;
using CellWar.GameData;
using ZTn.Json.Editor.Forms;
using System.Diagnostics;
using HeyRed.MarkdownSharp;
using System.Net;

namespace PetriDish.App {
    public partial class MainForm : Form {
        public static string ProjectDirectoryInfoPath = Path.Combine( Directory.GetCurrentDirectory(), "data\\project_dir.json" );
        public static string ReadmePath = Path.Combine( Directory.GetCurrentDirectory(), "data\\readmeurl.txt" );

        public MainForm() {
            InitializeComponent();
        }

        private void setProjectDirectoryToolStripMenuItem_Click( Object sender, EventArgs e ) {
            using( SetProjectDirectoryForm form = new SetProjectDirectoryForm() ) {
                form.ShowDialog();
            }
        }

        string GetFileName( string fullPath ) { return System.IO.Path.GetFileNameWithoutExtension( fullPath ); }

        private void FeedMenuItem( ToolStripMenuItem parent, string _path, string extension, EventHandler clickEvt ) {
            foreach( var path in ProjectDirectoryHelper.GetSpecificFilePaths( _path, extension ) ) {
                var menuItem = new KeyValueToolStripMenuItem( GetFileName( path ) );
                menuItem.Click += clickEvt;
                menuItem.Value = path;
                parent.DropDownItems.Add( menuItem );
            }
        }

        private void CheckProjectDirectory() {
            string invalidDir = "";
            ProjectDirectoryHelper.IsProjectDirectory( ref invalidDir );
            if( invalidDir != "" ) {
                MessageBox.Show( "Invalid Directory of Project.\n Please Specific Project Directory First." );
                using( SetProjectDirectoryForm form = new SetProjectDirectoryForm() ) {
                    form.ShowDialog();
                }
            }
        }

        private string fetchRawFromHttp() {
            string urlAddress = File.ReadAllText( ReadmePath );
            string data = "";

            HttpWebRequest request = ( HttpWebRequest )WebRequest.Create( urlAddress );
            HttpWebResponse response = ( HttpWebResponse )request.GetResponse();

            if( response.StatusCode == HttpStatusCode.OK ) {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if( response.CharacterSet == null ) {
                    readStream = new StreamReader( receiveStream );
                } else {
                    readStream = new StreamReader( receiveStream, Encoding.GetEncoding( response.CharacterSet ) );
                }

                    data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            return data;
        }

        private void MainForm_Load( Object sender, EventArgs e ) {
            ProjectDirectoryHelper.ProjectDir = JsonHelper.Json2Object_NT<ProjectDirectoryModel>( ProjectDirectoryInfoPath );
            ProjectDirectoryHelper.DeductDirectories();

            CheckProjectDirectory();

            FeedMenuItem( openProjectSceneToolStripMenuItem, ProjectDirectoryHelper.ProjectDir.Scene, "*.unity", SceneMenuItem_Click );
            FeedMenuItem( gameDataToolStripMenuItem1, ProjectDirectoryHelper.ProjectDir.GameData, "*.json", JsonMenuItem_Click );
            FeedMenuItem( saveToolStripMenuItem1, ProjectDirectoryHelper.ProjectDir.Save, "*.json", JsonMenuItem_Click );
            FeedMenuItem( languageToolStripMenuItem1, ProjectDirectoryHelper.ProjectDir.Lan, "*.json", JsonMenuItem_Click );

            Markdown md = new Markdown();
            webBrowser1.DocumentText = md.Transform( fetchRawFromHttp() );

            try {
                Local.LoadAllCodingGenes();
                Local.LoadAllChemicals();
                Local.LoadAllRegulartoryGenes();
                Local.LoadAllRaces();
            } catch( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
            try {
                Save.LoadAllStrains();
            } catch( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
        }

        #region >>>>>>>>>>>>>>>>>>> EVENTS

        private void JsonMenuItem_Click( Object sender, EventArgs e ) {
            OpenJsonFile( ( sender as KeyValueToolStripMenuItem ).Value );
        }

        private void SceneMenuItem_Click( Object sender, EventArgs e ) {
            var obj = sender as KeyValueToolStripMenuItem;
            Process.Start( obj.Value );
        }

        private void backgroundWorker1_DoWork( Object sender, DoWorkEventArgs e ) {

        }

        private Stream stringToStream( string text ) {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter( stream );
            writer.Write( text );
            writer.Flush();
            return stream;
        }

        private void OpenJsonFile( string path ) {
            JsonEditorMainForm form = new JsonEditorMainForm();
            form.OpenWithFile( path );
            form.Show();
        }

        private void OpenJsonFile( Stream stream, string path ) {
            JsonEditorMainForm form = new JsonEditorMainForm();
            form.OpenWithStream( stream, path );
            form.Show();
        }

        private void exitToolStripMenuItem_Click( Object sender, EventArgs e ) {
            Application.Exit();
        }
        
        private void openProjectSceneToolStripMenuItem_Click( Object sender, EventArgs e ) {
        }

        private void openProjectGithubPageToolStripMenuItem_Click( Object sender, EventArgs e ) {
            Process.Start( "https://github.com/bennycui99/Cellwar.Game" );
        }

        private void openProjectFolderToolStripMenuItem_Click( Object sender, EventArgs e ) {
        }

        private void rootToolStripMenuItem_Click( Object sender, EventArgs e ) {
            Process.Start( ProjectDirectoryHelper.ProjectDir.Basic );
        }

        private void assestToolStripMenuItem_Click( Object sender, EventArgs e ) {
            Process.Start( ProjectDirectoryHelper.ProjectDir.Assest );
        }

        private void gameDataToolStripMenuItem1_Click( Object sender, EventArgs e ) {

        }
        #endregion

        private void withPowerShellToolStripMenuItem_Click( Object sender, EventArgs e ) {
            Process.Start( "powershell" );
        }

        private void aboutToolStripMenuItem_Click( Object sender, EventArgs e ) {
            MessageBox.Show( "Petri-Dish - Project Manager for CellWar.Game", "v0.0.1a" );
        }
    }
}
