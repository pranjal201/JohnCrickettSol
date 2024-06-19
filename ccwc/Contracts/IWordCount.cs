using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccwc.Contracts
{
    public  interface IWordCount
    {
        public int CountBytes(string path);
        public int CountLines(string path);
        public int CountWords(string path);

    }
}
