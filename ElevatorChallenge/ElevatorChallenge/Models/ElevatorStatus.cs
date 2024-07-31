using ElevatorChallenge.Enums;
namespace ElevatorChallenge.Models
{
    public class ElevatorStatus
    {
        public int ElevatorNumber { get; set; }        
        public int CurrentFloor { get; set; }
        public ElevatorDirection Direction { get; set; }
        public int Load { get; set; }
        public string Name { get; set; }
    }
}
