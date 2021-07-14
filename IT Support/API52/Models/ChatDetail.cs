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
    [Table("tb_M_ChatDetails")]
    public class ChatDetail
    {
        [Key]
        public int IDDetail { get; set; }
        public string Message { get; set; }
        public Date SendDate { get; set; }
        public Date UpdateDate { get; set; }
        public Time SentTime { get; set; }
        public Time UpdateTime { get; set; }
        public int ChatID { get; set; }

        [JsonIgnore]
        public virtual Chat Chat { get; set; }
      
    }
}
