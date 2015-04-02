using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMAWeb.DTO
{
    public class MemberModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}