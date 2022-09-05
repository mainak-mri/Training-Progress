using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class PhotoBook
    {
        private int numPages;
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }

        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }
    }
}
