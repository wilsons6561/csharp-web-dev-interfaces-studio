using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD Rumours = new CD("Rumours", "album", "CD", 200);
            DVD KillBill = new DVD("Kill Bill", "movie", "DVD", 400);

            Rumours.DataReadByLaser();
            KillBill.DataReadByLaser();

            Rumours.ReportInformation();
            KillBill.ReportInformation();

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
