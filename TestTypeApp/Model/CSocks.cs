using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client;

namespace TestTypeApp.Model
{
    class CSocks
    {
        private int id;
        private double size;
        private Color colour;
        private CManufacture manufacture;
        private CType type;
        private List<CComposition> composition = new List<CComposition>();
    }
}
