namespace ElevatorChallenge.Models
{
    public class ElevatorConfiguration
    {
        public int TotalElevators { get; set; }
        public int TotalFloors { get; set; }
        public int ElevatorMaximumWeight { get; set; }
        public DelayConfiguration DelayInSeconds { get; set; }
    }

    public class DelayConfiguration
    {
        public int HandlingPassengers { get; set; } = 5;
       
        public int MovingToNextLevel { get; set; } = 1;
    }
}
