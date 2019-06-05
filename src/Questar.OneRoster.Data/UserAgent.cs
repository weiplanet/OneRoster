namespace Questar.OneRoster.Data
{
    public class UserAgent
    {
        internal UserAgent()
        {
        }

        public UserAgent(User agent)
        {
            Agent = agent;
        }

        public virtual User User { get; internal set; }

        public virtual int UserId { get; internal set; }

        public virtual User Agent { get; internal set; }

        public virtual int AgentId { get; internal set; }
    }
}