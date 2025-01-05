using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS_FrontEnd.Entities
{
    internal class EDRoom
    {
        public struct BedsArray
        {
            public int bedNum;
            public bool bedState;

            public BedsArray(int bedNum, bool bedState)
            {
                this.bedNum = bedNum;
                this.bedState = bedState;
            }
            public bool GetState()
            {
                return bedState;
            }

            // Method to set a new state
            public void SetState(bool newState)
            {
                bedState = newState;
            }
        }

        private int roomNum;
        private int bedsCount;
        private BedsArray[] bedsArray;

        public EDRoom(int roomNum, int bedsNum)
        {
            this.roomNum = roomNum;
            this.bedsCount = bedsNum;
            bedsArray = new BedsArray[bedsNum];
            initializeBedsState();
        }

        public int getBedCount()
        {
            return bedsCount;
        }
        public int getRoomNum()
        {
            return roomNum;
        }

        private void initializeBedsState()
        {
            for (int i = 0; i < bedsCount; i++)
            {
                // Properly create a BedsArray struct
                bedsArray[i] = new BedsArray(i, true);
            }
        }

        public void changeBedState(int bedIndex)
        {
            if (bedIndex < 0 || bedIndex >= bedsCount)
            {
                throw new IndexOutOfRangeException("رقم سرير غير صالح");
            }

            var bed = bedsArray[bedIndex];
            bool newBedState = !bed.GetState();
            bed.SetState(newBedState);
            bedsArray[bedIndex] = bed;
        }
    }
}
