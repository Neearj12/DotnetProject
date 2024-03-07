using LMS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayprofile();
         
            }

        }

        private student GetStudentByID(int studentID)
        {
            // Implement logic to query the database and return student data
            // Use the studentID to fetch the relevant student information from your database
            // Example: return yourDbContext.Students.FirstOrDefault(s => s.StudentID == studentID);
            LMSEntities _dbcontext = new LMSEntities();
            var student = _dbcontext.students.FirstOrDefault(s => s.StdID == studentID);
            // For illustration purposes, returning a dummy student
            return student;
        }


        protected void displayprofile() {

            if (Session["UserID"] == null)
            {
                // Redirect to login page if not authenticated
                Response.Redirect("Login.aspx");
            }

            // Assuming you have a StudentID stored in the session
            int studentID = Convert.ToInt32(Session["UserID"]);

            // Retrieve student data from the database
            student student = GetStudentByID(studentID);

            if (student != null)
            {
                // Display student information
                lblStudentName.Text = "Name: " + student.Stdname;
                lblStudentEmail.Text = "Email: " + student.Email;
                // Add other labels for additional information
            }
            else
            {
                // Handle the case where student data is not found

            }
        }
    

     
    }
}