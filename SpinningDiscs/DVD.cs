using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name, string contents, string discType, int storageCapacity) : base(name, contents, discType, storageCapacity)
        {
        }

        public void DataReadByLaser()
        {
            Console.WriteLine("The DVD is read by a specific DVD laser");
        }

        public void DataStorage()
        {
            Console.WriteLine("DVD stores 400");
        }

        public void ReportInformation()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Contents: " + Contents);
            Console.WriteLine("Disc Type: " + DiscType);
            Console.WriteLine("Storage Capacity: " + StorageCapacity);
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm");
        }
    }
}
