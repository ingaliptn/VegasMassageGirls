using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Models
{
    //public class MailModel
    //{
    //    public string Smtp { get; set; } = "a2plcpnl0183.prod.iad2.secureserver.net";
    //    public int Port { get; set; } = 587;
    //    public bool IsEnableSsl { get; set; } = true;
    //    public bool IsUseDefaultCredentials { get; set; }
    //    public string Email { get; set; } = "confirmations@suncotravel.com";
    //    public string Password { get; set; } = "sct025698!";
    //    public string FromName { get; set; } = " Vegas Stronger 587";
    //    public string FromEmail { get; set; } = "confirmations@suncotravel.com";
    //    public string ToEmail { get; set; }
    //    public string Subject { get; set; }
    //    public string Body { get; set; }
    //}
    public class MailModel
    {
        public string Smtp { get; set; } = "mx.serverpipe.com";
        public int Port { get; set; } = 25;
        public bool IsEnableSsl { get; set; } = true;
        public bool IsUseDefaultCredentials { get; set; }
        public string Login { get; set; } = "relay";
        public string Password { get; set; } = "R2020r$";
        public string FromName { get; set; } = "relay@serverpipe.com";
        public string FromEmail { get; set; } = "relay@serverpipe.com";
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
