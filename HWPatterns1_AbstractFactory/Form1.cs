using HWPatterns1_AbstractFactory.Clients;
using HWPatterns1_AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWPatterns1_AbstractFactory
{
    public partial class Form1 : Form
    {
        List<string> factoryList;
        List<string> productList;
        IFactory factory1;
        IFactory factory2;
        public Form1()
        {
            InitializeComponent();
            factoryList = new List<string>();
            productList = new List<string>();
            factory1 = new AutoVazFactory();
            factory2 = new VWFactory();
            factoryList.Add(factory1.Name);
            factoryList.Add(factory2.Name);
            comboBox1.Text = factoryList[0];
            comboBox1.Items.AddRange(factoryList.ToArray());
            comboBox2.Items.AddRange(factory1.Production.ToArray());
            comboBox2.Text = factory1.Production[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            productList.Clear();
            comboBox2.Items.Clear();
            if (comboBox1.Text == factory1.Name)
            {
                productList.AddRange(factory1.Production);
                comboBox2.Items.AddRange(productList.ToArray());
                comboBox2.Text = productList[0];
            }
            else
            {
                productList.AddRange(factory2.Production);
                comboBox2.Items.AddRange(productList.ToArray());
                comboBox2.Text = productList[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetProduct() != null)
                textBox1.Text = GetProduct().ToString();
            else
                textBox1.Text = "Factory does not produce";
        }
        private Client GetProduct()
        {
            if (comboBox1.Text == factory1.Name)
            {
                if (comboBox2.Text == "Automobile")
                {
                    if (radioButton1.Checked)
                        return factory1.CreateAuto("Red", "gasoline");
                    else
                        return factory1.CreateAuto("Silver", "diesel");
                }
                else
                {
                    if (radioButton1.Checked)
                        return factory1.CreateMotocycle("Red", "gasoline");
                    else
                        return factory1.CreateMotocycle("Silver", "diesel");
                }
            }
            else
            {
                if (comboBox2.Text == "Automobile")
                {
                    if (radioButton1.Checked)
                        return factory2.CreateAuto("Red", "gasoline");
                    else
                        return factory2.CreateAuto("Silver", "diesel");
                }
                else
                {
                    if (radioButton1.Checked)
                        return factory2.CreateMotocycle("Red", "gasoline");
                    else
                        return factory2.CreateMotocycle("Silver", "diesel");
                }
            }
        }
    }
}
