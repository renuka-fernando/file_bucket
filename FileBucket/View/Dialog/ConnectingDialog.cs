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
    public partial class ConnectingDialog : Form {
        private static ConnectingDialog dialog = new ConnectingDialog();
        private static IWin32Window parent;
        public ConnectingDialog() {
            InitializeComponent();
        }

        public static void showConnectingDialog(IWin32Window parent) {
            ConnectingDialog.parent = parent;
            dialog.ShowDialog(parent);
        }

        public static void hideConnectingDialog() {
            Form theParent = (Form)parent;
            theParent.Invoke(new Action(()=> dialog.Hide()));
        }
    }
}
