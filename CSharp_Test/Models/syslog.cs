﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSharp_Test.Models
{
    public partial class syslog
    {
        [Key]
        public int seq_no { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string account { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ipaddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? login_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? created_at { get; set; }
    }
}