using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Windows;

namespace Flight_Inspection_App
{

    public class Client
    {
        private readonly TcpClient _client;
        private NetworkStream _ns;
        bool isRunning = false;
        public Client()
        {
            _client = new TcpClient(AddressFamily.InterNetwork);
        }

        public void Connect(string ip, int port)
        {
            try
            {
                _client.Connect(IPAddress.Parse(ip), port);
                _ns = _client.GetStream();
                IsConnected = true;
            }
            catch
            {
                Debug.WriteLine("Connect Error");
                MessageBox.Show("Connection error!");
            }

        }
        public NetworkStream GetNs()
        {
            return _ns;
        }

        public void Disconnect()
        {
            _ns.Close();
            _client.Close();
            IsConnected = false;
        }


        public void SetStatus(bool val)
        {
            isRunning = val;
        }
        public bool GetStatus()
        {
            return isRunning;
        }
        public bool IsConnected
        {
            get; set;
        }


    }
}
