using Microsoft.AspNet.SignalR;
using Web.Models;

namespace Web.Hubs
{
    public class CommentHub : Hub
    {
        public void Send(Comment comment)
        {
            // persist the new comment (add to the beginning of the list)
            Comments.All.Insert(0, comment);

            // Update all clients with the new comment.
            Clients.Others.newComment(comment);
        }
    }
}