using CHS_FrontEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHS_FrontEnd
{
    public class LocalEDRooms : Form
    {
        private List<EDRoom> roomsList = new List<EDRoom>();
        public void AddNewRoom(int roomNum, int bedsCount)
        {
            roomsList.Add(new EDRoom(1, 5));
            roomsList.Add(new EDRoom(2, 3));
            roomsList.Add(new EDRoom(3, 6));
            roomsList.Add(new EDRoom(4, 8));
            roomsList.Add(new EDRoom(5, 12));
            roomsList.Add(new EDRoom(6, 1));
            roomsList.Add(new EDRoom(7, 15));
            roomsList.Add(new EDRoom(roomNum, bedsCount));
        }

        public void displayRooms()
        {
            // Create a string to hold the room details
            string roomDetails = "Rooms List:\n";

            // Iterate through the list and append each room's details
            foreach (EDRoom room in roomsList)
            {
                roomDetails += $"Room {room.getRoomNum()}: {room.getBedCount()} beds\n";
            }

            // Display the details in a message box
            MessageBox.Show(roomDetails, "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
