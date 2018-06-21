using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Catalog.App.Controllers
{
    public class ValuesController : ApiController
    {

        public string POST([FromBody]PostWrapper postWrapper)
        {
            DataService.AddPersonToTheTeam(postWrapper.teamName, postWrapper.personName);
            return "User " + postWrapper.personName + " was successfully added to the team " + postWrapper.teamName + ".";
        }
    }

    public class PostWrapper
    {
        public string teamName { get; set; }
        public string personName { get; set; }
    }
}
