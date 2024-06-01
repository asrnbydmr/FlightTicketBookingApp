# pragma warning disable

using FlightTicketBookingApp.Models;

namespace FlightTicketBookingApp.Control_Data
{
    public static class Aircraft
    {
        public static void save(ModelAircraft aircraft)
        {
            if (DB.ControlDB())
            {
                DB.dbContext.aircrafts.Add(aircraft);
                DB.dbContext.SaveChanges();
                loadData();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void update(ModelAircraft aircraft)
        {
            if (DB.ControlDB())
            {
                if (MainForm.dataGridViewAircraft.SelectedRows.Count > 0)
                {
                    int id = int.Parse(MainForm.dataGridViewAircraft.SelectedRows[0].Cells[0].Value.ToString());
                    ModelAircraft selectedAircraft = DB.dbContext.aircrafts.Find(id);
                    if (selectedAircraft != null)
                    {
                        selectedAircraft.AircraftModel = aircraft.AircraftModel;
                        selectedAircraft.AircraftBrand = aircraft.AircraftBrand;
                        selectedAircraft.AircraftSerialNo = aircraft.AircraftSerialNo;
                        selectedAircraft.AircraftSeatCapacity = aircraft.AircraftSeatCapacity;
                        DB.dbContext.SaveChanges();
                        loadData();
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
                if (MainForm.dataGridViewAircraft.SelectedRows.Count > 0)
                {
                    int id = int.Parse(MainForm.dataGridViewAircraft.SelectedRows[0].Cells[0].Value.ToString());
                    ModelAircraft selectedAircraft = DB.dbContext.aircrafts.Find(id);
                    if (selectedAircraft != null)
                    {
                        DB.dbContext.aircrafts.Remove(selectedAircraft);
                        DB.dbContext.SaveChanges();
                        loadData();
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
                MainForm.dataGridViewAircraft.DataSource = DB.dbContext.aircrafts.ToList();

                MainForm.dataGridViewAircraft.Columns[0].HeaderText = "Aircraft ID";
                MainForm.dataGridViewAircraft.Columns[1].HeaderText = "Aircraft Model";
                MainForm.dataGridViewAircraft.Columns[2].HeaderText = "Aircraft Brand";
                MainForm.dataGridViewAircraft.Columns[3].HeaderText = "Aircraft Serial No";
                MainForm.dataGridViewAircraft.Columns[4].HeaderText = "Aircraft Seat Capacity";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void clearData()
        {
            MainForm.txtAircraftModel.Text = null;
            MainForm.txtAircraftBrand.Text = null;
            MainForm.txtAircraftSerialNo.Text = null;
            MainForm.txtAircraftSeatCapacity.Text = null;
        }
    }
}
