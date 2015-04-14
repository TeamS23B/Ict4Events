using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaEventTeamS23B
{
    public partial class Admin___Add_Material___Add : Form
    {
        public Admin___Add_Material___Add()
        {
            InitializeComponent();
        }
        ApplicationLayer.Admin adminMat = new ApplicationLayer.Admin();

        /// <summary>
        /// Fills the 'Model' combobox with information related to the selected 'Type'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem == "Videocamera")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony Handycam CX405");
                cbModel.Items.Add("Sony Handycam PJ410");
                cbModel.Items.Add("Sony CX240E");
                cbModel.Items.Add("Canon VIXIA HF R60");
                cbModel.Items.Add("Canon VIXIA HF R500");
            }

            if (cbType.SelectedItem == "Fotocamera")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }
                      
            if (cbType.SelectedItem == "Laptop")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Toshiba Satelite L50");
                cbModel.Items.Add("Acer Aspire V3-371-33A1");
            }

            if (cbType.SelectedItem == "Smartphone")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Microsoft Lumia 640");
                cbModel.Items.Add("Samsung Galaxy S3");
                
            }

            if (cbType.SelectedItem == "Tablet")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Archos 70C Cobalt");
                cbModel.Items.Add("Samsung Galaxy Tab3 7.0 LITE");
                
            }

            if (cbType.SelectedItem == "Lader")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony Lader");
                cbModel.Items.Add("Samsung Lader");
                cbModel.Items.Add("Archos Lader ");
                cbModel.Items.Add("Toshiba Lader");
                cbModel.Items.Add("Acer Lader");
                cbModel.Items.Add("Canon Lader");
                
            }

            if (cbType.SelectedItem == "Accu")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony Accu");
                cbModel.Items.Add("Samsung Accu");
                cbModel.Items.Add("Archos Accu ");
                cbModel.Items.Add("Toshiba Accu");
                cbModel.Items.Add("Acer Accu");
                cbModel.Items.Add("Canon Accu");
                cbModel.Items.Add("Microsoft Accu");
            }

            if (cbType.SelectedItem == "SD-Kaart")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Kingston Micro SD 4GB");
                cbModel.Items.Add("Sandisk Micro SDHC 4GB");
                
            }

            if (cbType.SelectedItem == "USB-Stick")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Kingston DataTraveler 16GB");
                cbModel.Items.Add("Sandisk Cruzer Fit USB 16GB");
                
            }

            if (cbType.SelectedItem == "Muis")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Logitec Wireless");
                cbModel.Items.Add("Logitec Mouse M100");
                cbModel.Items.Add("Rapoo 3000P ");
                
            }
        }

        /// <summary>
        /// Adds the material to the database with the given cost price and rent price.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double price = StringsToDouble(tbEuros.Text, tbCents.Text);
                double rent = StringsToDouble(tbAdminEuros.Text, tbCents.Text);
                adminMat.AddMaterial((string)cbModel.SelectedItem, (string)cbType.SelectedItem, price, rent, (string)cbState.SelectedItem);
                MessageBox.Show("Item is toegevoegd.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Transforms two separate strings into a single 'double'.
        /// </summary>
        /// <param name="upper"></param>
        /// <param name="lower"></param>
        /// <returns></returns>
        public double StringsToDouble(string upper, string lower)
        {
            int upInt = Convert.ToInt32(upper);
            int lowerInt = Convert.ToInt32(lower);
            return upInt * 1d + Math.Pow(0.1d, lower.Length) * lowerInt;
        }
    }
}
