﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Notification
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

    }
}