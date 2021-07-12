using API52.Context;
using API52.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Repository.Data
{
    public class ChatRepository : GeneralRepository<MyContext, Chat, int>
    {
        public ChatRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
