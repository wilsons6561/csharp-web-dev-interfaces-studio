using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public class BaseDisc
    {
        public string Name { get; set; }
        public string Contents { get; set; }

        public string DiscType { get; set; }

        public int StorageCapacity { get; set; } = 200;

        public BaseDisc (string name, string contents, string discType, int storageCapacity)
        {
            Name = name;
            Contents = contents;
            DiscType = discType;
            StorageCapacity = storageCapacity;
        }

    
        public void PlayDisc()
        {
            Console.WriteLine("The disc will be played");
        }
    }
}
