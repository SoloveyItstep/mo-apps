using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo_apps.entity.Entity
{
    public class User
    {
        [Key]
        public Int32 UserId { get; set; }

        [Required]
        [StringLength(20)]
        public String Nickname { get; set; }

        [Required]
        [StringLength(30)]
        public String FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public String LastName { get; set; }

        public DateTime Birthday { get; set; }

        public Int32 Rank { get; set; }

        public virtual IEnumerable<Points> Points { get; set; }

        public virtual IEnumerable<Honor> Honors { get; set; }
    }
}
