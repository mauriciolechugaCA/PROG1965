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
        //List to store the reservations
        private List<string> seatsBook = new List<string>();
        //List to store the Waiting List
        private List<string> waitingList = new List<string>();

        //variable venueSystem as type VenueSystem
        private VenueSystem venueSystem;

        public FormVenue()
        {
            InitializeComponent();

            //Creating a new instance of the class VenueSystem to the variable venueSystem
            //Creating a relation betwen FormVenue and VenueSystem. This will allow access for the Form to the VenueSystem 
            venueSystem = new VenueSystem();
        }

        private void FormVenue_Load(object sender, EventArgs e)
        {
            venueSystem.UpdateHeader(lblHeader);
        }

        //private void btnBook_Click(object sender, EventArgs e)
        //{
        //    //Getting the selected Row and Col
        //    string selectedRow = lstRow.SelectedItem?.ToString();
        //    string selectedCol = lstCol.SelectedItem?.ToString();
        //    //Getting the Customer Name. Trim is used to remove blank spaces on the left
        //    string customerName = txtCustomerName.Text.Trim();

        //    //Checking if a Row AND Col were selected
        //    if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
        //    {
        //        lblFooter.Text = "Select a Row and Column to book!";
        //        return;
        //    }

        //    //Checking if a valid name was entered
        //    if (string.IsNullOrWhiteSpace(customerName))
        //    {
        //        lblFooter.Text = "Enter a valid name to book!";
        //        return;
        //    }

        //    //Saving the seat identification. Concatenating selectedRow and selected Col
        //    string seatID = $"{selectedRow}{selectedCol}";

        //    //Got this IF using ChatGPT. My first IF wasn't working (I was using Contains)
        //    if (seatsBook.Any(s => s.StartsWith($"{seatID},")))
        //    {
        //        lblFooter.Text = $"Seat {seatID} is occupied. Choose another seat.";
        //    }
        //    else
        //    {
        //        seatsBook.Add($"{seatID},{customerName}");
        //        ChangeLabelColor(seatID, Color.Red);
        //        //Updating the header
        //        UpdateHeader();
        //        lblFooter.Text = $"{customerName} was booked in seat {seatID}.";
        //    }
        //}

        private void btnBook_Click(object sender, EventArgs e)
        {
            venueSystem.BookSeat(lstRow.SelectedItem?.ToString(), lstCol.SelectedItem?.ToString(), txtCustomerName.Text.Trim(), lblFooter, lblHeader);
        }

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    //Getting the selected Row and Col
        //    string selectedRow = lstRow.SelectedItem?.ToString();
        //    string selectedCol = lstCol.SelectedItem?.ToString();

        //    //Checking if a Row AND Col were selected
        //    if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
        //    {
        //        lblFooter.Text = "Select a Row and Column to cancel!";
        //        return;
        //    }

        //    //Saving the seat identification. Concatenating selectedRow and selected Col
        //    string seatID = $"{selectedRow}{selectedCol}";

        //    // Verificar se o assento está reservado
        //    //Checking if the seat is occupied
        //    if (seatsBook.Any(s => s.StartsWith($"{seatID},")))
        //    {
        //        //Displaying Confirmation Message Box
        //        //https://www.makeuseof.com/winforms-application-confirmation-dialog-box-create/
        //        //https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
        //        DialogResult result = MessageBox.Show($"Do you want to cancel the {seatID} reservation?", "Cancel Confirmation", MessageBoxButtons.YesNo);

        //        //Check if YES
        //        if (result == DialogResult.Yes)
        //        {
        //            //Remove the reservation
        //            seatsBook.RemoveAll(s => s.StartsWith($"{seatID},"));
        //            //Restoring the label color
        //            ChangeLabelColor(seatID, Color.Lime);
        //            //Updatting the header
        //            UpdateHeader();
        //            //Confirmation message
        //            lblFooter.Text = $"Reservation for {seatID} was cancelled.";
        //        }
        //        else
        //        {
        //            //Check if NO
        //            lblFooter.Text = "Cancellation of reservation canceled.";
        //        }
        //    }
        //    else
        //    {
        //        //Seat was not booked
        //        lblFooter.Text = $"The seat {seatID} is not reserved and is available.";
        //    }
        //}


        private void btnCancel_Click(object sender, EventArgs e)
        {
            venueSystem.CancelSeat(lstRow.SelectedItem?.ToString(), lstCol.SelectedItem?.ToString(), lblFooter, lblHeader);
        }


        //private void btnCancelAllBookings_Click(object sender, EventArgs e)
        //{
        //    // Runs through items in list and clears everything
        //    foreach (var seat in seatsBook)
        //    {
        //        string[] parts = seat.Split(',');
        //        string seatID = parts[0];

        //        ChangeLabelColor(seatID, Color.Lime);
        //    }
        //    seatsBook.Clear();
        //    //Updatting the header
        //    UpdateHeader();
        //    //Confirmation message
        //    lblFooter.Text = $"All bookings were cancelled.";
        //}

        private void btnCancelAllBookings_Click(object sender, EventArgs e)
        {
            venueSystem.CancelAllSeats(lblFooter, lblHeader);
        }


        //METHOD -> Change the color of the label corresponding to certain seat
        //ChatGPT
        private void ChangeLabelColor(string seatID, Color color)
        {
            string labelName = $"lblSeat{seatID}";
            Control[] controls = grpVenue.Controls.Find(labelName, true);

            if (controls.Length > 0 && controls[0] is Label)
            {
                ((Label)controls[0]).BackColor = color;
            }
        }

        //METHOD -> Update the header information
        //private void UpdateHeader()
        //{
        //    int seatsAvailable = 12 - seatsBook.Count;
        //    int waitingListCount = waitingList.Count;

        //    double percCapacity = Math.Round((double)seatsBook.Count / 12 * 100, 2);


        //    lblHeader.Text = $"Total Capacity: 12, Seats Available: {seatsAvailable} " + $"({percCapacity}% of capacity), " + $"Waiting List: {waitingListCount}";
        //}



        //private void btnAddWaitingList_Click(object sender, EventArgs e)
        //{
        //    if ((seatsBook.Count != 0) && (seatsBook.Count <= 12))
        //    {
        //        lblFooter.Text = "There are seats available. Please select one to book.";
        //        return;
        //    }

        //    else
        //    {
        //        string selectedRow = lstRow.SelectedItem?.ToString();
        //        string selectedCol = lstCol.SelectedItem?.ToString();
        //        string customerName = txtCustomerName.Text.Trim();

        //        if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
        //        {
        //            lblFooter.Text = "Select a Row and Column to book!";
        //            return;
        //        }

        //        if (string.IsNullOrWhiteSpace(customerName))
        //        {
        //            lblFooter.Text = "Enter a valid name to book!";
        //            return;
        //        }

        //        string seatID = $"{selectedRow}{selectedCol}";

        //        if (seatsBook.Any(s => s.StartsWith($"{seatID},")))
        //        {
        //            lblFooter.Text = $"Seat {seatID} is occupied. Choose another seat.";
        //        }
        //        else
        //        {
        //            waitingList.Add($"{seatID},{customerName}");
        //            //Updating the header
        //            //UpdateHeader();
        //            lblFooter.Text = $"{customerName} was added to the waiting list.";
        //        }
        //    }
        //}



        private void btnAddWaitingList_Click(object sender, EventArgs e)
        {
            venueSystem.AddWaitingList(lstRow.SelectedItem?.ToString(), lstCol.SelectedItem?.ToString(), txtCustomerName.Text.Trim(), lblFooter, lblHeader);
        }

        private void btnFillAllSeats_Click(object sender, EventArgs e)
        {

        }
    }
}
