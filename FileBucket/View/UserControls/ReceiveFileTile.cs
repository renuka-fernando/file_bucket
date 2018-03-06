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
    public partial class ReceiveFileTile : UserControl {
        private ReceiveFileService _service;
        private String _filePath;
        private long _fileSize;

        internal ReceiveFileService Service {
            set {
                _service = value;
                FilePath = _service.FilePath;
                FileSize = _service.FileSize;
                _service.ReceiveFileAsync();
                _service.Connect += new ConnectEventHandler(ConnectionHandler);
                _service.FileReceiveProgress += new FileProgressEventHandler(FileProgressHandler);
            }
        }

        public String FilePath {
            get { return _filePath; }
            set {
                _filePath = value;
                this.Invoke(new Action(()=> filePathTextBox.Text = _filePath));
            }
        }

        public long FileSize {
            get {
                return _fileSize;
            }

            private set {
                _fileSize = value;

                this.Invoke(new Action(() => {
                    int unit = (int)(value / 1024);
                    if (unit == 0) fileSizeLabel.Text = value.ToString("N3") + " B";
                    else if (unit < 1024) fileSizeLabel.Text = (value / 1024.0).ToString("N3") + " KB";
                    else if (unit < 1024 * 1024) fileSizeLabel.Text = (value / 1024.0 / 1024.0).ToString("N3") + " MB";
                    else fileSizeLabel.Text = (value / 1024.0 / 1024.0 / 1024.0).ToString("N3") + " GB";
                }));
            }
        }

        public ReceiveFileTile() {
            InitializeComponent();
        }

        private void ConnectionHandler(Connection connection) {
            if (connection == Connection.Connecting) {
                ConnectLabel.Text = "Connecting...";
                ConnectLabel.ForeColor = Color.Orange;
            } else if (connection == Connection.Successful) {
                ConnectLabel.Text = "Connected";
                ConnectLabel.ForeColor = Color.Green;
                FileSize = _service.FileSize;
                FilePath = _service.FilePath;
            }
        }

        private void FileProgressHandler(double progress) {
            this.Invoke(new Action(()=> {
                this.fileProgressBar.Value = (int)(progress * 100);
            }));
            
        }
    }
}
