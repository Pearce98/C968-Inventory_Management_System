using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace PearcePhanawongC968
{
    public class Inhouse : Part
    {

        public int machineID;
        public int MachineID
        {
            get { return machineID; }
            set { machineID = value; }
        }

        public Inhouse(int partID, string name, decimal price, int Stock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = Stock;
            Min = min;
            Max = max;
            MachineID = machineID;

        }
    }
}
