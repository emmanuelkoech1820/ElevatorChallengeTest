using ElevatorChallenge.Models;

namespace ElevatorChallenge.Core.Contracts
{
    public interface IElevatorMotion
    {
        Task<ElevatorTravelDetails> GetElevatorTravelDetailsAsync(ElevatorStatus elevator,
            IEnumerable<PassengerRequest> passengerRequestQueue,
            IEnumerable<PassengerRequest> passengersInTransit);
        Task<bool> HasPendingRequestsFromCurrentFloor(int currentFloor,
            IEnumerable<PassengerRequest> passengerRequestQueue,
            IEnumerable<PassengerRequest> passengersInTransit);
    }
}
