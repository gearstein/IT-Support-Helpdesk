using API52.Context;
using API52.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Repository.Data
{
    public class ChatDetailRepository : GeneralRepository<MyContext, ChatDetail, int>
    {
        public ChatDetailRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
