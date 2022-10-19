using Kitteh_s_Modern_Shop.src.classes;

namespace Kitteh_s_Modern_Shop
{
    public partial class Form1 : Form
    {
        //Add Shop Items
        private readonly List<ShopItem> shopItems = new List<ShopItem> { new ShopItem("Ramen", 10.00), new ShopItem("Gyoza", 5.00), new ShopItem("Edamame", 4.50), new ShopItem("Takoyaki", 8.25), new ShopItem("Tea", 2.50) };

        public Form1()
        {
            InitializeComponent();
        }

        //Custom Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Custom Maximize Button
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        //Custom Minimize Button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //vvv -= Shop Item Buttons =- vvv
        private void btnRamenPlus_Click(object sender, EventArgs e)
        {
            shopItems[0].QuantityOrdered++;
            txtRamenCount.Text = shopItems[0].QuantityOrdered.ToString();
        }

        private void btnRamenMinus_Click(object sender, EventArgs e)
        {
            if (shopItems[0].QuantityOrdered != 0 || shopItems[0].QuantityOrdered > 0)
            {
                shopItems[0].QuantityOrdered--;
                txtRamenCount.Text = shopItems[0].QuantityOrdered.ToString();
            }
        }

        private void btnGyozaPlus_Click(object sender, EventArgs e)
        {
            shopItems[1].QuantityOrdered++;
            txtGyozaCount.Text = shopItems[1].QuantityOrdered.ToString();
        }

        private void btnGyozaMinus_Click(object sender, EventArgs e)
        {
            if (shopItems[1].QuantityOrdered != 0 || shopItems[1].QuantityOrdered > 0)
            {
                shopItems[1].QuantityOrdered--;
                txtGyozaCount.Text = shopItems[1].QuantityOrdered.ToString();
            }
        }

        private void btnEdamamePlus_Click(object sender, EventArgs e)
        {
            shopItems[2].QuantityOrdered++;
            txtEdamameCount.Text = shopItems[2].QuantityOrdered.ToString();
        }

        private void btnEdamameMinus_Click(object sender, EventArgs e)
        {
            if (shopItems[2].QuantityOrdered != 0 || shopItems[2].QuantityOrdered > 0)
            {
                shopItems[2].QuantityOrdered--;
                txtEdamameCount.Text = shopItems[2].QuantityOrdered.ToString();
            }
        }

        private void btnTakoyakiPlus_Click(object sender, EventArgs e)
        {
            shopItems[3].QuantityOrdered++;
            txtTakoyakiCount.Text = shopItems[3].QuantityOrdered.ToString();
        }

        private void btnTakoyakiMinus_Click(object sender, EventArgs e)
        {
            if (shopItems[3].QuantityOrdered != 0 || shopItems[3].QuantityOrdered > 0)
            {
                shopItems[3].QuantityOrdered--;
                txtTakoyakiCount.Text = shopItems[3].QuantityOrdered.ToString();
            }
        }

        private void btnTeaPlus_Click(object sender, EventArgs e)
        {
            shopItems[4].QuantityOrdered++;
            txtTeaCount.Text = shopItems[4].QuantityOrdered.ToString();
        }

        private void btnTeaMinus_Click(object sender, EventArgs e)
        {
            if (shopItems[4].QuantityOrdered != 0 || shopItems[4].QuantityOrdered > 0)
            {
                shopItems[4].QuantityOrdered--;
                txtTeaCount.Text = shopItems[4].QuantityOrdered.ToString();
            }
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (ShopItem item in shopItems)
            {
                total += item.ReturnPrice();
            }
            txtTotal.Text = "$" + String.Format("{0:0.00}", total);
        }
    }
}