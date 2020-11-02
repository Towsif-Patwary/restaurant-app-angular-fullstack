using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using md_api_by_towsif.Models;

namespace md_api_by_towsif.Controllers
{
    public class ItemController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Item
        public IQueryable<Item> GetItems()
        {
            return db.Items;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}