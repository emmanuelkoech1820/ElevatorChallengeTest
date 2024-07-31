using ElevatorChallenge.Models;

namespace ElevatorChallenge.Core.Contracts
{
    public interface IElevatorManager
    {
        ElevatorStatus CurrentStatus { get; }
        Task<ElevatorStatus> MoveToNextLevelAsync();
        Task QueuePassengerRequest(PassengerRequest passengerRequest);
        bool HasPendingRequests();
    }
}
