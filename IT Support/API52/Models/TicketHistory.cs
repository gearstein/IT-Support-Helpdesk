using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Models
{
    [Table("tb_M_TicketHistory")]
    public class TicketHistory
    {
        [Key]
        public int IDHistory { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int IDTicket { get; set; }
        public int IDStat { get; set; }

        [JsonIgnore]
        public virtual TicketRequest TicketRequest { get; set; }

        [JsonIgnore]
        public virtual Status Status { get; set; }

    }
}
