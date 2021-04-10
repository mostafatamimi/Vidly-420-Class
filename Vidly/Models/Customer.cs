using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Id { get; set; }

        public bool? IsSubscribedToNewsletter { get; set; }

        // This is the foreign key connecting the two models in the DB
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}