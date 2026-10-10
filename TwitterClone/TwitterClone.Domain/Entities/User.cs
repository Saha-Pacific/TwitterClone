
namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
       
        private string _firstName ;
        private string _lastName ;
        private string _email ;
       

        public User() : base(Guid.NewGuid( ))
        {
            
        }
        public Guid Id
        {
            get { return _id; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public DateTime? ModifiedAt
        {
            get { return _modifiedAt; }
            set {_modifiedAt = value; }
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
