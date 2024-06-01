# pragma warning disable

namespace FlightTicketBookingApp.Models
{
    public partial class ModelReservation
    {
        public int IdReservation { get; set; }
        public int AircraftId { get; set; }
        public int LocationId { get; set; }
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerIDNo { get; set; }
        public string CustomerGender { get; set; }
        public int SeatNo { get; set; }
    }
}
