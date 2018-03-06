using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileBucket.Service;

namespace FileBucket.View.UserControls {
    public partial class SendFileTile : UserControl {

        private SendFileService _service;
        private String _filePath;
        private long _fileSize;

        internal SendFileService Service {
            set {
                _service = value;
                FilePath = _service.FilePath;
                FileSize = _service.FileSize;
                _service.StartListening();
                _service.Connect += new ConnectEventHandler(ConnectionHandler);
                _service.FileSendProgress += new FileProgressEventHandler(FileProgressHandler);
            }
        }

        public String FilePath {
            get { return _filePath; }
            set {
                _filePath = value;
                filePathTextBox.Text = _filePath;
            }
        }

        public long FileSize {
            get {
                return _fileSize;
            }

            private set {
                _fileSize = value;

                int unit = (int)(value / 1024);
                if (unit == 0) fileSizeLabel.Text = value.ToString("N3") + " B";
                else if (unit < 1024) fileSizeLabel.Text = (value / 1024.0).ToString("N3") + " KB";
                else if (unit < 1024 * 1024) fileSizeLabel.Text = (value / 1024.0 / 1024.0).ToString("N3") + " MB";
                else fileSizeLabel.Text = (value / 1024.0 / 1024.0 / 1024.0).ToString("N3") + " GB";
            }
        }

        public SendFileTile() {
            InitializeComponent();
        }

        private void ConnectionHandler(Connection connection) {
            this.Invoke(new Action(() => {
            if (connection == Connection.Connecting) {
                ConnectLabel.Text = "Connecting...";
                ConnectLabel.ForeColor = Color.Orange;
            } else if (connection == Connection.Successful) {
                ConnectLabel.Text = "Connected";
                ConnectLabel.ForeColor = Color.Green;
                _service.SendFileAsync();
            }
            }));
            
        }

        private void FileProgressHandler(double progress) {
            this.Invoke(new Action(() =>{
                this.fileProgressBar.Value = (int)(progress * 100);
            }));
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            statusLabel.Text = "Canceled";
            statusPanel.Visible = true;
            _service.CancelSending();
        }
    }
}
