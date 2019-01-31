using HWPatterns3_Decorator.Component;
using HWPatterns3_Decorator.Component.ConcreteComponent;
using HWPatterns3_Decorator.Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWPatterns3_Decorator
{
    public partial class Form1 : Form
    {
        Driver driver;
        Driver driverСomply;
        public Form1()
        {
            InitializeComponent();
            driver = new CarDriver();
            driverСomply = driver;
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            if (driver != null)
            {
                driver.Name = textBox1.Text;
                if (checkBoxBus.Checked)
                    driver = new BusDriver(driver);
                if (checkBoxСustomerIsLate.Checked)
                    driver = new RacerDriver(driver);
                MessageBox.Show(driver.Drive());
                driver = driverСomply;
            }
        }
    }
}
