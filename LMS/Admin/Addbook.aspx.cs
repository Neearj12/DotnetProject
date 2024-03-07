using LMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS.Admin
{
    public partial class Addbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                string quantityText = quantity1.Text;
                string bookPriceText = price.Text;

                if (!int.TryParse(quantityText, out int quantity))
                {
                    throw new Exception("Invalid quantity. Please enter a valid integer.");
                }

                if (!int.TryParse(bookPriceText, out int bookPrice))
                {
                    throw new Exception("Invalid book price. Please enter a valid integer.");
                }

                // Your database logic
                LMSEntities _dbcontext = new LMSEntities();
                Book objbook = new Book();
                objbook.Title = title;
                objbook.Author = author;
                objbook.Quantity = quantity;
                objbook.Price = bookPrice;
                objbook.isactive = true; // Set IsActive to true
                _dbcontext.Books.Add(objbook);
                _dbcontext.SaveChanges();

                // Display success message
                lblSuccess.Text = "Book added successfully!";
                lblSuccess.Visible = true;

                // Clear input fields
                ClearInputFields();
            }
            catch (Exception ex)
            {
                // Log the error
                // Display error message
                lblError.Text = "An error occurred while adding the book. Please try again.";
                lblError.Visible = true;
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            quantity1.Text = "";
            price.Text = "0";
        }

    }
}