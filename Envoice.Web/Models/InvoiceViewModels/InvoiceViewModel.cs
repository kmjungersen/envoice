using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Envoice.Web.Models.InvoiceViewModels
{
    public class InvoiceViewModel
    {
        public int InvoiceID { get; set; }

        [Display(Name = "Invoice Number")]
        public string InvoiceNumber { get; set; }

        [Required]
        [Display(Name = "Invoice Date")]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public decimal Amount { get; set; }
        
        [Required]
        public decimal ClientID {get;set;}

        [Required]
        public string Client { get; set; }

        public string DescriptionOfWork { get; set;}
    }
}
