using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
        public bool IsRead { get; set; }
        public bool IsWebHook { get; set; }
        [MaxLength(20)]
        public string From { get; set; }
        [MaxLength(20)]
        public string To { get; set; }
        public string FriendlyName { get; set; }
        [MaxLength(40)]
        public string AccountSid { get; set; }
        public string FromCity { get; set; }
        public string FromState { get; set; }
        public string FromZip { get; set; }
        public string FromCountry { get; set; }
        public string ToCity { get; set; }
        public string ToState { get; set; }
        public string ToZip { get; set; }
        public string ToCountry { get; set; }
        public string SmsSid { get; set; }
        public string Body { get; set; }
        public string MessageStatus { get; set; }
        [MaxLength(3)]
        public string TypeMessage { get; set; }
        public string MediaUrl { get; set; }
        public string Price { get; set; }
        public bool IsError { get; set; }
        public string Error { get; set; }
    }
}
