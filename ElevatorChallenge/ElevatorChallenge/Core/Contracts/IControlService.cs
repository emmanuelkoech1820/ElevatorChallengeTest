using ElevatorChallenge.Models;

namespace ElevatorChallenge.Core.Contracts
{
    public interface IControlService
    {
        Task AddPickUpRequest(PassengerRequest request);
        IEnumerable<PassengerRequest> GetPendingPassengerRequests();
        ElevatorConfiguration GetConfigDetails();
        Task<IEnumerable<ElevatorStatus>> GetElevatorStatuses();
        Task<IEnumerable<IElevatorManager>> GetElevators();
    }
}
