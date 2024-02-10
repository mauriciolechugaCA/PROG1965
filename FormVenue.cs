using Assignment_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class FormVenue : Form
    {

        //variable venueSystem as type VenueSystem
        private VenueSystem venueSystem;

        public FormVenue()
        {
            InitializeComponent();

            venueSystem = new VenueSystem();
        }

        private void FormVenue_Load(object sender, EventArgs e)
        {
            venueSystem.UpdateHeader(lblHeader);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            venueSystem.BookSeat(lstRow.SelectedItem?.ToString(), lstCol.SelectedItem?.ToString(), txtCustomerName.Text.Trim(), lblFooter, lblHeader);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            venueSystem.CancelSeat(lstRow.SelectedItem?.ToString(), lstCol.SelectedItem?.ToString(), lblFooter, lblHeader);
        }



        private void btnCancelAllBookings_Click(object sender, EventArgs e)
        {
            venueSystem.CancelAllSeats(lblFooter, lblHeader);
        }

        private void ChangeLabelColor(string seatID, Color color)
        {
            string labelName = $"lblSeat{seatID}";
            Control[] controls = grpVenue.Controls.Find(labelName, true);

            if (controls.Length > 0 && controls[0] is Label)
            {
                ((Label)controls[0]).BackColor = color;
            }
        }

        private void btnAddWaitingList_Click(object sender, EventArgs e)
        {
            venueSystem.AddWaitingList(lstRow.SelectedItem?.ToString(), lstCol.SelectedItem?.ToString(), txtCustomerName.Text.Trim(), lblFooter, lblHeader);
        }

        private void btnFillAllSeats_Click(object sender, EventArgs e)
        {
            venueSystem.FillAllSeats(lblFooter, lblHeader);
        }
    }
}
