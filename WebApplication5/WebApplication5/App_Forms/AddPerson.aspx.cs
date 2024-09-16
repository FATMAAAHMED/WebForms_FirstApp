using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.Models;


namespace WebApplication5.App_Forms
{
    public partial class AddPerson : System.Web.UI.Page
    {
        private readonly interviewContext _context;
        public AddPerson()
        {
             _context= new interviewContext(new DbContextOptionsBuilder<interviewContext>()
                 .UseSqlServer(ConfigurationManager.ConnectionStrings["Defaultconn"].ConnectionString).Options);
            
        }
        protected void BtnSave_Click(object sender , EventArgs e)
        {
            var person = new Person
            {
                Id=int.Parse(TxtId.Text),
                Name = TxtName.Text,
                Age= decimal.Parse(TxtAge.Text),
                NationalityId=int.Parse(TxtNat.Text),
                Birthdate=DateTime.Parse(TxtBD.Text)
            };
            _context.Person.Add(person);
            _context.SaveChanges();
            Response.Redirect("Persons.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}