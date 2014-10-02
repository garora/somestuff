using System.Web.Mvc;
using ConsumeWebAPI.Helper;

namespace ConsumeWebAPI.Controllers
{
    public class ServerDataController : Controller
    {
        static readonly IServerDataRestClient RestClient = new ServerDataRestClient();
        //
        // GET: /ServerData/

        public ActionResult Index()
        {
            return View(RestClient.GetAll());
        }

        //
        // GET: /ServerData/Details/5

        public ActionResult Details(int id)
        {
            return View(RestClient.GetById(id));
        }

        //
        // GET: /ServerData/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ServerData/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ServerData/Edit/5

        public ActionResult Edit(int id)
        {
            return View(RestClient.GetById(id));
        }

        //
        // POST: /ServerData/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ServerData/Delete/5

        public ActionResult Delete(int id)
        {
            return View(RestClient.GetById(id));
        }

        //
        // POST: /ServerData/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
