using ElevatorChallenge.Core.Contracts;
using ElevatorChallenge.Core.Implementations;

public class ElevatorThreadManager : IElevatorThreadManager
{
    private List<Task> _elevatorTasks = new List<Task>();
    public ElevatorThreadManager()
    {
    }

    public void StartElevatorThreadsAsync(IEnumerable<IElevatorManager> elevators)
    {
        // Start each elevator in its own thread
        foreach (var elevator in elevators)
        {
            StartElevatorThread(elevator);
        }
    }

    private void StartElevatorThread(IElevatorManager elevator)
    {
        Task.Run(async () =>
        {
            while (true)
            {
                if (elevator.HasPendingRequests())
                {
                    await elevator.MoveToNextLevelAsync();
                    await Task.Delay(TimeSpan.FromSeconds(2));
                }
            }
        });
    }
}
