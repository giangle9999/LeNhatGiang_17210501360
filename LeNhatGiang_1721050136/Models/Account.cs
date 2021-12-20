using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeNhatGiang_1721050136.Models
{
    
    public class Account
    {
        internal string username;
        internal string password;

        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}