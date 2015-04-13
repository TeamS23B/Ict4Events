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
                  // Hier ben ik gebleven     
            if (cbType.SelectedItem == "Laptop")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
            }

            if (cbType.SelectedItem == "Smartphone")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }

            if (cbType.SelectedItem == "Tablet")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }

            if (cbType.SelectedItem == "Lader")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }

            if (cbType.SelectedItem == "Accu")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }

            if (cbType.SelectedItem == "SD-Kaart")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }

            if (cbType.SelectedItem == "USB-Stick")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }

            if (cbType.SelectedItem == "Muis")
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Sony ILCE-3000");
                cbModel.Items.Add("Sony NEX-7 E-mount");
                cbModel.Items.Add("Canon PowerShot S120 ");
                cbModel.Items.Add("Canon PowerShot S200");
                cbModel.Items.Add("Canon IXUS 170");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adminMat.AddMaterial(cbModel.SelectedItem, cbType.SelectedItem, );
        }
    }
}
