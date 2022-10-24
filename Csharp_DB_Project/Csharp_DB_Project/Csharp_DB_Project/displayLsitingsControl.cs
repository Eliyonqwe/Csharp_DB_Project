using Csharp_DB_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    public partial class displayLsitingsControl : UserControl
    {
        int userID;
        User u;

        public String userid
        {
            get { return userIDtext.Text; }
            set { userIDtext.Text = " " + value; }
        }
        public String stockid
        {
            get { return stockIDtext.Text; }
            set { stockIDtext.Text = " " + value; }

        }

        public String companyname
        {
            get { return companyNametext.Text; }
            set { companyNametext.Text = " " + value; }
        }
        public String companytype
        {
            get { return companytypetext.Text; }
            set { companytypetext.Text = " " + value; }
        }

        public String amount
        {
            get { return amounttext.Text; }
            set { amounttext.Text = " " + value; }

        }
        public String sellingprice
        {
            get { return sellingpricetext.Text; }
            set { sellingpricetext.Text = " " + value; }
        }

        /* public String price
         {
             get { return lbl_price.Text; }
             set { lbl_price.Text += " " + value; }

         }
         public String date
         {
             get { return lbl_date.Text; }
             set { lbl_date.Text += " " + value; }
         }
 */

        public displayLsitingsControl()
        {
            InitializeComponent();
        }

            public displayLsitingsControl(string user)
        {
            InitializeComponent();
            u = new User();
            u.username = user;

            String status = u.FetchID(); //fetches current user's id. It is NOT the seller's id
            if (status == "0")
            {
                userID = u.userid;
               
            }
            else
                MessageBox.Show(status);
        }


        private void displayLsitings_Load(object sender, EventArgs e)
        {
    
        }

    }

}
