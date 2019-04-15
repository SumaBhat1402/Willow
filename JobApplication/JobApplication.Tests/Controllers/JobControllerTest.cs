using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using JobApplication.Repository;
using JobApplication.Controllers;
using System.Web.Mvc;

namespace JobApplication.Tests.Controllers
{
    [TestClass]
    public class JobControllerTest
    {
        private IRepository _repository;
        private JobController _ctrl;

        [TestInitialize]
        public void Init()
        {
            _repository = Substitute.For<IRepository>();
            _ctrl = new JobController(_repository);
        }
        [TestMethod]
        public void GetViewShouldNotThrow()
        {
           var actionResult= _ctrl.Index();
            Assert.IsTrue(actionResult.GetType() == typeof(ViewResult));
        }
        [TestMethod]
        public void GetMakesRepoistoryCalledOnce()
        {
            var actionResult = _ctrl.Index();
            _repository.Received(1).GetJobsData();
        }     
    }
}
