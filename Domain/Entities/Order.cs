using Domain.Common;

namespace Domain.Entities
{
    public class Order : AuditableEntity
    {
        public int Id { get; set; }
        public int NumberOfItems { get; set; }
        public int CustomerId { get; set; }
    }
}
