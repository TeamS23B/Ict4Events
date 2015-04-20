using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection;
using Phidgets;
using DatabaseConnection.Types;

namespace SocialMediaEventTeamS23B
{
    public partial class AccessControl : Form
    {
        private RFID rfid;

        private ApplicationLayer.AccessControl accessControl;
        

       
        /// <summary>
        /// Initiates rfid. attach/detach/error/tag and taglost
        /// </summary>
        /// <param name="dbc"></param>
        public AccessControl(DataBaseConnection dbc)
        {
            InitializeComponent();
            accessControl = new ApplicationLayer.AccessControl(dbc);//todo dbc
            rfid = new RFID();
            rfid.open();

            rfid.Attach += rfid_Attach;
            rfid.Detach += rfid_Detach;
            rfid.Error += rfid_Error;

            rfid.Tag += rfid_Tag;
            rfid.TagLost += rfid_TagLost;
            
        }

        #region attatchment

        void rfid_Error(object sender, Phidgets.Events.ErrorEventArgs e)
        {
            MessageBox.Show("Phidgets Error: " + e.Code + " : " + e.Description);
            if (!rfid.Attached)
            {
                btReattatch.Visible = true;
            }
        }

        void rfid_Detach(object sender, Phidgets.Events.DetachEventArgs e)
        {
            //retry attachment
            e.Device.waitForAttachment(10000);
        }

        void rfid_Attach(object sender, Phidgets.Events.AttachEventArgs e)
        {
            btReattatch.Visible = false;
            //Yay attatched :D
        }
        private void btReattatch_Click(object sender, EventArgs e)
        {
            rfid.waitForAttachment(10000);
        }
        #endregion

        /// <summary>
        /// Checks if the RFID which is checked, has paid for the event.
        //  The led of the reader blinks green if it's ok, and red when he hasn't paid yet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Tag(object sender, Phidgets.Events.TagEventArgs e)
        {
            lblRFID.Text = e.Tag;
            delayClean.Enabled=false;
            var payed = false;
            try
            {
                payed = accessControl.CheckPayment(e.Tag);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            var tr = new Thread(flash);

            if (payed)
            {
                lblPayed.Text = "Betaald";
                lblPayed.ForeColor = Color.LimeGreen;
                tr.Start(true);//flash good
            }
            else
            {
                lblPayed.Text = "Niet Betaald";
                lblPayed.ForeColor = Color.Red;
                tr.Start(false);//flash error
            }
            

        }

        void rfid_TagLost(object sender, Phidgets.Events.TagEventArgs e)
        {
            delayClean.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            delayClean.Stop();
            lblRFID.Text = "00000000";
            lblPayed.Text = "-";
            lblPayed.ForeColor = Color.Black;
        }

        /// <summary>
        /// Makes the LED blink by using threats to make the LED sleep
        /// </summary>
        /// <param name="good"></param>
        private void flash(object good)
        {
            if ((bool)good)
            {
                rfid.LED = true;
                Thread.Sleep(100);
                rfid.LED = false;
                Thread.Sleep(100);
                rfid.LED = true;
                Thread.Sleep(100);
                rfid.LED = false;
                Thread.Sleep(100);
                rfid.LED = true;
                Thread.Sleep(100);
                rfid.LED = false;
            }
            else
            {
                rfid.LED = true;
                Thread.Sleep(300);
                rfid.LED = false;
                Thread.Sleep(300);
                rfid.LED = true;
                Thread.Sleep(300);
                rfid.LED = false;
            }
        }

        private void btnAllHere_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Visitor visitor in accessControl.VisitorsAtTheEvent())
            {
                listBox1.Items.Add(visitor);
            }
        }
    }
}
