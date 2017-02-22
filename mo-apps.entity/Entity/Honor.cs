using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo_apps.entity.Entity
{
    public class Honor
    {
        [Key]
        public Int32 HonorId { get; set; }

        public String Title { get; set; }

        public String ImagePath { get; set; }

        public Int32 UserId { get; set; }
        public virtual User User { get; set; }
    }
}
