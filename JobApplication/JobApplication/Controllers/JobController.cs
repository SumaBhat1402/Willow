using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JobApplication.Repository;
using System.Web.Http;

namespace JobApplication.Controllers
{
    public class JobController : Controller
    {
        private IRepository _repo;
        public JobController(IRepository repo)
        {
            _repo = repo;
        }
        public ActionResult Index()
        {
            var model = _repo.GetJobsData();

            return View(model);
        }
        [System.Web.Mvc.HttpPost]
        public void Index([FromBody]int JobId)
        {           
            _repo.UpdateJobStatus(JobId);            
        }
    }
}