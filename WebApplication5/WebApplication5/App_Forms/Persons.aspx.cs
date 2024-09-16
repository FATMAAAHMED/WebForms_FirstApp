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
    public partial class Persons : System.Web.UI.Page
    {
        private readonly interviewContext _context;
        public Persons()
        {
            _context = new interviewContext(new DbContextOptionsBuilder<interviewContext>()
                .UseSqlServer(ConfigurationManager.ConnectionStrings["Defaultconn"].ConnectionString).Options);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPersons();
            }

        }
        private void LoadPersons()
        {
            GridView1.DataSource = _context.Person.ToList();
            GridView1.DataBind();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPerson.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            GridView1.EditIndex=e.NewEditIndex;
            LoadPersons();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = (int)e.Keys["Id"];
            var person = _context.Person.Find(id);
            if(person != null)
            {
                person.Name=(string)e.NewValues["Name"];
                person.Age = decimal.Parse(e.NewValues["Age"].ToString());
                person.NationalityId = Convert.ToInt32(e.NewValues["NationalityId"]);
                ;
                person.Birthdate=DateTime.Parse(e.NewValues["Birthdate"].ToString());
                _context.SaveChanges();
                LoadPersons();
            }

        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id=(int)e.Keys["Id"];
            var person = _context.Person.Find(id);
            if (person != null) { 
                _context.Person.Remove(person);
                _context.SaveChanges();
                LoadPersons();
            }
        }


    }
}