using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Models
{
    [Table("tb_M_Priorities")]
    public class Priority
    {
        [Key]
        public int IDPriority { get; set; }
        public string PriorityName { get; set; }
        [JsonIgnore]
        public virtual ICollection<TicketRequest> TicketRequests { get; set; }
    }
}
