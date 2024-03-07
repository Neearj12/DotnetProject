using LMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS.Admin
{
    public partial class Viewstd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                BindStudentData();
            }
        }
        protected void BindStudentData()
        {
            try
            {
                // Replace 'YourDbContext' with your actual DbContext class
                LMSEntities _dbcontext = new LMSEntities();

                // Assuming 'students' is the DbSet in your DbContext
                var studentData = _dbcontext.students.Select(s => new
                {
                    s.StdID,
                    s.Stdname,
                    s.Email,
                 
                }).ToList();

                GridViewStudents.DataSource = studentData;
                    GridViewStudents.DataBind();

                    // Display a success message
                    lblErrorMessage.Text = "Student data loaded successfully.";
                    lblErrorMessage.Visible = true;
                
            }
            catch (Exception ex)
            {
                // Handle exceptions, log errors, or display a user-friendly message
                // For simplicity, you can add a Label to your page for error messages
                lblErrorMessage.Text = "An error occurred while loading student data.";
                lblErrorMessage.Visible = true;
            }
        }
 

    }
}