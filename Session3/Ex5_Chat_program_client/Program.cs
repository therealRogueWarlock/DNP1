using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex5_Chat_program_client
{
    class Program
    {

        private static NetworkStream stream;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client");
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            stream = client.GetStream();
            
            new Thread(() => ServerInputHandler()).Start();
            
            string input = "";
            
            while (true) {
           
                input = Console.ReadLine();
                if (input.Equals("quit") ) break;
              
                byte[] dataToServer = Encoding.ASCII.GetBytes(input);
                stream.Write(dataToServer,0,dataToServer.Length);
                
            }
            
            stream.Close();
            client.Close();
            
        }


        static void ServerInputHandler()
        {
            while (true)
            {
                byte[] dataFromServerContainer = new byte[1024];
                int bytesRead = stream.Read(dataFromServerContainer, 0, dataFromServerContainer.Length);
                string serverResonse = Encoding.ASCII.GetString(dataFromServerContainer, 0, bytesRead);

                Console.WriteLine(serverResonse);
            }
        }
    }
}