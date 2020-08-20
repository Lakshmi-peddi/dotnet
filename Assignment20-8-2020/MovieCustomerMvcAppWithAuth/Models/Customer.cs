using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCustomerMvcAppWithAuth.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}",
                ApplyFormatInEditMode = true)]
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
    }
}