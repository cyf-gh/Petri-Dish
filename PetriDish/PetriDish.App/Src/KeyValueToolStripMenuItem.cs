using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetriDish.App {
    public class KeyValueToolStripMenuItem : ToolStripMenuItem {
        public KeyValueToolStripMenuItem( String text ) : base( text ) {
        }

        public string Value { get; set; }
    }
}
