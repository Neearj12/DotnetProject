using LMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                LMSEntities _dbcontext = new LMSEntities();
                if (_dbcontext.students.Any(s => s.Stdname == txtname.Text))
                {
                    Clear();
                    throw new Exception("Username already exists. Please choose a different username.");
                    
                }

                // Check if the email already exists
                if (_dbcontext.students.Any(s => s.Email == txtEmail.Text))
                {
                    Clear();
                    throw new Exception("Email already exists. Please use a different email address.");
                    
                }
              
                student objstudent = new student();
                objstudent.Stdname = txtname.Text;
                objstudent.Password = txtPassword.Text;
                objstudent.Email = txtEmail.Text;
                objstudent.isactive = true;

                _dbcontext.students.Add(objstudent);
                _dbcontext.SaveChanges();
            

                // Display a success message
                lblMessage.Text = "Registration successful!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Visible = true;

                // You can redirect the user to another page or perform additional actions if needed
                 Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {
                // Log the error, and display an error message
                lblMessage.Text = "Registration failed. Please try again.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Visible = true;
                Clear();
            }
        }
        protected void Clear()
        {
            txtname.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
        }
    }
}