using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Envoice.Data.Models
{
    public class InvoiceModel
    {
        public int InvoiceID { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal Amount { get; set; }

        public int ClientID { get; set; }

        public string Client { get; set; }

        public string Description { get; set; }
    }
}
