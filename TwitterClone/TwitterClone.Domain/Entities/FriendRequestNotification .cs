namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid friendRequestByUserId) : base("FriendRequest")
        {
            FriendRequestByUserId = friendRequestByUserId;
        }
        public Guid FriendRequestByUserId { get; set; }
        public void AddMessage (string message)
        {
            Message = message;
        }

    }
}
