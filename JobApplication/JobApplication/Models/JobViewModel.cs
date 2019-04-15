using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobApplication.Models
{

    public class JobViewModel
    {
        public List<Job> JobList { get; set; }
    }
    public class Job
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public int? Floor { get; set; }
        public string JobStatus { get; set; }
        public string RoomTypeDescription { get; set; }
    }
}