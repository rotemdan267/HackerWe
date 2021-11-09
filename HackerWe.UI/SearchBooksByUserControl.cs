using HackerWe.Entities;
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
    public partial class SearchBooksByUserControl : UserControl
    {
        object list;
        public SearchBooksByUserControl(object list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OverdueBooksUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list;
            //dataGridView1.DataSource = Library.OverdueBorrowings(6);
        }
    }
}
