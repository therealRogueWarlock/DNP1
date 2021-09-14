using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ex3_Echo_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("server starting");

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(ip, 5000);
            tcpListener.Start();

            Console.WriteLine("TcpListener started");

            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();

                Console.WriteLine($"Client{client} has connected");

                HandleClient(client);

            }
        }

        static void HandleClient(TcpClient client)
        {
            string dataFromClient = "";
            NetworkStream stream = client.GetStream();


            while (!dataFromClient.Equals("quit!"))
            {

                // read from client
                byte[] clientDataContainer = new byte[1024];
                int bytesRead = stream.Read(clientDataContainer, 0, clientDataContainer.Length);
                dataFromClient = Encoding.ASCII.GetString(clientDataContainer, 0, bytesRead);
                Console.WriteLine(dataFromClient);


                // responding to client
                byte[] responseDataContainer = Encoding.ASCII.GetBytes($"Returning {dataFromClient}");
                stream.Write(responseDataContainer, 0, responseDataContainer.Length);
                //

            }

            client.Close();

        }


    }

}