﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Models
{
    [Table("tb_Tr_Profilling")]
    public class Profilling
    {
        [Key]
        public string NIK { get; set; }
        public int EducationId { get; set; }
        [JsonIgnore]
        public virtual Account Account {get;set; }
        [JsonIgnore]
        public virtual TicketRequest Education { get;set;}
    }
}
