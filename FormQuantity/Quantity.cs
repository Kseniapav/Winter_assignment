using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardDish;
using classDish;

namespace FormQuantity
{
    public partial class Quantity : Form
    {
        private decimal pricePerItem;

        public int _Quantity { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Quantity(string lblDishName, int lblPrice)  
        {
            InitializeComponent();
            labelDishName.Text = lblDishName;
            pricePerItem = lblPrice;
            numericUpDownQuantity.Value = 1;
            UpdateTotal();
        }
        public void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }
        public void UpdateTotal()
        {
            _Quantity = (int)numericUpDownQuantity.Value;
            TotalPrice = pricePerItem * _Quantity;
            labelTotal.Text = $"Итого: {TotalPrice:C}";
        }
        public void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
