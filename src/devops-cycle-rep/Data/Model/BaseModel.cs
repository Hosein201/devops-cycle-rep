namespace Data.Model
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsConfierm { get; set; }
        public bool IsActive { get; set; }
    }
}