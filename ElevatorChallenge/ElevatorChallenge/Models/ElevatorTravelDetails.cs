using ElevatorChallenge.Enums;

namespace ElevatorChallenge.Models
{
    public class ElevatorTravelDetails
    {
        public ElevatorDirection Direction { get; set; }
       
        public IEnumerable<int> FloorsToStop { get; set; }
    }
}
