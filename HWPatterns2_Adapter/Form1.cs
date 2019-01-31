using HWPatterns2_Adapter.Adaptee;
using HWPatterns2_Adapter.Adapter;
using HWPatterns2_Adapter.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWPatterns2_Adapter
{
    public partial class Form1 : Form
    {
        List<string> transportTypeList;
        Driver driver;
        Auto auto;
        Camel camel;
        Airplane airplane;
        public Form1()
        {
            InitializeComponent();

            driver = new Driver();
            auto = new Auto();
            camel = new Camel();
            airplane = new Airplane();
            transportTypeList = new List<string>();
            transportTypeList.Add(auto.Name);
            transportTypeList.Add(camel.Name);
            transportTypeList.Add(airplane.Name);
            comboBox1.Text = transportTypeList[0];
            comboBox1.Items.AddRange(transportTypeList.ToArray());
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == auto.Name)
            {
                label2.Text = driver.Travel(auto);
            }
            else if (comboBox1.Text == camel.Name)
            {
                ITransport camelTransport = new CamelToTransportAdapter(camel);
                label2.Text = driver.Travel(camelTransport);
            }
            else if (comboBox1.Text == airplane.Name)
            {
                ITransport airplaneTransport = new AirplaneToTransportAdapter(airplane);
                label2.Text = driver.Travel(airplaneTransport);
            }
        }
    }
}
