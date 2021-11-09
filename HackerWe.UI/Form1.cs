using HackerWe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerWe.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Tick += (object o, EventArgs argss) =>
            {
                lblMessages.Text = "";
                timer.Stop();
            };

            Library.ReadBooksFromJSON();
            Library.ReadClientsFromJSON();
            Library.ReadBorrowingsFromJSON();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BookUserControl bookUserControl = new BookUserControl();
            panel1.Controls.Clear();
            bookUserControl.BookSaved += book =>
            {
                lblMessages.Text = $"Book {book.Name}, ID: {book.Id} was saved successfully ";
                timer.Start();
            };
            panel1.Controls.Add(bookUserControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorrowingUserControl borrowingUserControl = new BorrowingUserControl();
            panel1.Controls.Clear();
            borrowingUserControl.BorrowingSaved += (borrowing) =>
            {
                lblMessages.Text = "Borrowing saved successfully "+ borrowing.Id;
                timer.Start();
            };
            panel1.Controls.Add(borrowingUserControl);
            //borrowingUserControl.Parent = panel1;

            //borrowingUserControl.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsUserControl clientsUserControl = new ClientsUserControl();
            clientsUserControl.ClientSaved += client =>
             {
                 lblMessages.Text = $"Client {client.FullName}, ID: {client.IdentityNumber} was saved successfully ";
                 timer.Start();
             };
            clientsUserControl.ClientSaved += client =>
            {
                BorrowingUserControl borrowingUserControl = new BorrowingUserControl(client);
                panel1.Controls.Clear();
                panel1.Controls.Add(borrowingUserControl);
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(clientsUserControl);
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            SearchBooksByUserControl overdueBooksUserControl = new SearchBooksByUserControl(Library.OverdueBorrowings(6));
            panel1.Controls.Clear();
            panel1.Controls.Add(overdueBooksUserControl);
        }

        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            cmbAuthors.Visible = true;
            btnSelect.Visible = true;
            cmbAuthors.DataSource = Library.GetAuthorsList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string author = cmbAuthors.SelectedItem.ToString();
            SearchBooksByUserControl searchBooksByUserControl = new SearchBooksByUserControl(Library.BooksByAuthor(author));
            panel1.Controls.Clear();
            panel1.Controls.Add((searchBooksByUserControl));
        }
    }
}
