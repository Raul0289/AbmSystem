using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AbmDataAccess;

namespace AbmApp.Controllers
{
    public class AccountsController : ApiController
    {
        public IEnumerable<Account> Get()
        {
            using (AbmSystemEntities entities = new AbmSystemEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Accounts.ToList();
            }
        }

        public Account Get(int id)
        {
            using (AbmSystemEntities entities = new AbmSystemEntities())
            {
                return entities.Accounts.FirstOrDefault(e => e.AccountId == id);
            }   
        }
    }
}
