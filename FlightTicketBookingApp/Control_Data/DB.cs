# pragma warning disable

namespace FlightTicketBookingApp.Control_Data
{
    public static class DB
    {
        public static DBContext dbContext = new DBContext();
        public static string DBPath = "DB.db";

        public static bool ControlDB()
        {
            return File.Exists(DBPath);
        }
    }
}
