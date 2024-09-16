using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Linq;
using System.Web.UI.WebControls;
using WebApplication5.App_Forms;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication5.Models
{
    public partial class Person
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Age { get; set; }
        public int? NationalityId { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
