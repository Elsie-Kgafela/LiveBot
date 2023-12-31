using System;

namespace LiveBot.Core.Repository.Interfaces.Monitor
{
    /// <summary>
    /// Represents a generic Stream for use within the bot, usually returned by a Monitoring Service
    /// </summary>
    public interface ILiveBotStream : ILiveBotBase
    {
        public ILiveBotUser User { get; set; }
        public ILiveBotGame Game { get; set; }
        public string UserId { get; set; }
        public string GameId { get; set; }
        public string Id { get; }
        public string Title { get; }
        public DateTime StartTime { get; }
        public string ThumbnailURL { get; }
        public string StreamURL { get; set; }
    }
}