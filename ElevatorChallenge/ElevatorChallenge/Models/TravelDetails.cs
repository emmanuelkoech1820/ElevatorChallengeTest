using ElevatorChallenge.Enums;

namespace ElevatorChallenge.Models
{
    public class TravelDetails
    {
        public ElevatorDirection ElevatorDirection { get; set; }
        public IEnumerable<int> FloorToStopAtWithinTravelDirection { get; set; } = Enumerable.Empty<int>();
    }
}
