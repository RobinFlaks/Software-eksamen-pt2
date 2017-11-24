using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
    public sealed class Bazzar
    {
        private Boolean Finished;
        private int ItemNumber;
        private Boolean ItemAvailable;
        private static readonly Bazzar TheBazzar = new Bazzar();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit

        static Bazzar()
        {
        }

        private Bazzar()
        {
        }

        public static Bazzar Instance
        {
            get
            {
                return TheBazzar;
            }
        }
    

        public void SetFinished(Boolean Finished)
        {
            this.Finished = Finished;
        }

        public void SetItemNumber(int ItemNumber)
        {
            this.ItemNumber = ItemNumber;
        }

        public void SetItemAvailable(Boolean ItemAvailable)
        {
            this.ItemAvailable = ItemAvailable;
        }

        public Boolean GetFinished()
        {
            return Finished;
        }

        public int GetItemNumber()
        {
            return ItemNumber;
        }

        public Boolean GetItemAvailable()
        {
            Bazzar Bazz = Bazzar.Instance;
            lock (Bazz) ;
            return ItemAvailable;
        }
    }
}
