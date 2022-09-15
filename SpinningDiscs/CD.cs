using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(string name, string contents, string discType, int storageCapacity) : base(name, contents, discType, storageCapacity)
        {
        }

        public void DataReadByLaser()
        {
            Console.WriteLine("The CD is read by a specific CD laser");
        }

        public void DataStorage()
        {
            Console.WriteLine("CD stores 200");
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
            Console.WriteLine("A CD spins at a rate of 200-500rpm");
        }
    }
}
