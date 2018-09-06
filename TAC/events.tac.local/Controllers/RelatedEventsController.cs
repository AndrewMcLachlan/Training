using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using events.tac.local.Business;

namespace events.tac.local.Controllers
{
    public class RelatedEventsController : Controller
    {
        private readonly RelatedEventsProvider _builder;

        public RelatedEventsController() : this(new RelatedEventsProvider()) { }

        public RelatedEventsController(RelatedEventsProvider builder)
        {
            _builder = builder;
        }

        // GET: RelatedEvents
        public ActionResult Index()
        {
            return View(_builder.GetRelatedEvents());
        }
    }
}