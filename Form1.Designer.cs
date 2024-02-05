namespace Assignment_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTotalCapacity = new Label();
            lblAvailableSeats = new Label();
            lblCapacityPercentage = new Label();
            lblWaitingList = new Label();
            venueGroupBox = new GroupBox();
            btnC4 = new Button();
            btnC3 = new Button();
            btnC2 = new Button();
            btnC1 = new Button();
            btnB4 = new Button();
            btnB3 = new Button();
            button3 = new Button();
            btnB1 = new Button();
            btnA4 = new Button();
            btnA3 = new Button();
            btnA2 = new Button();
            btnA1 = new Button();
            lblRows = new Label();
            lblSeats = new Label();
            tbCustName = new TextBox();
            lblCustName = new Label();
            btnBook = new Button();
            btnCancel = new Button();
            btnWaitlist = new Button();
            btnFillAllSeats = new Button();
            btnCancelAll = new Button();
            lblMessage = new Label();
            lbRows = new ListBox();
            lbSeats = new ListBox();
            venueGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalCapacity
            // 
            lblTotalCapacity.AutoSize = true;
            lblTotalCapacity.Font = new Font("Segoe UI", 11F);
            lblTotalCapacity.Location = new Point(12, 9);
            lblTotalCapacity.Name = "lblTotalCapacity";
            lblTotalCapacity.Size = new Size(126, 20);
            lblTotalCapacity.TabIndex = 1;
            lblTotalCapacity.Text = "Total Capacity: 12";
            lblTotalCapacity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAvailableSeats
            // 
            lblAvailableSeats.AutoSize = true;
            lblAvailableSeats.Font = new Font("Segoe UI", 11F);
            lblAvailableSeats.Location = new Point(162, 9);
            lblAvailableSeats.Name = "lblAvailableSeats";
            lblAvailableSeats.Size = new Size(131, 20);
            lblAvailableSeats.TabIndex = 2;
            lblAvailableSeats.Text = "Available seats: 12";
            lblAvailableSeats.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCapacityPercentage
            // 
            lblCapacityPercentage.AutoSize = true;
            lblCapacityPercentage.Font = new Font("Segoe UI", 11F);
            lblCapacityPercentage.Location = new Point(325, 9);
            lblCapacityPercentage.Name = "lblCapacityPercentage";
            lblCapacityPercentage.Size = new Size(99, 20);
            lblCapacityPercentage.TabIndex = 3;
            lblCapacityPercentage.Text = "0.0% capacity";
            lblCapacityPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWaitingList
            // 
            lblWaitingList.AutoEllipsis = true;
            lblWaitingList.Font = new Font("Segoe UI", 11F);
            lblWaitingList.Location = new Point(451, 9);
            lblWaitingList.Name = "lblWaitingList";
            lblWaitingList.Size = new Size(266, 20);
            lblWaitingList.TabIndex = 4;
            lblWaitingList.Text = "no one is on the waiting list.";
            lblWaitingList.TextAlign = ContentAlignment.MiddleRight;
            // 
            // venueGroupBox
            // 
            venueGroupBox.Controls.Add(btnC4);
            venueGroupBox.Controls.Add(btnC3);
            venueGroupBox.Controls.Add(btnC2);
            venueGroupBox.Controls.Add(btnC1);
            venueGroupBox.Controls.Add(btnB4);
            venueGroupBox.Controls.Add(btnB3);
            venueGroupBox.Controls.Add(button3);
            venueGroupBox.Controls.Add(btnB1);
            venueGroupBox.Controls.Add(btnA4);
            venueGroupBox.Controls.Add(btnA3);
            venueGroupBox.Controls.Add(btnA2);
            venueGroupBox.Controls.Add(btnA1);
            venueGroupBox.Font = new Font("Segoe UI", 12F);
            venueGroupBox.Location = new Point(31, 58);
            venueGroupBox.Name = "venueGroupBox";
            venueGroupBox.Size = new Size(365, 270);
            venueGroupBox.TabIndex = 5;
            venueGroupBox.TabStop = false;
            venueGroupBox.Text = "Venue:";
            // 
            // btnC4
            // 
            btnC4.BackColor = Color.FromArgb(128, 255, 128);
            btnC4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnC4.Location = new Point(288, 182);
            btnC4.Name = "btnC4";
            btnC4.Size = new Size(70, 70);
            btnC4.TabIndex = 11;
            btnC4.Text = "C4";
            btnC4.UseVisualStyleBackColor = false;
            // 
            // btnC3
            // 
            btnC3.BackColor = Color.FromArgb(128, 255, 128);
            btnC3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnC3.Location = new Point(194, 182);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(70, 70);
            btnC3.TabIndex = 10;
            btnC3.Text = "C3";
            btnC3.UseVisualStyleBackColor = false;
            // 
            // btnC2
            // 
            btnC2.BackColor = Color.FromArgb(128, 255, 128);
            btnC2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnC2.Location = new Point(100, 182);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(70, 70);
            btnC2.TabIndex = 9;
            btnC2.Text = "C2";
            btnC2.UseVisualStyleBackColor = false;
            // 
            // btnC1
            // 
            btnC1.BackColor = Color.FromArgb(128, 255, 128);
            btnC1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnC1.Location = new Point(6, 182);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(70, 70);
            btnC1.TabIndex = 8;
            btnC1.Text = "C1";
            btnC1.UseVisualStyleBackColor = false;
            // 
            // btnB4
            // 
            btnB4.BackColor = Color.FromArgb(128, 255, 128);
            btnB4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnB4.Location = new Point(288, 106);
            btnB4.Name = "btnB4";
            btnB4.Size = new Size(70, 70);
            btnB4.TabIndex = 7;
            btnB4.Text = "B4";
            btnB4.UseVisualStyleBackColor = false;
            // 
            // btnB3
            // 
            btnB3.BackColor = Color.FromArgb(128, 255, 128);
            btnB3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnB3.Location = new Point(194, 106);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(70, 70);
            btnB3.TabIndex = 6;
            btnB3.Text = "B3";
            btnB3.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(100, 106);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 5;
            button3.Text = "B2";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnB1
            // 
            btnB1.BackColor = Color.FromArgb(128, 255, 128);
            btnB1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnB1.Location = new Point(6, 106);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(70, 70);
            btnB1.TabIndex = 4;
            btnB1.Text = "B1";
            btnB1.UseVisualStyleBackColor = false;
            // 
            // btnA4
            // 
            btnA4.BackColor = Color.FromArgb(128, 255, 128);
            btnA4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnA4.Location = new Point(288, 30);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(70, 70);
            btnA4.TabIndex = 3;
            btnA4.Text = "A4";
            btnA4.UseVisualStyleBackColor = false;
            // 
            // btnA3
            // 
            btnA3.BackColor = Color.FromArgb(128, 255, 128);
            btnA3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnA3.Location = new Point(194, 30);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(70, 70);
            btnA3.TabIndex = 2;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = false;
            // 
            // btnA2
            // 
            btnA2.BackColor = Color.FromArgb(128, 255, 128);
            btnA2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnA2.Location = new Point(100, 30);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(70, 70);
            btnA2.TabIndex = 1;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = false;
            // 
            // btnA1
            // 
            btnA1.BackColor = Color.FromArgb(128, 255, 128);
            btnA1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnA1.Location = new Point(6, 30);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(70, 70);
            btnA1.TabIndex = 0;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = false;
            // 
            // lblRows
            // 
            lblRows.AutoSize = true;
            lblRows.Font = new Font("Segoe UI", 12F);
            lblRows.Location = new Point(423, 52);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(44, 21);
            lblRows.TabIndex = 8;
            lblRows.Text = "Row:";
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Segoe UI", 12F);
            lblSeats.Location = new Point(573, 52);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(50, 21);
            lblSeats.TabIndex = 9;
            lblSeats.Text = "Seats:";
            // 
            // tbCustName
            // 
            tbCustName.Font = new Font("Segoe UI", 12F);
            tbCustName.Location = new Point(423, 196);
            tbCustName.Name = "tbCustName";
            tbCustName.Size = new Size(285, 29);
            tbCustName.TabIndex = 10;
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Font = new Font("Segoe UI", 12F);
            lblCustName.Location = new Point(423, 173);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(124, 21);
            lblCustName.TabIndex = 11;
            lblCustName.Text = "Customer name:";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.LightSkyBlue;
            btnBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBook.Location = new Point(423, 240);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(135, 55);
            btnBook.TabIndex = 12;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(573, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 55);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnWaitlist
            // 
            btnWaitlist.Font = new Font("Segoe UI", 12F);
            btnWaitlist.Location = new Point(423, 301);
            btnWaitlist.Name = "btnWaitlist";
            btnWaitlist.Size = new Size(285, 42);
            btnWaitlist.TabIndex = 14;
            btnWaitlist.Text = "Add to waitlist";
            btnWaitlist.UseVisualStyleBackColor = true;
            // 
            // btnFillAllSeats
            // 
            btnFillAllSeats.Font = new Font("Segoe UI", 12F);
            btnFillAllSeats.Location = new Point(423, 349);
            btnFillAllSeats.Name = "btnFillAllSeats";
            btnFillAllSeats.Size = new Size(135, 42);
            btnFillAllSeats.TabIndex = 15;
            btnFillAllSeats.Text = "Fill All Seats";
            btnFillAllSeats.UseVisualStyleBackColor = true;
            // 
            // btnCancelAll
            // 
            btnCancelAll.Font = new Font("Segoe UI", 10F);
            btnCancelAll.Location = new Point(573, 349);
            btnCancelAll.Name = "btnCancelAll";
            btnCancelAll.Size = new Size(135, 42);
            btnCancelAll.TabIndex = 16;
            btnCancelAll.Text = "Cancel Bookings";
            btnCancelAll.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(31, 339);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(365, 52);
            lblMessage.TabIndex = 17;
            lblMessage.Text = "Message Box";
            lblMessage.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbRows
            // 
            lbRows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRows.FormattingEnabled = true;
            lbRows.ItemHeight = 21;
            lbRows.Items.AddRange(new object[] { "A", "B", "C" });
            lbRows.Location = new Point(423, 76);
            lbRows.Name = "lbRows";
            lbRows.Size = new Size(135, 88);
            lbRows.TabIndex = 18;
            // 
            // lbSeats
            // 
            lbSeats.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSeats.FormattingEnabled = true;
            lbSeats.ItemHeight = 21;
            lbSeats.Items.AddRange(new object[] { "1", "2", "3", "4" });
            lbSeats.Location = new Point(573, 76);
            lbSeats.Name = "lbSeats";
            lbSeats.Size = new Size(135, 88);
            lbSeats.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 403);
            Controls.Add(lbSeats);
            Controls.Add(lbRows);
            Controls.Add(lblMessage);
            Controls.Add(btnCancelAll);
            Controls.Add(btnFillAllSeats);
            Controls.Add(btnWaitlist);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(lblCustName);
            Controls.Add(tbCustName);
            Controls.Add(lblSeats);
            Controls.Add(lblRows);
            Controls.Add(venueGroupBox);
            Controls.Add(lblWaitingList);
            Controls.Add(lblCapacityPercentage);
            Controls.Add(lblAvailableSeats);
            Controls.Add(lblTotalCapacity);
            Name = "Form1";
            Text = "Venue: PROG1965 A1";
            venueGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTotalCapacity;
        private Label lblAvailableSeats;
        private Label lblCapacityPercentage;
        private Label lblWaitingList;
        private GroupBox venueGroupBox;
        private Button btnC4;
        private Button btnC3;
        private Button btnC2;
        private Button btnC1;
        private Button btnB4;
        private Button btnB3;
        private Button button3;
        private Button btnB1;
        private Button btnA4;
        private Button btnA3;
        private Button btnA2;
        private Button btnA1;
        private Label lblRows;
        private Label lblSeats;
        private TextBox tbCustName;
        private Label lblCustName;
        private Button btnBook;
        private Button btnCancel;
        private Button btnWaitlist;
        private Button btnFillAllSeats;
        private Button btnCancelAll;
        private Label lblMessage;
        private ListBox lbRows;
        private ListBox lbSeats;
    }
}
