using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        void SpinDisc();

        void DataStorage();

        void DataReadByLaser();

        void ReportInformation();
    }
}
