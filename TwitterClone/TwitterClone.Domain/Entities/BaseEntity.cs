namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid _id ;
        public DateTime _createdAt ;
        public DateTime? _modifiedAt ;
        public DateTime _createdBy;
        public DateTime? _modifiedBy;
        public BaseEntity ( Guid Id )
        {
            _id = Id;
            _createdAt = DateTime.UtcNow;
        }
    }
}
