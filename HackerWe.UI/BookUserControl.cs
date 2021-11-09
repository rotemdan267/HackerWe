using HackerWe.Entities;
using HackerWe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerWe.UI
{
    public partial class BookUserControl : UserControl
    {
        public event Action<Book> BookSaved;
        public BookUserControl()
        {
            InitializeComponent();
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            Book book;
            bool isValidBook = true;

            Regex nameRegex = new Regex(@"\D{2,}");
            if (!nameRegex.IsMatch(txtAuthor.Text))
            {
                lblAuthorValidation.Visible = true;
                isValidBook = false;
            }
            else lblAuthorValidation.Visible = false;
            if (!nameRegex.IsMatch(txtName.Text))
            {
                lblNameValidation.Visible = true;
                isValidBook = false;
            }
            else lblNameValidation.Visible = false;
            int nop;
            if (!int.TryParse(txtNumOfPages.Text, out nop))
            {
                lblNumOfPagesValidation.Visible = true;
                isValidBook = false;
            }
            else lblNumOfPagesValidation.Visible = false;
            short noc;
            if (!short.TryParse(txtNumOfCopies.Text, out noc))
            {
                lblNumOfCopiesValidation.Visible = true;
                isValidBook = false;
            }
            else lblNumOfCopiesValidation.Visible = false;

            if (isValidBook)
            {
                book = new Book();
                book.Id = Library.Books.Count + 1;
                book.ISBN = new Guid();
                book.Author = txtAuthor.Text;
                book.Name = txtName.Text;
                book.NumberOfPages = nop;
                book.NumberOfCopies = noc;
                book.NumberOfBorrowedOut = 0;
                book.DatePublished = dtpDatePublished.Value;
                Library.Books.Add(book);

                Library.SaveBooksAsJSON();
                BookSaved(book);
            }
            else return;
        }
    }
}
