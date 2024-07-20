public class Comment{
    public string _commenterName;
    public string _commentText;

    public Comment(string commenterName, string commentText){
        _commenterName = commenterName;
        _commentText = commentText; 
    }

    public string CommentString()
    {
        return $"Commenter: {_commenterName}, Comment: {_commentText}"; 
    }
}