using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Graph;
using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Models
{
    [Table("tb_M_TicketRequest")]
    public class TicketRequest
    {
        [Key]
        public  int IDTicket { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int IDStat { get; set; }
        public string NIK { get; set; }

        [JsonIgnore]
        public virtual ICollection<Status> Statuses{ get; set; }
        [JsonIgnore]
        public virtual Chat Chat { get; set; }
        [JsonIgnore]
        public virtual Employee Employee { get; set; }
    }
}
