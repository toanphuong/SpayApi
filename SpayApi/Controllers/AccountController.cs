using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SpayApi.Models;

namespace SpayApi.Controllers
{
    public class AccountController : ApiController
    {
        readonly Account[] accounts = new Account[]
        {
            new Account()
            {
                AccountId = Guid.NewGuid().ToString(),
                MobileNumber = "0912176133",
            },

            new Account()
            {
                AccountId = Guid.NewGuid().ToString(),
                MobileNumber = "0982186599",
            },
            new Account()
            {
                AccountId = Guid.NewGuid().ToString(),
                MobileNumber = "01882318886",
            },
        };

        public IEnumerable<Account> GetAccounts()
        {
            return accounts;
        }

        public IHttpActionResult GetAccount(string id)
        {
            var account = accounts.FirstOrDefault((a) => a.AccountId.ToString() == id);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }
    }
}
