using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Models
{
    [Table("tb_Tr_Status")]
    public class Status
    {
        [Key]
        public int IDStat { get; set; }
        public string Detail { get; set; }

        [JsonIgnore]
        public virtual ICollection<TicketRequest> TicketRequests { get; set; }
    }
}
