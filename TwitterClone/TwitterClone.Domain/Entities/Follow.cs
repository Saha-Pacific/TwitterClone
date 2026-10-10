namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
       
        private Guid _followerId;
        private Guid _followingId;
      


        public Follow () : base(Guid.NewGuid( ))
        {
           
        }
        public Guid Id
        {
            get { return _id; }
        }
        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }
        public Guid FollowingId
        {
            get { return _followingId ; }
            set { _followingId = value; }
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
        public DateTime CreatedBy {
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
