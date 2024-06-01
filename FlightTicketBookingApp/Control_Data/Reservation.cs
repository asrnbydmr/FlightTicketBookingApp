# pragma warning disable

using FlightTicketBookingApp.Models;

namespace FlightTicketBookingApp.Control_Data
{
    public static class Reservation
    {
        public static void save(ModelReservation reservation)
        {
            if (DB.ControlDB())
            {
                DB.dbContext.reservations.Add(reservation);
                DB.dbContext.SaveChanges();
                loadData();
                MainForm.panelSittingRegulation.Controls.Clear();
                fillSeat();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void update(ModelReservation reservation)
        {
            if (DB.ControlDB())
            {
                if (MainForm.dataGridViewReservation.SelectedRows.Count > 0)
                {
                    int id = int.Parse(MainForm.dataGridViewReservation.SelectedRows[0].Cells[0].Value.ToString());
                    ModelReservation selectedReservation = DB.dbContext.reservations.Find(id);
                    if (selectedReservation != null)
                    {
                        selectedReservation.AircraftId = reservation.AircraftId;
                        selectedReservation.LocationId = reservation.LocationId;
                        selectedReservation.Date = reservation.Date;
                        selectedReservation.CustomerName = reservation.CustomerName;
                        selectedReservation.CustomerSurname = reservation.CustomerSurname;
                        selectedReservation.CustomerIDNo = reservation.CustomerIDNo;
                        selectedReservation.CustomerGender = reservation.CustomerGender;
                        selectedReservation.SeatNo = reservation.SeatNo;
                        DB.dbContext.SaveChanges();
                        loadData();
                        MainForm.panelSittingRegulation.Controls.Clear();
                        fillSeat();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void delete()
        {
            if (DB.ControlDB())
            {
                if (MainForm.dataGridViewReservation.SelectedRows.Count > 0)
                {
                    int id = int.Parse(MainForm.dataGridViewReservation.SelectedRows[0].Cells[0].Value.ToString());
                    ModelReservation selectedReservation = DB.dbContext.reservations.Find(id);
                    if (selectedReservation != null)
                    {
                        DB.dbContext.reservations.Remove(selectedReservation);
                        DB.dbContext.SaveChanges();
                        loadData();
                        MainForm.panelSittingRegulation.Controls.Clear();
                        fillSeat();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void loadData()
        {
            if (DB.ControlDB())
            {
                MainForm.dataGridViewReservation.DataSource = DB.dbContext.reservations.ToList();

                MainForm.dataGridViewReservation.Columns[0].Visible = false;
                MainForm.dataGridViewReservation.Columns[1].Visible = false;
                MainForm.dataGridViewReservation.Columns[2].Visible = false;
                MainForm.dataGridViewReservation.Columns[3].Visible = false;
                MainForm.dataGridViewReservation.Columns[4].HeaderText = "Name";
                MainForm.dataGridViewReservation.Columns[5].HeaderText = "Surname";
                MainForm.dataGridViewReservation.Columns[6].HeaderText = "ID No";
                MainForm.dataGridViewReservation.Columns[7].HeaderText = "Gender";
                MainForm.dataGridViewReservation.Columns[8].HeaderText = "Seat No";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void clearData()
        {
            MainForm.txtTCIdentityNumber.Text = null;
            MainForm.txtName.Text = null;
            MainForm.txtSurname.Text = null;
            MainForm.comboGender.SelectedItem = "";
            MainForm.datePicker.Value = DateTime.Now;
        }

        public static void fillAircraft()
        {
            if (DB.ControlDB())
            {
                var aircrafts = DB.dbContext.aircrafts.ToList();
                MainForm.comboAircraft.DataSource = aircrafts;
                MainForm.comboAircraft.DisplayMember = "AircraftModel";
                MainForm.comboAircraft.ValueMember = "IdAircraft";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillLocation()
        {
            if (DB.ControlDB())
            {
                var locations = DB.dbContext.locations.Where(obj => obj.ActivePassive == true).ToList();
                MainForm.comboLocation.DataSource = locations;
                MainForm.comboLocation.DisplayMember = "Airport";
                MainForm.comboLocation.ValueMember = "IdLocation";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillSeat()
        {
            List<int> seats = DB.dbContext.reservations.Select(obj => obj.SeatNo).ToList();

            int x = 20;
            int y = 20;
            int buttonWidth = 75;
            int buttonHeight = 23;
            int tabIndex = 1;

            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Button button = new Button();
                    button.Text = $"{tabIndex}";
                    button.Location = new System.Drawing.Point(x, y);
                    button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    button.TabIndex = tabIndex;
                    if (seats.Contains(tabIndex))
                        button.BackColor = System.Drawing.Color.Red;
                    else
                        button.BackColor = System.Drawing.Color.Green;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Click += button_Click;
                    MainForm.panelSittingRegulation.Controls.Add(button);

                    x += buttonWidth + 1;
                    tabIndex++;

                    if (col == 1)
                    {
                        x += buttonWidth + 1;
                    }
                }

                x = 20;
                y += buttonHeight + 1;
            }
        }

        private static void button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int seat = int.Parse(button.Text);
                MainForm.seatNo = seat;
            }
        }
    }
}
