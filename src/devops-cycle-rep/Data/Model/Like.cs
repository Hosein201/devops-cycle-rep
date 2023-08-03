namespace Data.Model
{
    public class Like : BaseModel
    {
        public Guid PostId { get; set; }
        public Guid Comment { get; set; }
        public int TypeLike { get; set; }
    }
}