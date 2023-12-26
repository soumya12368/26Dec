using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        static List<Team> ListTeams = new List<Team>()
        {
            new Team(){TeamId=1,TeamName="India",NOWC=3},
            new Team(){TeamId=2,TeamName="Australia",NOWC=4},
            new Team(){TeamId=3,TeamName="West Indies",NOWC=2},
            new Team(){TeamId=4,TeamName="England",NOWC=1}
        };
        
        public ActionResult Index()
        {
            
            return View(ListTeams);
        }
    }
}