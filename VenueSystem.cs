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
        public void BookSeat(string selectedRow, string selectedCol, string customerName, Label lblFooter, Label lblHeader)
        {
            //Validating if Row or Col are selected
            if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
            {
                lblFooter.Text = "Select a Row and Column to book!";
                return;
            }

            //Validating the name
            if (string.IsNullOrWhiteSpace(customerName))
            {
                lblFooter.Text = "Enter a valid name to book!";
                return;
            }

            string seatID = $"{selectedRow}{selectedCol}";

            //Checking if the seat is available
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

        //METHOD -> Cancel the book
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
                    lblFooter.Text = $"Reservation for {seatID} was cancelled.";
                    CompleteWithWaitingList(seatID, lblFooter);
                    UpdateHeader(lblHeader);
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
            if (waitingList.Any())
            {
                CompleteWithAllWaitingList(lblFooter);
                UpdateHeader(lblHeader);
            }
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
            //if ((seatsBook.Count != 0) && (seatsBook.Count <= 12))
            if (seatsBook.Count < 12)
            {
                lblFooter.Text = "There are seats available. Please select one to book.";
                return;
            }

            else
            {
                //if (string.IsNullOrWhiteSpace(selectedRow) || string.IsNullOrWhiteSpace(selectedCol))
                //{
                //    lblFooter.Text = "Select a Row and Column to book!";
                //    return;
                //}

                if (string.IsNullOrWhiteSpace(customerName))
                {
                    lblFooter.Text = "Enter a valid name to book!";
                    return;
                }

                //string seatID = $"{selectedRow}{selectedCol}";

                //if (seatsBook.Any(s => s.StartsWith($"{seatID},")))
                //{
                //    lblFooter.Text = $"Seat {seatID} is occupied. Choose another seat.";
                //}
                waitingList.Add($"{customerName}");
                UpdateHeader(lblHeader);
                lblFooter.Text = $"{customerName} was added to the waiting list.";
            }
        }

        public void ChangeLabelColor(string seatID, Color color)
        {
            //string labelName = $"lblSeat{seatID}";
            //Control[] controls = FormVenue.grpVenue.Controls.Find(labelName, true);

            //if (controls.Length > 0 && controls[0] is Label)
            //{
            //    ((Label)controls[0]).BackColor = color;
            //}
        }

        public void FillAllSeats(Label lblFooter, Label lblHeader)
        {
            if (seatsBook.Count == 12)
            {
                lblFooter.Text = "There are no seats available. Please use the Waiting List.";
                return;
            }

            string nameGeneric = "Anonymous";

            //Checking the seats for Row A
            for (int row = 1; row <= 4; row++)
            {
                string seatID = $"A{row}";
                if (!seatsBook.Any(s => s.StartsWith($"{seatID},")))
                {
                    seatsBook.Add($"{seatID},{nameGeneric}");
                    //ChangeLabelColor(seatID, Color.Red);
                }
            }

            for (int row = 1; row <= 4; row++)
            {
                string seatID = $"B{row}";
                if (!seatsBook.Any(s => s.StartsWith($"{seatID},")))
                {
                    seatsBook.Add($"{seatID},{nameGeneric}");
                    //ChangeLabelColor(seatID, Color.Red);
                }
            }

            // Preencher os assentos da coluna C
            for (int row = 1; row <= 4; row++)
            {
                string seatID = $"C{row}";
                if (!seatsBook.Any(s => s.StartsWith($"{seatID},")))
                {
                    seatsBook.Add($"{seatID},{nameGeneric}");
                    //ChangeLabelColor(seatID, Color.Red);
                }
            }

            UpdateHeader(lblHeader);
            lblFooter.Text = $"All seat were filled.";
        }

        private void CompleteWithWaitingList(string seatID, Label lblFooter)
        {
            if (waitingList.Any())
            {
                string firstWaitingList = waitingList.First();
                waitingList.Remove(firstWaitingList);

                seatsBook.Add($"{seatID},{firstWaitingList}");

                lblFooter.Text += $" Seat {seatID} is booked for {firstWaitingList} from the Waiting List.";

                //ChangeLabelColor(seatID, Color.Red);
            }
        }

        private void CompleteWithAllWaitingList(Label lblFooter)
        {
            //A Row
            for (int row = 1; row <= 4; row++)
            {
                if (waitingList.Any())
                {
                    string firstWaitingList = waitingList.First();
                    waitingList.Remove(firstWaitingList);
                    string seatID = $"A{row}";
                    if (!seatsBook.Any(s => s.StartsWith($"{seatID},")))
                    {
                        seatsBook.Add($"{seatID},{firstWaitingList}");
                        lblFooter.Text += $"\nSeat {seatID} was booked for {firstWaitingList} from the Waiting List.";
                        //ChangeLabelColor(seatID, Color.Red);
                    }
                    else
                    {
                        return;
                    }
                }
            }

            //B Row
            for (int row = 1; row <= 4; row++)
            {
                if (waitingList.Any())
                {
                    string firstWaitingList = waitingList.First();
                    waitingList.Remove(firstWaitingList);
                    string seatID = $"B{row}";
                    if (!seatsBook.Any(s => s.StartsWith($"{seatID},")))
                    {
                        seatsBook.Add($"{seatID},{firstWaitingList}");
                        lblFooter.Text += $"\nSeat {seatID} was booked for {firstWaitingList} from the Waiting List.";
                        //ChangeLabelColor(seatID, Color.Red);
                    }
                    else
                    {
                        return;
                    }
                }
            }

            //C Row
            for (int row = 1; row <= 4; row++)
            {
                if (waitingList.Any())
                {
                    string firstWaitingList = waitingList.First();
                    waitingList.Remove(firstWaitingList);
                    string seatID = $"A{row}";
                    if (!seatsBook.Any(s => s.StartsWith($"{seatID},")))
                    {
                        seatsBook.Add($"{seatID},{firstWaitingList}");
                        lblFooter.Text += $"\nSeat {seatID} was booked for {firstWaitingList} from the Waiting List.";
                        //ChangeLabelColor(seatID, Color.Red);
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

    }
}
