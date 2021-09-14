using System;
using System.Net.Sockets;
using System.Text;

namespace Ex3_Echo_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client");
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            NetworkStream stream = client.GetStream();
            
            string input = "";
            
            while (true) {
           
                input = Console.ReadLine();
                if (input.Equals("quit") ) break;
              
                byte[] dataToServer = Encoding.ASCII.GetBytes(input);
                stream.Write(dataToServer,0,dataToServer.Length);
                
                byte[] dataFromServerContainer = new byte[1024];
                int bytesRead = stream.Read(dataFromServerContainer, 0, dataFromServerContainer.Length);
                string serverResonse = Encoding.ASCII.GetString(dataFromServerContainer, 0, bytesRead);

                Console.WriteLine(serverResonse);
            }
            
            stream.Close();
            client.Close();
            
        }
    }
}