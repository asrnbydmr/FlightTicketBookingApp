# pragma warning disable

namespace FlightTicketBookingApp.Models
{
    public partial class ModelAircraft
    {
        public int IdAircraft { get; set; }
        public string AircraftModel { get; set; }
        public string AircraftBrand { get; set; }
        public string AircraftSerialNo { get; set; }
        public int AircraftSeatCapacity { get; set; }
    }
}
