using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4BaseApp.Models
{
    public interface ISampleModel
    {
        void ChangeStatus(string newStatus);
    }

    public class SampleModel : ISampleModel
    {
        public string Status { get; set; }

        public SampleModel()
        {
        }

        public void ChangeStatus(string newStatus)
        {
            this.Status = newStatus;
        }

    }
}