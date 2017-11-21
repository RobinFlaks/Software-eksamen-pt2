using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
    static class Bazzar
    {
        public static Boolean Finished;
        public static int ItemNumber;
        public static Boolean ItemAvailable;

        public static void SetFinished(Boolean Finished)
        {
            Bazzar.Finished = Finished;
        }

        public static void SetItemNumber(int ItemNumber)
        {
            Bazzar.ItemNumber = ItemNumber;
        }

        public static void SetItemAvailable(Boolean ItemAvailable)
        {
            Bazzar.ItemAvailable = ItemAvailable;
        }

        public static Boolean GetFinished()
        {
            return Finished;
        }

        public static int GetItemNumber()
        {
            return ItemNumber;
        }

        public static Boolean GetItemAvailable()
        {
            return ItemAvailable;
        }
    }
}
