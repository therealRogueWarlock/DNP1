using System;

namespace Ex2
{
    public class Patient
    {
        private int numberInQueue;
        private WaitingRoom waitingRoom;

        public Patient(WaitingRoom waitingRoom)
        {
            this.waitingRoom = waitingRoom;
            numberInQueue = waitingRoom.DrawNumber();
            Console.WriteLine($"{numberInQueue} enters the room");
            waitingRoom.NumberChange += ReactToNumber;
        }

        public void ReactToNumber(int ticketNumber)
        {

            if (ticketNumber == numberInQueue)
            {
                Console.WriteLine($"patient: {numberInQueue} im comin boii" );
                waitingRoom.NumberChange -= ReactToNumber;
                
            }
            else
            {
                Console.WriteLine($"patient: {numberInQueue} well.. ill wait then...");
            }
            
        }
    }
}