using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class VenueSystem
    {
        private List<string> seatsBook = new List<string>();
        private List<string> waitingList = new List<string>();

        //METHOD -> Book the seat
        //Label -> I found on the internet
        public void BookSeat(string selectedRow, string selectedCol, string customerName, Label lblFooter, Label lblHeader)
        {
            // Validar a seleção da linha e coluna
            if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
            {
                lblFooter.Text = "Select a Row and Column to book!";
                return;
            }

            // Validar o nome do cliente
            if (string.IsNullOrWhiteSpace(customerName))
            {
                lblFooter.Text = "Enter a valid name to book!";
                return;
            }

            string seatID = $"{selectedRow}{selectedCol}";

            if (seatsBook.Any(s => s.StartsWith($"{seatID},")))
            {
                lblFooter.Text = $"Seat {seatID} is occupied. Choose another seat.";
            }
            else
            {
                seatsBook.Add($"{seatID},{customerName}");
                //ChangeLabelColor(seatID, Color.Red);
                UpdateHeader(lblHeader);
                lblFooter.Text = $"{customerName} was booked in seat {seatID}.";
            }
        }

        public void CancelSeat(string selectedRow, string selectedCol, Label lblFooter, Label lblHeader)
        {
            if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
            {
                lblFooter.Text = "Select a Row and Column to cancel!";
                return;
            }

            string seatID = $"{selectedRow}{selectedCol}";

            if (seatsBook.Any(s => s.StartsWith($"{seatID},")))
            {
                DialogResult result = MessageBox.Show($"Do you want to cancel the {seatID} reservation?", "Cancel Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    seatsBook.RemoveAll(s => s.StartsWith($"{seatID},"));
                    //ChangeLabelColor(seatID, Color.Lime);
                    UpdateHeader(lblHeader);
                    lblFooter.Text = $"Reservation for {seatID} was cancelled.";
                }
                else
                {
                    lblFooter.Text = "Cancellation of reservation canceled.";
                }
            }
            else
            {
                lblFooter.Text = $"The seat {seatID} is not reserved and is available.";
            }
        }

        public void CancelAllSeats(Label lblFooter, Label lblHeader)
        {
            foreach (var seat in seatsBook)
            {
                string[] parts = seat.Split(',');
                string seatID = parts[0];
                //ChangeLabelColor(seatID, Color.Lime);
            }
            seatsBook.Clear();
            UpdateHeader(lblHeader);
            lblFooter.Text = $"All bookings were cancelled.";
        }

        public void UpdateHeader(Label lblHeader)
        {
            int seatsAvailable = 12 - seatsBook.Count;
            int waitingListCount = waitingList.Count;

            double percCapacity = Math.Round((double)seatsBook.Count / 12 * 100, 2);

            lblHeader.Text = $"Total Capacity: 12, Seats Available: {seatsAvailable} " + $"({percCapacity}% of capacity), " + $"Waiting List: {waitingListCount}";
        }

        public void AddWaitingList(string selectedRow, string selectedCol, string customerName, Label lblFooter, Label lblHeader)
        {
            if ((seatsBook.Count != 0) && (seatsBook.Count <= 12))
            {
                lblFooter.Text = "There are seats available. Please select one to book.";
                return;
            }

            else
            {
                if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
                {
                    lblFooter.Text = "Select a Row and Column to book!";
                    return;
                }

                if (string.IsNullOrWhiteSpace(customerName))
                {
                    lblFooter.Text = "Enter a valid name to book!";
                    return;
                }

                string seatID = $"{selectedRow}{selectedCol}";

                if (seatsBook.Any(s => s.StartsWith($"{seatID},")))
                {
                    lblFooter.Text = $"Seat {seatID} is occupied. Choose another seat.";
                }
                else
                {
                    waitingList.Add($"{seatID},{customerName}");
                    UpdateHeader(lblHeader);
                    lblFooter.Text = $"{customerName} was added to the waiting list.";
                }
            }
        }

    }
}
