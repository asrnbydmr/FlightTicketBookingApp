# pragma warning disable

using FlightTicketBookingApp.Models;

namespace FlightTicketBookingApp.Control_Data
{
    public static class Location
    {
        public static void save(ModelLocation location)
        {
            if (DB.ControlDB())
            {
                DB.dbContext.locations.Add(location);
                DB.dbContext.SaveChanges();
                loadData();
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void update(ModelLocation location)
        {
            if (DB.ControlDB())
            {
                if (MainForm.dataGridViewLocation.SelectedRows.Count > 0)
                {
                    int id = int.Parse(MainForm.dataGridViewLocation.SelectedRows[0].Cells[0].Value.ToString());
                    ModelLocation selectedLocation = DB.dbContext.locations.Find(id);
                    if (selectedLocation != null)
                    {
                        selectedLocation.Country = location.Country;
                        selectedLocation.City = location.City;
                        selectedLocation.Airport = location.Airport;
                        selectedLocation.ActivePassive = location.ActivePassive;
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
                if (MainForm.dataGridViewLocation.SelectedRows.Count > 0)
                {
                    int id = int.Parse(MainForm.dataGridViewLocation.SelectedRows[0].Cells[0].Value.ToString());
                    ModelLocation selectedLocation = DB.dbContext.locations.Find(id);
                    if (selectedLocation != null)
                    {
                        DB.dbContext.locations.Remove(selectedLocation);
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
                MainForm.dataGridViewLocation.DataSource = DB.dbContext.locations.ToList();

                MainForm.dataGridViewLocation.Columns[0].HeaderText = "Location ID";
                MainForm.dataGridViewLocation.Columns[1].HeaderText = "Country";
                MainForm.dataGridViewLocation.Columns[2].HeaderText = "City";
                MainForm.dataGridViewLocation.Columns[3].HeaderText = "Airport";
                MainForm.dataGridViewLocation.Columns[4].HeaderText = "Active Passive";
            }
            else
            {
                MessageBox.Show("Error Establishing Connection with Database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void clearData()
        {
            MainForm.comboCountry.SelectedItem = "";
            MainForm.comboCity.SelectedItem = "";
            MainForm.comboAirport.SelectedItem = "";
            MainForm.comboActivePassive.SelectedItem = "";
        }
    }
}
