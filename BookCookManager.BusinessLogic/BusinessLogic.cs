using BookCookManager.BusinessLogic.Interfaces;
using BookCookManager.BusinessLogic;

namespace BookCookManager.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
