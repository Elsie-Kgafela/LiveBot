using LiveBot.Core.Repository.Models.Streams;

namespace LiveBot.Core.Repository.Interfaces.Streams
{
    /// <summary>
    /// Interface for Database interaction with a Stream Subscription
    /// </summary>
    public interface ISubscriptionRepository : IRepository<StreamSubscription>
    {
    }
}