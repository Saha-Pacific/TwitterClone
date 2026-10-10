namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
        
        private Guid _userId;
        private Guid _tweetId;
        

        public Like() : base(Guid.NewGuid( ))
        {
            
        }
        public Guid Id
        {
            get { return _id; }
        }
        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public DateTime? ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
        public DateTime CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
        public DateTime? ModifiedBy
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }
    }
}
