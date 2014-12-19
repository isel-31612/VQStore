using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VQStore.Models
{
    [Table("VQProject")]
    public class VQProject
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long projectId { get; set; }
        public string name { get; set; }
        public virtual UserProfile owner { get; set; }
        public string description { get; set; }
        public double rating { get; set; }
        public string hostUrl { get; set; }
        public virtual VQProjectState state { get; set; }

        public virtual List<VQProjectView> downloads { get; set; }
    }
}