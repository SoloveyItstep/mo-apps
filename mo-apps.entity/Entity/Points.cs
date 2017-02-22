using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo_apps.entity.Entity
{
    public class Points
    {
        [Key]
        public Int32 PointsId { get; set; }
        public Int32 TotalPoints { get; set; }
        public DateTime date { get; set; }

        public Int32 UserId { get; set; }
        public User User { get; set; }
    }
}
