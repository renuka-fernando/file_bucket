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
    public partial class ReceiveFileDialog : Form {
        private static ReceiveFileDialog dialog;
        public ReceiveFileDialog() {
            InitializeComponent();
        }

        public static String HostName {
            get {
                return dialog.hostNameTextBox.Text;
            }
            private set {
                dialog.hostNameTextBox.Text = value;
            }
        }

        public static DialogResult ShowDialogFB(IWin32Window owner) {
            dialog = new ReceiveFileDialog();
            return dialog.ShowDialog(owner);
        }
    }
}
