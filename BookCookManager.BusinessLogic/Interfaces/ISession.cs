using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCookManager.BusinessLogic.Core;

namespace BookCookManager.BusinessLogic.Interfaces
{
    public interface ISession : UserApi, ISession
    {
    }
}
