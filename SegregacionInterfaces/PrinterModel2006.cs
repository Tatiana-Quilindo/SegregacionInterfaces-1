using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfaces
{
    internal class PrinterModel2006 : IOutInformation, IScan, IRemove, ISentInformation
    {
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Photocopy()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }

        public void SentEmail()
        {
            throw new NotImplementedException();
        }

        public void SentFax()
        {
            throw new NotImplementedException();
        }
    }
}
