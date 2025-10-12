using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using FormQuantity;
using CulinaryDictionary;

namespace UserControlCartItem
{
    public partial class UserControl1: UserControl
    {
        private CartItem _item;

        public event EventHandler<CartItem> ItemRemoved;
        public event EventHandler QuantityChanged;

        public UserControl1()
        {
            InitializeComponent();
            _item = item;
            pictureBox.Image = _item.DishImage;
            lblName.Text = _item.DishName;
            lblPrice.Text = $"{_item.Price:C} за шт.";
            numericQuantity.Value = _item.Quantity;
            UpdateTotal();
        }
        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            _item.Quantity = (int)numericQuantity.Value;
            UpdateTotal();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateTotal()
        {
            lblTotal.Text = $"Итого: {_item.Total:C}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ItemRemoved?.Invoke(this, _item);
        }

        public bool IsSelected => checkSelect.Checked;  

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
