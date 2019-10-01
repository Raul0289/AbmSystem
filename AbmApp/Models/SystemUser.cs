using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbmApp.Models
{
    public class SystemUser
    {
        public int systemUserId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string roleName { get; set; }
    }
}