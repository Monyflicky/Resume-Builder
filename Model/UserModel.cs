using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;
namespace RazorPagesResume.Model
{
     public class UserModel : EntityBase
        {
            [Required]
            public string firstName {get; set;}

            [Required]
            public string lastName {get; set;}

            [Required]
            public string profession {get; set;}

            [Required]
            public string city {get; set;}

            [Required]
            public string province {get; set;}

            [Required]
            [DataType(DataType.PostalCode)]
            public string postalcode {get; set;}

            [Required]
            [DataType(DataType.PhoneNumber)]
            public string phoneNumber {get; set;}

            [Required]
            [DataType(DataType.EmailAddress)]
            public string emailAddress {get; set;}
        }
}