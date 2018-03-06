using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FileBucket.Service {

    public delegate void FileProgressEventHandler(double progress);
    public delegate void FileSharedCompleteEventHandler();
    public delegate void ConnectEventHandler(Connection connection);

    public enum Connection { Connecting, Successful}

    class FileShareService {
        private static TcpListener listner;

        public static String HostName {
            get {
                return Dns.GetHostName();
            }
        }

        public static int Port { get; private set; }

        public static void StartListener() {
            int port = config.Configuration.PORT;
            //Generate port number
            while (true) {
                try {
                    listner = new TcpListener(port);
                    listner.Start();

                    break;
                } catch (ArgumentOutOfRangeException outOfRange) {

                } catch (SocketException socketException) {
                    port++;
                }
            }
            Port = port;
        }

        public static TcpClient GetNewClient() {
            return listner.AcceptTcpClient();
        }

        public static void StopListener() {
            listner.Stop();
        }
    }
}
