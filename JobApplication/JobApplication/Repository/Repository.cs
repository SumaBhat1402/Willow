using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobApplication.Models;
using System.Data.SqlClient;

namespace JobApplication.Repository
{
    public class Repository : IRepository
    {
        private DemoEntities _db;

        public Repository(DemoEntities db)
        {
            _db = db;
        }   

        public JobViewModel  GetJobsData()
        {           
            var sql = @"select job.JobID as JobId, job.Floor as Floor,job.Name as Name,job.status as JobStatus,roomtype.Description as RoomTypeDescription
                from [rx_job] as job inner join [rx_roomtype] as roomtype
                on roomtype.Id= job.RoomTypeId";

            var jobs = _db.Database.SqlQuery<Job>(sql).ToList();
            var jobList = new List<Job>();          
           
            foreach (var item in jobs)
            {
                var job = new Job()
                {
                    JobId = item.JobId,
                    Floor = item.Floor,
                    Name=item.Name,
                    JobStatus=item.JobStatus,
                    RoomTypeDescription=item.RoomTypeDescription                 
                };
                jobList.Add(job);                   
            }
            var jobViewModel = new JobViewModel();
            jobViewModel.JobList = jobList;

            return jobViewModel;
        }

        public void UpdateJobStatus(int jobid)
        {
            var sql = @"Update [rx_job] SET status = @status WHERE Jobid = @JobId";

            _db.Database.ExecuteSqlCommand(
                sql,
                new SqlParameter("@status", "Complete"),
                new SqlParameter("@JobId", jobid));   
        }
      
    }
}