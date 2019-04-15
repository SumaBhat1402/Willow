using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobApplication.Models;


namespace JobApplication.Repository
{
    public interface IRepository
    {
        JobViewModel GetJobsData();
        void UpdateJobStatus(int JobId);
    }
}