
using LMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace LMS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {


           
            try
            {
                LMSEntities _dbcontext = new LMSEntities();
                string username = txtname.Text;
                string password = txtPassword.Text;

                // Check if the user with the provided username exists
                var user = _dbcontext.students.FirstOrDefault(s => s.Stdname == username);
                var admin = _dbcontext.Logins.FirstOrDefault(s => s.Name == username);

                


                if (user != null)
                {
                    // Verify the password (ensure proper password hashing in a real-world scenario)
                    if (user.Password == password)
                    {
                        // Login successful
                        Session["UserID"] = user.StdID; // Store UserID in session for further use
                        Response.Redirect("profile.aspx"); // Redirect to the dashboard or another secure page
                    }

                    else
                    {
                        // Incorrect password
                        lblLoginMessage.Text = "Incorrect password. Please try again.";
                        lblLoginMessage.ForeColor = System.Drawing.Color.Red;
                        lblLoginMessage.Visible = true;
                    }
                }

                else if (admin != null)
                {


                    // Verify the password (ensure proper password hashing in a real-world scenario)
                    if (admin.password == password)
                    {
                        // Login successful
                        Session["adminid"] = admin.LoginId; // Store UserID in session for further use
                        Response.Redirect("Admin/AdminHome.aspx"); // Redirect to the dashboard or another secure page
                    }

                    else
                    {
                        // Incorrect password
                        lblLoginMessage.Text = "Incorrect password. Please try again.";
                        lblLoginMessage.ForeColor = System.Drawing.Color.Red;
                        lblLoginMessage.Visible = true;
                    }
                }
                else
                {
                    // User not found
                    lblLoginMessage.Text = "User not found. Please check your username.";
                    lblLoginMessage.ForeColor = System.Drawing.Color.Red;
                    lblLoginMessage.Visible = true;
                }
            }

            catch (Exception ex)
            {
                // Log the error, and display an error message
                lblLoginMessage.Text = "Login failed. Please try again.";
                lblLoginMessage.ForeColor = System.Drawing.Color.Red;
                lblLoginMessage.Visible = true;
            }
        }
    }
}