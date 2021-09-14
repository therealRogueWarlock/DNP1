using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex5_Chat_program_server
{
    class Program
    {
        
        private static List<TcpClient> _clients = new();
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("server starting");

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(ip, 5000);
            tcpListener.Start();

            Console.WriteLine("TcpListener started");

            while (true) {
                TcpClient client = tcpListener.AcceptTcpClient();
                
                _clients.Add(client);
                
                Console.WriteLine($"Client{client} has connected");
                new Thread(() => HandleClient(client)).Start();
            }
            
        }

        static void HandleClient(TcpClient client)
        {
            string dataFromClient = "";

            NetworkStream stream = client.GetStream();

            while (!dataFromClient.Equals("quit"))
            {
                // read from client
                byte[] clientDataContainer = new byte[1024];
                int bytesRead = stream.Read(clientDataContainer, 0, clientDataContainer.Length);
                dataFromClient = Encoding.ASCII.GetString(clientDataContainer, 0, bytesRead);

                Console.WriteLine(dataFromClient);

                BroadCast(dataFromClient);
                
            }

            client.Close();
        }


        static void BroadCast(string message) {

            foreach (TcpClient tcpClient in _clients)
            {
                
                NetworkStream stream = tcpClient.GetStream();
                
                // responding to client
                byte[] responseDataContainer = Encoding.ASCII.GetBytes(message);
                stream.Write(responseDataContainer, 0, responseDataContainer.Length);
            }
            
        }
    }
}