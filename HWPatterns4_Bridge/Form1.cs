using HWPatterns4_Bridge.Abstractions;
using HWPatterns4_Bridge.Abstractions.RefinedAbstractions;
using HWPatterns4_Bridge.Clients;
using HWPatterns4_Bridge.Implementor.ConcreteImplementor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWPatterns4_Bridge
{
    public partial class Form1 : Form
    {
        List<ProductInCart> productInCart;
        Dictionary<uint, string> products;
        Dictionary<uint, decimal> prices;
        StringBuilder builder;
        PriceCalc price;
        public Form1()
        {
            InitializeComponent();
            builder = new StringBuilder();
            productInCart = new List<ProductInCart>();
            products = new Dictionary<uint, string>
            {
                [1] = "Mouse Logitech",
                [2] = "Telephone Samsung",
                [3] = "Keyboard ASUS",
                [4] = "Notebook Dell",
                [5] = "Headphones Apple"
            };
            prices = new Dictionary<uint, decimal>
            {
                [1] = 15.4m,
                [2] = 346.2m,
                [3] = 53.8m,
                [4] = 1250.9m,
                [5] = 66.5m
            };
            comboBoxSelectProduct.Text = products[1];
            comboBoxSelectProduct.Items.AddRange(products.Values.ToArray());
            comboBoxSelectProduct.SelectedItem = products[1];
            comboBoxPointOfDelivery.Text = PriceCalcShippingImpl.ShippingPrice.Keys.FirstOrDefault();
            comboBoxPointOfDelivery.Items.AddRange(PriceCalcShippingImpl.ShippingPrice.Keys.ToArray());
            comboBoxPointOfDelivery.SelectedItem = PriceCalcShippingImpl.ShippingPrice.Keys.FirstOrDefault();
            buttonRemove.Visible = false;
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            AddProduct();
            builder.Append(comboBoxSelectProduct.SelectedItem.ToString()).Append(" ").Append(numericUpDown1.Value).Append(" pcs.\n");
            listBoxCart.Items.Add(builder.ToString());
            builder.Clear();
            buttonRemove.Visible = true;

        }

        private void buttonCostOfPurchase_Click(object sender, EventArgs e)
        {
            if (radioButtonPickup.Checked)
            {
                price = new RefinedPriceCalc(new PriceCalcBaseImpl(prices));
                productInCart.ForEach(a => price.AddProduct(a.Id, a.Quantity));
                textBoxCost.Text = price.GetTotalPrice("").ToString();
            }
            else if (radioButtonToBeDelivered.Checked)
            {
                price = new RefinedPriceCalc(new PriceCalcShippingImpl(prices));
                productInCart.ForEach(a => price.AddProduct(a.Id, a.Quantity));
                textBoxCost.Text = price.GetTotalPrice(comboBoxPointOfDelivery.SelectedItem.ToString()).ToString();
            }
            productInCart.Clear();
            buttonRemove.Visible = false;
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            productInCart.Clear();
            PriceCalc.products.Clear();
            listBoxCart.Items.Clear();
            textBoxCost.Text = "";
            buttonRemove.Visible = false;
        }
        private void AddProduct()
        {
            string str = comboBoxSelectProduct.SelectedItem.ToString();
            uint key = products.Where(a => a.Value == str).FirstOrDefault().Key;
            productInCart.Add(new ProductInCart
            {
                Id = key,
                Quantity = Convert.ToUInt32(numericUpDown1.Value),
                Price = prices[key]
            });
            buttonRemove.Visible = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (productInCart.Count>0)
            {
                productInCart.RemoveAt(productInCart.Count - 1);
                listBoxCart.Items.RemoveAt(listBoxCart.Items.Count - 1);
            }
            if(productInCart.Count == 0)
                buttonRemove.Visible = false;
        }
    }
}
