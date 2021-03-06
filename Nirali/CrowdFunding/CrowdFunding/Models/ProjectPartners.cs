﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectPartners
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectInfoId { get; set; }
        public virtual ProjectInfo ProjectInfo { get; set; }
        [ForeignKey("UserInfo")]
        public int? PartnersUserId { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string PartnersEmailId { get; set; }
        [Required]
        public string PartnersRole { get; set; }
        public DateTime CreatedDateTime { get; set; }


    }
}