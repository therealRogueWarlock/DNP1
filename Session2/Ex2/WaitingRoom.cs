using System;
using System.Threading;

namespace Ex2
{
    public class WaitingRoom
    {
        public Action<int> NumberChange { get; set; }

        private int currentNumber;
        private int ticketCount;

        public WaitingRoom()
        {
            currentNumber = 0;
            ticketCount = 0;
        }

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {

                Console.WriteLine("ding");                    
                currentNumber++;
                NumberChange?.Invoke(currentNumber);
                Thread.Sleep(5000);

            }
            
        }

        public int DrawNumber()
        {
            
            return ++ticketCount;
        }
    }
}