namespace Assignment1
{
    partial class FormVenue
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
            lblHeader = new Label();
            lblFooter = new Label();
            grpVenue = new GroupBox();
            lblSeatC4 = new Label();
            lblSeatC3 = new Label();
            lblSeatC2 = new Label();
            lblSeatC1 = new Label();
            lblSeatB4 = new Label();
            lblSeatB3 = new Label();
            lblSeatB2 = new Label();
            lblSeatB1 = new Label();
            lblSeatA4 = new Label();
            lblSeatA3 = new Label();
            lblSeatA2 = new Label();
            lblSeatA1 = new Label();
            lblRow = new Label();
            lblCol = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            btnBook = new Button();
            btnCancel = new Button();
            btnAddWaitingList = new Button();
            btnFillAllSeats = new Button();
            lstRow = new ListBox();
            lstCol = new ListBox();
            btnCancelAllBookings = new Button();
            grpVenue.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(26, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(58, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Header";
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(26, 402);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(52, 20);
            lblFooter.TabIndex = 1;
            lblFooter.Text = "Footer";
            // 
            // grpVenue
            // 
            grpVenue.Controls.Add(lblSeatC4);
            grpVenue.Controls.Add(lblSeatC3);
            grpVenue.Controls.Add(lblSeatC2);
            grpVenue.Controls.Add(lblSeatC1);
            grpVenue.Controls.Add(lblSeatB4);
            grpVenue.Controls.Add(lblSeatB3);
            grpVenue.Controls.Add(lblSeatB2);
            grpVenue.Controls.Add(lblSeatB1);
            grpVenue.Controls.Add(lblSeatA4);
            grpVenue.Controls.Add(lblSeatA3);
            grpVenue.Controls.Add(lblSeatA2);
            grpVenue.Controls.Add(lblSeatA1);
            grpVenue.Location = new Point(32, 57);
            grpVenue.Name = "grpVenue";
            grpVenue.Size = new Size(421, 319);
            grpVenue.TabIndex = 2;
            grpVenue.TabStop = false;
            grpVenue.Text = "Venue: ";
            // 
            // lblSeatC4
            // 
            lblSeatC4.BackColor = Color.Lime;
            lblSeatC4.BorderStyle = BorderStyle.FixedSingle;
            lblSeatC4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatC4.Location = new Point(325, 228);
            lblSeatC4.Margin = new Padding(3);
            lblSeatC4.Name = "lblSeatC4";
            lblSeatC4.Padding = new Padding(4);
            lblSeatC4.Size = new Size(70, 60);
            lblSeatC4.TabIndex = 11;
            lblSeatC4.Text = "C4";
            lblSeatC4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatC3
            // 
            lblSeatC3.BackColor = Color.Lime;
            lblSeatC3.BorderStyle = BorderStyle.FixedSingle;
            lblSeatC3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatC3.Location = new Point(225, 228);
            lblSeatC3.Margin = new Padding(3);
            lblSeatC3.Name = "lblSeatC3";
            lblSeatC3.Padding = new Padding(4);
            lblSeatC3.Size = new Size(70, 60);
            lblSeatC3.TabIndex = 10;
            lblSeatC3.Text = "C3";
            lblSeatC3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatC2
            // 
            lblSeatC2.BackColor = Color.Lime;
            lblSeatC2.BorderStyle = BorderStyle.FixedSingle;
            lblSeatC2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatC2.Location = new Point(125, 228);
            lblSeatC2.Margin = new Padding(3);
            lblSeatC2.Name = "lblSeatC2";
            lblSeatC2.Padding = new Padding(4);
            lblSeatC2.Size = new Size(70, 60);
            lblSeatC2.TabIndex = 9;
            lblSeatC2.Text = "C2";
            lblSeatC2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatC1
            // 
            lblSeatC1.BackColor = Color.Lime;
            lblSeatC1.BorderStyle = BorderStyle.FixedSingle;
            lblSeatC1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatC1.Location = new Point(25, 228);
            lblSeatC1.Margin = new Padding(3);
            lblSeatC1.Name = "lblSeatC1";
            lblSeatC1.Padding = new Padding(4);
            lblSeatC1.Size = new Size(70, 60);
            lblSeatC1.TabIndex = 8;
            lblSeatC1.Text = "C1";
            lblSeatC1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatB4
            // 
            lblSeatB4.BackColor = Color.Lime;
            lblSeatB4.BorderStyle = BorderStyle.FixedSingle;
            lblSeatB4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatB4.Location = new Point(325, 130);
            lblSeatB4.Margin = new Padding(3);
            lblSeatB4.Name = "lblSeatB4";
            lblSeatB4.Padding = new Padding(4);
            lblSeatB4.Size = new Size(70, 60);
            lblSeatB4.TabIndex = 7;
            lblSeatB4.Text = "B4";
            lblSeatB4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatB3
            // 
            lblSeatB3.BackColor = Color.Lime;
            lblSeatB3.BorderStyle = BorderStyle.FixedSingle;
            lblSeatB3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatB3.Location = new Point(225, 130);
            lblSeatB3.Margin = new Padding(3);
            lblSeatB3.Name = "lblSeatB3";
            lblSeatB3.Padding = new Padding(4);
            lblSeatB3.Size = new Size(70, 60);
            lblSeatB3.TabIndex = 6;
            lblSeatB3.Text = "B3";
            lblSeatB3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatB2
            // 
            lblSeatB2.BackColor = Color.Lime;
            lblSeatB2.BorderStyle = BorderStyle.FixedSingle;
            lblSeatB2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatB2.Location = new Point(125, 130);
            lblSeatB2.Margin = new Padding(3);
            lblSeatB2.Name = "lblSeatB2";
            lblSeatB2.Padding = new Padding(4);
            lblSeatB2.Size = new Size(70, 60);
            lblSeatB2.TabIndex = 5;
            lblSeatB2.Text = "B2";
            lblSeatB2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatB1
            // 
            lblSeatB1.BackColor = Color.Lime;
            lblSeatB1.BorderStyle = BorderStyle.FixedSingle;
            lblSeatB1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatB1.Location = new Point(25, 130);
            lblSeatB1.Margin = new Padding(3);
            lblSeatB1.Name = "lblSeatB1";
            lblSeatB1.Padding = new Padding(4);
            lblSeatB1.Size = new Size(70, 60);
            lblSeatB1.TabIndex = 4;
            lblSeatB1.Text = "B1";
            lblSeatB1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatA4
            // 
            lblSeatA4.BackColor = Color.Lime;
            lblSeatA4.BorderStyle = BorderStyle.FixedSingle;
            lblSeatA4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatA4.Location = new Point(325, 32);
            lblSeatA4.Margin = new Padding(3);
            lblSeatA4.Name = "lblSeatA4";
            lblSeatA4.Padding = new Padding(4);
            lblSeatA4.Size = new Size(70, 60);
            lblSeatA4.TabIndex = 3;
            lblSeatA4.Text = "A4";
            lblSeatA4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatA3
            // 
            lblSeatA3.BackColor = Color.Lime;
            lblSeatA3.BorderStyle = BorderStyle.FixedSingle;
            lblSeatA3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatA3.Location = new Point(225, 32);
            lblSeatA3.Margin = new Padding(3);
            lblSeatA3.Name = "lblSeatA3";
            lblSeatA3.Padding = new Padding(4);
            lblSeatA3.Size = new Size(70, 60);
            lblSeatA3.TabIndex = 2;
            lblSeatA3.Text = "A3";
            lblSeatA3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatA2
            // 
            lblSeatA2.BackColor = Color.Lime;
            lblSeatA2.BorderStyle = BorderStyle.FixedSingle;
            lblSeatA2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatA2.Location = new Point(125, 32);
            lblSeatA2.Margin = new Padding(3);
            lblSeatA2.Name = "lblSeatA2";
            lblSeatA2.Padding = new Padding(4);
            lblSeatA2.Size = new Size(70, 60);
            lblSeatA2.TabIndex = 1;
            lblSeatA2.Text = "A2";
            lblSeatA2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatA1
            // 
            lblSeatA1.BackColor = Color.Lime;
            lblSeatA1.BorderStyle = BorderStyle.FixedSingle;
            lblSeatA1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatA1.Location = new Point(25, 32);
            lblSeatA1.Margin = new Padding(3);
            lblSeatA1.Name = "lblSeatA1";
            lblSeatA1.Padding = new Padding(4);
            lblSeatA1.Size = new Size(70, 60);
            lblSeatA1.TabIndex = 0;
            lblSeatA1.Text = "A1";
            lblSeatA1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRow
            // 
            lblRow.AutoSize = true;
            lblRow.Location = new Point(500, 57);
            lblRow.Name = "lblRow";
            lblRow.Size = new Size(47, 20);
            lblRow.TabIndex = 4;
            lblRow.Text = "Rows:";
            // 
            // lblCol
            // 
            lblCol.AutoSize = true;
            lblCol.BackColor = SystemColors.Control;
            lblCol.Location = new Point(642, 57);
            lblCol.Name = "lblCol";
            lblCol.Size = new Size(69, 20);
            lblCol.TabIndex = 6;
            lblCol.Text = "Columns:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(500, 213);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(119, 20);
            lblCustomerName.TabIndex = 7;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(500, 236);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(261, 27);
            txtCustomerName.TabIndex = 8;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(500, 285);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(62, 29);
            btnBook.TabIndex = 9;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(570, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(62, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddWaitingList
            // 
            btnAddWaitingList.Location = new Point(641, 285);
            btnAddWaitingList.Name = "btnAddWaitingList";
            btnAddWaitingList.Size = new Size(120, 29);
            btnAddWaitingList.TabIndex = 11;
            btnAddWaitingList.Text = "Add to Waitlist";
            btnAddWaitingList.UseVisualStyleBackColor = true;
            // 
            // btnFillAllSeats
            // 
            btnFillAllSeats.Location = new Point(500, 320);
            btnFillAllSeats.Name = "btnFillAllSeats";
            btnFillAllSeats.Size = new Size(100, 29);
            btnFillAllSeats.TabIndex = 12;
            btnFillAllSeats.Text = "Fill all seats";
            btnFillAllSeats.UseVisualStyleBackColor = true;
            // 
            // lstRow
            // 
            lstRow.FormattingEnabled = true;
            lstRow.Items.AddRange(new object[] { "A", "B", "C" });
            lstRow.Location = new Point(500, 80);
            lstRow.Name = "lstRow";
            lstRow.Size = new Size(119, 124);
            lstRow.TabIndex = 14;
            // 
            // lstCol
            // 
            lstCol.FormattingEnabled = true;
            lstCol.Items.AddRange(new object[] { "1", "2", "3", "4" });
            lstCol.Location = new Point(642, 80);
            lstCol.Name = "lstCol";
            lstCol.Size = new Size(119, 124);
            lstCol.TabIndex = 15;
            // 
            // btnCancelAllBookings
            // 
            btnCancelAllBookings.Location = new Point(607, 320);
            btnCancelAllBookings.Name = "btnCancelAllBookings";
            btnCancelAllBookings.Size = new Size(154, 29);
            btnCancelAllBookings.TabIndex = 13;
            btnCancelAllBookings.Text = "Cancel all bookings";
            btnCancelAllBookings.UseVisualStyleBackColor = true;
            // 
            // FormVenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 434);
            Controls.Add(lstCol);
            Controls.Add(lstRow);
            Controls.Add(btnCancelAllBookings);
            Controls.Add(btnFillAllSeats);
            Controls.Add(btnAddWaitingList);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCol);
            Controls.Add(lblRow);
            Controls.Add(grpVenue);
            Controls.Add(lblFooter);
            Controls.Add(lblHeader);
            Name = "FormVenue";
            Text = "Venue: PROG1965 Assignment 1";
            Load += FormVenue_Load;
            grpVenue.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblFooter;
        private GroupBox grpVenue;
        private Label lblSeatA1;
        private Label lblSeatB4;
        private Label lblSeatB3;
        private Label lblSeatB2;
        private Label lblSeatB1;
        private Label lblSeatA4;
        private Label lblSeatA3;
        private Label lblSeatA2;
        private Label lblSeatC4;
        private Label lblSeatC3;
        private Label lblSeatC2;
        private Label lblSeatC1;
        private Label lblRow;
        private Label lblCol;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Button btnBook;
        private Button btnCancel;
        private Button btnAddWaitingList;
        private Button btnFillAllSeats;
        private ListBox lstRow;
        private ListBox lstCol;
        private Button btnCancelAllBookings;
    }
}
