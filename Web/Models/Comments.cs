using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Web.Models
{
    // Could be loaded from a DB, but an in-memory collection is fine for this example
    public static class Comments
    {
        public static IList<Comment> All { get; private set; }

        static Comments()
        {
            // Parse the XML
            var xmlFilename = HttpContext.Current.Server.MapPath("~/App_Data/Comments/RawCommentsData.xml");
            var xml = XDocument.Load(xmlFilename);
            var comments = from s in xml.Root.Elements("Comment")
                           select new Comment
                           {
                               Author = s.Element("Author").Value,
                               Text = s.Element("Text").Value
                           };
            All = comments.ToList();
        }
    }
}