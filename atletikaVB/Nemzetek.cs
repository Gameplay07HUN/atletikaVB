using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaVB
{
    internal class Nemzetek
    {
        readonly int nemzetId;
        readonly string nemzetName;

        public int NemzetId => NemzetId;
        public string NemzetName => nemzetName;

        public Nemzetek(int nemzetId, string nemzetName)
        {
            this.nemzetId = nemzetId;
            this.nemzetName = nemzetName;
        }
    }
}
