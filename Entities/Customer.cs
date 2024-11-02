using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEvidenceApp.Entities
{
    public class Customer
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public int IQ { get; set; }
        public string Gender { get; set; }
        public bool GdprAgreement { get; set; }
    }
}
