using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Models
{
    [Table("tb_M_Chats")]
    public class Chat
    {
        [Key]
        public int ChatID { get; set; }
        public int IDTicket { get; set; }
        public string IDCS { get; set; }

        [JsonIgnore]
        public virtual TicketRequest TicketRequest { get; set; }
        [JsonIgnore]
        public virtual Account Account { get; set; }
        [JsonIgnore]
        public virtual ICollection<ChatDetail> ChatDetails { get; set; }
    }
}
