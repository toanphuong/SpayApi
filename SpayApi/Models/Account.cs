using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SpayApi.Models
{
    public class Account
    {   
        public string AccountId { get; set; }
        
        public string Password { get; set; }

        public string AccountType { get; set; }

        public string PushToken { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string Passport { get; set; }

        public string Username { get; set; }

        public string Address { get; set; }

        public string AvatarUrl { get; set; }

        public string PinCode { get; set; }

        public long Balance { get; set; }

        public long CashBackPoint { get; set; }

        public string RefCode { get; set; }

        public int NewNotiCount { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }

        public DateTime CreateTime { get; set; }

    }
}