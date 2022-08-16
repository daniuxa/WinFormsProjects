using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class CartForm : Form
    {
        private Cart cart;
        public CartForm(ref Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ListViewItem item = null;
            foreach (var book in cart.books)
            {
                item = new ListViewItem(new string[] { book.Name, book.Author.Name + " " + book.Author.Surname, Convert.ToString(book.PublicationYear), Convert.ToString(book.Price), book.Genre });
                CartListView.Items.Add(item);           
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Book bookRemove;
            if (cart.Count() != 0)
            {
                if (CartListView.SelectedItems.Count == 1)
                {
                    bookRemove = cart.books[CartListView.SelectedItems[0].Index];
                    cart.Remove(bookRemove);                  
                }
                CartListView.Items.Clear();
                ListViewItem item = null;
                foreach (var book in cart.books)
                {
                    item = new ListViewItem(new string[] { book.Name, book.Author.Name + " " + book.Author.Surname, Convert.ToString(book.PublicationYear), Convert.ToString(book.Price), book.Genre });
                    CartListView.Items.Add(item);
                }
            }
        }

        private void ContinuePurchaseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (cart.Count() != 0)
            {
                this.Visible = false;
                ClientInfoEntry form = new ClientInfoEntry(cart);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Корзина пуста");
            }
        }
    }
}
