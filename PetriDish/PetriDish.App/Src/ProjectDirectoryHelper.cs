using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellWar.Utils;

namespace PetriDish.App {
    public class ProjectDirectoryModel {
        public string Basic { get; set; }
        public string GameData { get; set; }
        public string Save { get; set; }
        public string Scene { get; set; }
        public string Assest { get; set; }
        public string Lan { get; set; }
    }
    public class FileNameModel {
        public string Name { get; set; }
        public string Path { get; set; }
    }
    public static class ProjectDirectoryHelper {

        public static ProjectDirectoryModel ProjectDir { get; set; }

        public static string[] GetSpecificFilePaths( string path, string surfix ) {
            DirectoryInfo root = new DirectoryInfo( path );
            return Directory.GetFiles( path, surfix );
        }

        public static List<FileNameModel> FileNames { get; set; } = new List<FileNameModel>();

        public static FileNameModel CreateFN( string name, string path ) {
            return new FileNameModel {
                Name = name,
                Path = path
            };
        }

        public static void DeductDirectories() {
            ProjectDir.GameData = Path.Combine( ProjectDir.Basic, "CellWar.Game", "Assets", "Resources", "GameData" );
            ProjectDir.Lan = Path.Combine( ProjectDir.Basic, "CellWar.Game", "Assets", "Resources", "Lan" );
            ProjectDir.Save = Path.Combine( ProjectDir.Basic, "CellWar.Game", "Assets", "Resources", "Save" );
            ProjectDir.Scene = Path.Combine( ProjectDir.Basic, "CellWar.Game", "Assets", "Scenes" );
            ProjectDir.Assest = Path.Combine( ProjectDir.Basic, "CellWar.Game", "Assets" );
        }

        public static bool IsProjectDirectory( ref string invalidDirs ) {
            DeductDirectories();
            invalidDirs = "";
            invalidDirs += !Directory.Exists( ProjectDir.GameData ) ? ProjectDir.GameData + "\n" : "";
            invalidDirs += !Directory.Exists( ProjectDir.Basic ) ? ProjectDir.Basic + "\n" : "";
            invalidDirs += !Directory.Exists( ProjectDir.Save ) ? ProjectDir.Save + "\n" : "";
            return invalidDirs == "";
        }
    }
}
