using SGDelivery.Repositories;
using System;
using System.Windows.Forms;

namespace ConsomeAPI
{
    public partial class Form1 : Form
    {
        public OrdersRepository Orders { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAmo_Click(object sender, EventArgs e)
        {
            Orders = new OrdersRepository();

            if (await Orders.GetAllOrders(true, 1000))
            {

            }
        }
    }
}
