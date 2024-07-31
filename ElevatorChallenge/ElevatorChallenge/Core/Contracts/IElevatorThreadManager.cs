namespace ElevatorChallenge.Core.Contracts
{
    public interface IElevatorThreadManager
    {
        void StartElevatorThreadsAsync(IEnumerable<IElevatorManager> elevators);
    }
}
