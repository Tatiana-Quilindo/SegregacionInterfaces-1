using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfaces
{
    internal class PrinterModel2004 : IOutInformation, IScan, IRemove
    {
        void IRemove.Cancel()
        {
            throw new NotImplementedException();
        }

        void IOutInformation.Photocopy()
        {
            throw new NotImplementedException();
        }

        void IOutInformation.Print()
        {
            throw new NotImplementedException();
        }

        void IScan.Scan()
        {
            throw new NotImplementedException();
        }
    }
}
