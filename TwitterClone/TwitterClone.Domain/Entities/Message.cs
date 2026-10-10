namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
       
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sendAt;
        private bool _isRead;
        

        public Message( ) : base(Guid.NewGuid( ))
        {

        }
        public Guid Id
        {
            get { return _id; }
        }
        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }
        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value;  }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime SendAt
        {
            get { return _sendAt; }
            set { _sendAt = value; }
        }
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead  = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public DateTime? ModifiedAt
        {
            get {  return _modifiedAt; }
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
