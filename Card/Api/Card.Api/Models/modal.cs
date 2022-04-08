using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Card.Api.Models
{
    public class modal
    {
        [Key]
        public Guid id { get; set; }
        public string? CardHolderName { get; set; }
        public string? CardNumber { get; set; }
        public string? ExpMon { get; set; }
        public string? ExpYear { get; set; }
        public int CVV { get; set; }
    }
}
