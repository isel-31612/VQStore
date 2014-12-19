using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VQStore.Models
{
    [Table("VQProfile")]
    public class VQProfile
    {
        [Key]
        public int profileId { get; set; }
        public virtual UserProfile profile { get; set; }
        public virtual List<VQProject> submissions { get; set; }
        public virtual List<VQProjectView> previews { get; set; }

    }
}