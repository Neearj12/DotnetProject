using LMS.Model;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace LMS.Admin
{
    public partial class Viewbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call a method to bind data to the GridView
                BindBookData();
            }

            // Add event handlers
            GridViewBooks.RowEditing += GridViewBooks_RowEditing;
            GridViewBooks.RowCancelingEdit += GridViewBooks_RowCancelingEdit;
            GridViewBooks.RowUpdating += GridViewBooks_RowUpdating;

        }

        protected void BindBookData()
        {
            try
            {
                // Replace 'YourDbContext' with your actual DbContext class
                LMSEntities _dbContext = new LMSEntities();
                // Assuming 'Books' is the DbSet in your DbContext
                var booksData = _dbContext.Books.Select(b => new
                {
                    b.BookID,
                    b.Title,
                    b.Author,
                    b.Quantity,
                    b.Price,
                }).ToList();

                GridViewBooks.DataSource = booksData;
                GridViewBooks.DataBind();

                // Display a success message
                lblErrorMessage.Text = "Books loaded successfully.";
                lblErrorMessage.Visible = true;
            }
            catch (Exception ex)
            {
                // Handle exceptions, log errors, or display a user-friendly message
                // For simplicity, you can add a Label to your page for error messages
                lblErrorMessage.Text = "An error occurred while loading book data.";
                lblErrorMessage.Visible = true;
            }
        }

        protected void GridViewBooks_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewBooks.EditIndex = e.NewEditIndex;
            BindBookData();
        }

        protected void GridViewBooks_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewBooks.EditIndex = -1;
            BindBookData();
        }

        protected void GridViewBooks_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           int bookID = Convert.ToInt32( ((TextBox)GridViewBooks.Rows[e.RowIndex].Cells[0].Controls[0]).Text);
            string title = ((TextBox)GridViewBooks.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string author = ((TextBox)GridViewBooks.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            int quantity = Convert.ToInt32(((TextBox)GridViewBooks.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
            int price = Convert.ToInt32(((TextBox)GridViewBooks.Rows[e.RowIndex].Cells[4].Controls[0]).Text);

            using (LMSEntities _dbContext = new LMSEntities())
            {
                var bookToUpdate = _dbContext.Books.Find(bookID);
                if (bookToUpdate != null)
                {
                    bookToUpdate.Title = title;
                    bookToUpdate.Author = author;
                    bookToUpdate.Quantity = quantity;
                    bookToUpdate.Price = price;

                    _dbContext.SaveChanges();
                }
            }

            GridViewBooks.EditIndex = -1;
            BindBookData();
            lblUpdateSuccess.Visible = true;
        }



        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var bookid = (sender as LinkButton).CommandArgument;
            int _bookid = Convert.ToInt32(bookid);

            using (LMSEntities _dbContext = new LMSEntities())
            {
                var bookToDelete = _dbContext.Books.Find(_bookid);
                if (bookToDelete != null)
                {
                    _dbContext.Books.Remove(bookToDelete);
                    _dbContext.SaveChanges();
                }
            }

            BindBookData();
        }
    }
}
