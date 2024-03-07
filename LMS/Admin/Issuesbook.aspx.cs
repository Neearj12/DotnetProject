using LMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace LMS.Admin
{
    public partial class Issuesbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDropDownList01();
                PopulateDropDownList02();

            }
        }

        private void PopulateDropDownList01()
        {
            try
            {
                LMSEntities _dbcontext = new LMSEntities();

                var data = _dbcontext.students.OrderBy(m=>m.Stdname).ToList();
             

                ddlStudentID.DataSource = data;
                ddlStudentID.DataTextField = "Stdname";
                ddlStudentID.DataValueField = "StdID";
                ddlStudentID.DataBind();

                
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., logging, displaying an error message)
                lblErrorMessage.Text = "Error populating dropdown: " + ex.Message;
                lblErrorMessage.Visible = true;
            }
        }
        private void PopulateDropDownList02()
        {
            try
            {
                LMSEntities _dbcontext = new LMSEntities();

                var data = _dbcontext.Books.OrderBy(m => m.Title).ToList();


                ddlBookID.DataSource = data;
                ddlBookID.DataTextField = "Title";
                ddlBookID.DataValueField = "BookID";
                ddlBookID.DataBind();

            

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., logging, displaying an error message)
                lblErrorMessage.Text = "Error populating dropdown: " + ex.Message;
                lblErrorMessage.Visible = true;
            }
        }

        protected void btnIssueBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected values from dropdown lists
                string studentID = ddlStudentID.SelectedValue;
                string bookID = ddlBookID.SelectedValue;

                // Validate other form elements
                int quantity;
                if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
                {
                    // Handle invalid quantity
                    lblErrorMessage.Text = "Please enter a valid quantity.";
                    lblErrorMessage.Visible = true;
                    return;
                }

                DateTime issueDate;
                if (!DateTime.TryParse(txtIssueDate.Text, out issueDate))
                {
                    // Handle invalid issue date
                    lblErrorMessage.Text = "Please enter a valid issue date.";
                    lblErrorMessage.Visible = true;
                    return;
                }

                // Call the existing method to issue the book
                bool issuedSuccessfully = IssueBookToStudent(studentID, bookID, quantity, issueDate);

                if (issuedSuccessfully)
                {
                    lblSuccessMessage.Text = "Book issued successfully!";
                    lblSuccessMessage.Visible = true;
                    lblErrorMessage.Visible = false;
                    ClearFormFields();
                }
                else
                {
                    lblErrorMessage.Text = "Failed to issue the book. Please try again.";
                    lblErrorMessage.Visible = true;
                    lblSuccessMessage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions (e.g., logging, displaying an error message)
                lblErrorMessage.Text = "An error occurred. Please try again.";
                lblErrorMessage.Visible = true;
                lblSuccessMessage.Visible = false;
            }
        }

        private bool IssueBookToStudent(string studentID, string bookID, int quantity, DateTime issueDate)
        {
            try
            {
                using (LMSEntities _dbcontext = new LMSEntities())
                {
                 
                    BookIssue objbookIssue = new BookIssue
                     {
                         Stdid = Convert.ToInt32( studentID),
                         Bookid = Convert.ToInt32( bookID),
                         quantity = quantity,
                         IssueDate = issueDate,
                         isactive = true
                     };
                     _dbcontext.BookIssues.Add(objbookIssue);
                    _dbcontext.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
 
                return false;
            }
        }

        private void ClearFormFields()
        {

            ddlStudentID.SelectedIndex = 0;
            ddlBookID.SelectedIndex = 0;
            txtQuantity.Text = string.Empty;
            txtIssueDate.Text = string.Empty;
        }
    }
}
