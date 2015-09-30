using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProxy.Context;

namespace TestForCompulsory.Controllers
{
    public class FileController : Controller
    {
        private ShopContextConnection db = new ShopContextConnection();
        // GET: File      
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.File.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}