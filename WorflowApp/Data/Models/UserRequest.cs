

namespace Data.Models
{
    public class UserRequest
    {
        public int UserId { get; set; }
        public int RequestId { get; set; }

        public virtual User User { get; set; }
        public virtual Request Request { get; set; }

        public UserRequest() { }

        public UserRequest (int userId, int requestId, User user, Request request)
        {
            UserId = userId;
            RequestId = requestId;
            User = user;
            Request = request;
        }
    }
}
