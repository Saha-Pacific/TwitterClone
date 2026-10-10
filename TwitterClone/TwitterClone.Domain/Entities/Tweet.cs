
namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        
        private Guid _userId;
        private string _content;
       
        public Tweet() : base(Guid.NewGuid( ))
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
        public string Content
        {
            get { return _content; }
            set { _content = value; }
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
