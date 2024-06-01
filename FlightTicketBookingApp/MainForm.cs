# pragma warning disable

using FlightTicketBookingApp.Control_Data;
using FlightTicketBookingApp.Models;

namespace FlightTicketBookingApp
{
    public partial class MainForm : Form
    {
        public static int seatNo = 0;

        public MainForm()
        {
            InitializeComponent();

            LocationGenerate.fillCountries();

            Aircraft.loadData();
            Control_Data.Location.loadData();
            Reservation.loadData();

            Reservation.fillSeat();
        }

        #region button

        private void btnAircraft_Click(object sender, EventArgs e)
        {
            if (txtAircraftModel.Text != string.Empty && txtAircraftBrand.Text != string.Empty && txtAircraftSerialNo.Text != string.Empty && txtAircraftSeatCapacity.Text != string.Empty && seatNo != 0)
            {
                ModelAircraft aircraft = new ModelAircraft
                {
                    AircraftModel = txtAircraftModel.Text,
                    AircraftBrand = txtAircraftBrand.Text,
                    AircraftSerialNo = txtAircraftSerialNo.Text,
                    AircraftSeatCapacity = int.Parse(txtAircraftSeatCapacity.Text)
                };

                if (sender == btnSaveAircraft)
                    Aircraft.save(aircraft);
                if (sender == btnUpdateAircraft)
                    Aircraft.update(aircraft);
                if (sender == btnDeleteAircraft)
                    Aircraft.delete();

                Aircraft.clearData();
            }
            else
            {
                MessageBox.Show("Do Not Leave Empty Space.", "Free Space Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (comboCountry.SelectedValue != null && comboCity.SelectedValue != null && comboAirport.SelectedValue != null && comboActivePassive.SelectedIndex != 0)
            {
                bool status = false;
                if (comboActivePassive.SelectedItem.ToString() == "Active")
                    status = true;

                ModelLocation location = new ModelLocation
                {
                    Country = comboCountry.SelectedItem.ToString(),
                    City = comboCity.SelectedItem.ToString(),
                    Airport = comboAirport.SelectedItem.ToString(),
                    ActivePassive = status
                };

                if (sender == btnSaveLocation)
                    Control_Data.Location.save(location);
                if (sender == btnUpdateLocation)
                    Control_Data.Location.update(location);
                if (sender == btnDeleteLocation)
                    Control_Data.Location.delete();

                Control_Data.Location.clearData();
            }
            else
            {
                MessageBox.Show("Do Not Leave Empty Space.", "Free Space Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (comboAircraft.SelectedValue != null && comboLocation.SelectedValue != null && datePicker.Value != null && txtName.Text != string.Empty && txtSurname.Text != string.Empty && txtTCIdentityNumber.Text != string.Empty && comboGender.SelectedItem != "" && seatNo > 0)
            {
                if (datePicker.Value.Date >= DateTime.Now.Date)
                {
                    if (txtTCIdentityNumber.Text.Length == 11)
                    {
                        ModelReservation reservation = new ModelReservation
                        {
                            AircraftId = (int)comboAircraft.SelectedValue,
                            LocationId = (int)comboLocation.SelectedValue,
                            Date = datePicker.Value,
                            CustomerName = txtName.Text,
                            CustomerSurname = txtSurname.Text,
                            CustomerIDNo = txtTCIdentityNumber.Text,
                            CustomerGender = comboGender.SelectedItem.ToString(),
                            SeatNo = seatNo
                        };

                        if (sender == btnSaveReservation)
                            Reservation.save(reservation);
                        if (sender == btnUpdateReservation)
                            Reservation.update(reservation);
                        if (sender == btnDeleteReservation)
                            Reservation.delete();

                        Reservation.clearData();

                        seatNo = 0;
                    }
                    else
                    {
                        MessageBox.Show("T.C. Identity Number Consists of 11 Digits.", "Data Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Cannot Select A Date Before Today.", "Data Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Do Not Leave Empty Space.", "Free Space Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion button

        #region dataGridView

        private void dataGridViewAircraft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DB.ControlDB())
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewAircraft.Rows[e.RowIndex];
                    txtAircraftModel.Text = row.Cells["AircraftModel"].Value.ToString();
                    txtAircraftBrand.Text = row.Cells["AircraftBrand"].Value.ToString();
                    txtAircraftSerialNo.Text = row.Cells["AircraftSerialNo"].Value.ToString();
                    txtAircraftSeatCapacity.Text = row.Cells["AircraftSeatCapacity"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DB.ControlDB())
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewLocation.Rows[e.RowIndex];
                    comboCountry.SelectedItem = row.Cells["Country"].Value.ToString();
                    comboCity.SelectedItem = row.Cells["City"].Value.ToString();
                    comboAirport.SelectedItem = row.Cells["Airport"].Value.ToString();
                    if (Convert.ToBoolean(row.Cells["ActivePassive"].Value))
                        comboActivePassive.SelectedItem = "Active";
                    else
                        comboActivePassive.SelectedItem = "Passive";
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DB.ControlDB())
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                    comboAircraft.SelectedItem = row.Cells["AircraftId"].Value.ToString();
                    comboLocation.SelectedItem = row.Cells["LocationId"].Value.ToString();
                    datePicker.Value = (DateTime)row.Cells["Date"].Value;
                    txtName.Text = row.Cells["CustomerName"].Value.ToString();
                    txtSurname.Text = row.Cells["CustomerSurname"].Value.ToString();
                    txtTCIdentityNumber.Text = row.Cells["CustomerIDNo"].Value.ToString();
                    comboGender.SelectedItem = row.Cells["CustomerGender"].Value.ToString();
                    seatNo = int.Parse(row.Cells["SeatNo"].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion dataGridView

        private void tabControl1_Click(object sender, EventArgs e)
        {
            Reservation.fillAircraft();
            Reservation.fillLocation();
        }

        #region comboBox

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationGenerate.fillCities(comboCountry.SelectedItem.ToString());
            comboCity.SelectedIndex = -1;
            comboAirport.DataSource = null;
        }

        private void comboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCity.SelectedIndex >= 0)
            {
                LocationGenerate.fillAirports(comboCountry.SelectedItem.ToString(), comboCity.SelectedItem.ToString());
                comboAirport.SelectedIndex = -1;
            }
        }

        #endregion comboBox

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
