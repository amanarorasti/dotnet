using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Data
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public int TinNumber { get; set; }
    }
}
