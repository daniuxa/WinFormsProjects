using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLibrary
{
    public partial class CartForm : Form
    {
        Cart cart = null;
        public CartForm()
        {
            InitializeComponent();
        }
        public CartForm(ref Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            AddBookToListView(cart.books, ChangeBackGroundColor);
        }
        private void AddBookToListView(Dictionary<Book, DateTime> books, ChangeStyle changeStyleBookLines)
        {
            CartListView.Items.Clear();
            ListViewItem item = null;
            foreach (var book in books)
            {
                item = new ListViewItem(new string[] { book.Key._name, book.Key._author, book.Key._ProductionYear.ToString(), book.Key._Genre });
                changeStyleBookLines(item, Color.LightGray);
                CartListView.Items.Add(item);
            }
        }
        private void ChangeBackGroundColor(ListViewItem item, Color color)
        {
            item.SubItems[0].BackColor = color;
        }
        private void ChangeForeColor(ListViewItem item, Color color)
        {
            item.SubItems[0].ForeColor = color;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            Book bookRemove;
            if (cart.Count() != 0)
            {
                if (CartListView.SelectedItems.Count == 1)
                {
                    foreach (var book in cart.books)
                    {
                        if (i == CartListView.SelectedItems[0].Index)
                        {
                            bookRemove = book.Key;
                            cart.Remove(bookRemove);
                            break;
                        }
                        i++;
                    }
                    
                }
                AddBookToListView(cart.books, ChangeBackGroundColor);
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
                ClientInfoEntryForm form = new ClientInfoEntryForm(cart);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Корзина пуста");
            }
        }
    }
}
