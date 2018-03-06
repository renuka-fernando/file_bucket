using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBucket.View.Dialog {
    public partial class FileListDialog : Form {
        private static FileListDialog dialog;
        public FileListDialog() {
            InitializeComponent();
        }

        public static void ShowDialogFB(IWin32Window owner) {
            dialog = new FileListDialog();
            dialog.ShowDialog(owner);
        }
    }
}
