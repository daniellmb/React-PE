using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using Web.Hubs;
using Web.Models;

namespace Web.Controllers
{
    public class CommentController : Controller
    {
        // POST: Comment/Create
        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            // persist the new comment (add to the beginning of the list)
            Comments.All.Insert(0, comment);
                
            // Update all clients with the new comment.
            var hub = GlobalHost.ConnectionManager.GetHubContext<CommentHub>();            
            hub.Clients.All.newComment(comment);

            // refresh the page
            return RedirectToAction("Index", "Home");
        }
    }
}