using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Common
{
    public class VehicleImage
    {
        public int Id { get; private set; }
        public string ImageURL { get; private set; }
        public string Description { get; private set; }
        public int Order { get; private set; }
    }
}
