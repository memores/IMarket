using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IMarket.Model
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        public int Amount { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
    }
}
