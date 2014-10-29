﻿using System.Collections.Generic;
using System.Web.Http;
using Business;
using Leaves = Models.Leaves;

namespace LtApi.Controllers
{
    public class LeavesController : ApiController
    {
        readonly ILeaves _leavesBusiness = new Business.Leaves();
        // GET api/values
        public IEnumerable<Leaves> Get()
        {
            return _leavesBusiness.GetLeaveTrackerDetailsForGivenDateRange();
        }

        // GET api/values/5
        public Leaves Get(int id)
        {
            return new Leaves();
        }

        // POST api/values
        public void Post(Leaves value)
        {
        }

        // PUT api/values/5
        public void Put(int id, Leaves value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}