using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VQStore.Models
{
    [Table("VQProjecView")]
    public class VQProjectView
    {
        [Key]
        public long viewId { get; set; }
        public virtual VQProject project { get; set; }
        public virtual UserProfile viewer { get; set; }
        public string comment { get; set; }
        public double rating { get; set; }
    }
}