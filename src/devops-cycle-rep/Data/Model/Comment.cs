namespace Data.Model
{
    public class Comment : BaseModel
    {
        public string CommentText { get; set; }
        public string CommentType { get; set; }
        public Guid PostId { get; set; }
    }
}