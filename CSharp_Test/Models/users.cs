﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSharp_Test.Models
{
    public partial class users
    {
        public users()
        {
            apply_file = new HashSet<apply_file>();
        }

        [Key]
        public Guid id { get; set; }
        public Guid org_id { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? birthday { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string email { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string account { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string password { get; set; }
        public int? status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? created_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? updated_at { get; set; }

        [ForeignKey("org_id")]
        [InverseProperty("users")]
        public virtual orgs org { get; set; }
        [InverseProperty("user")]
        public virtual ICollection<apply_file> apply_file { get; set; }
    }
}