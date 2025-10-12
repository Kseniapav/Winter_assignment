using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using classDish;
using UserControlCartItem;

namespace FormQuantity
{
    public partial class FormCart : Form
    {
        private List<CartItem> _cartItems;
        public FormCart(List<CartItem> cartItems)
        {
            InitializeComponent();
            _cartItems = cartItems;
            LoadCartItems();
            UpdateTotal();
        }
        private void LoadCartItems()
        {
            flowLayoutPanelCart.Controls.Clear();

            foreach (var item in _cartItems)
            {
                var card = new ControlCartItem(item);
                card.ItemRemoved += OnItemRemoved;
                card.QuantityChanged += OnQuantityChanged;
                flowLayoutPanelCart.Controls.Add(card);
            }
        }
        private void OnItemRemoved(object sender, CartItem e)
        {
            _cartItems.Remove(e);
            LoadCartItems();
            UpdateTotal();
        }
        private void OnQuantityChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = _cartItems.Sum(x => x.Total);
            lblTotal.Text = $"Общая сумма: {total:C}";
        }


        private void FormCart_Load(object sender, EventArgs e)
        {

        }
        
        
    }
}
