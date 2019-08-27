﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApiExample.Data.Entities
{
    internal class Customer
    {
        [Key, Required]
        public long ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public long Mobile { get; set; }

        public virtual List<Transaction> Transactions { get; set; }
    }
}