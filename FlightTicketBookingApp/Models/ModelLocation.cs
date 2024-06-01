# pragma warning disable

namespace FlightTicketBookingApp.Models
{
    public partial class ModelLocation
    {
        public int IdLocation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Airport { get; set; }
        public bool ActivePassive { get; set; }
    }
}
