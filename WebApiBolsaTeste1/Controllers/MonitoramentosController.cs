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
using WebApiBolsaTeste1.Models;

namespace WebApiBolsaTeste1.Controllers
{
    public class MonitoramentosController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Monitoramentos
        public IQueryable<Monitoramento> GetMonitoramentos()
        {
            return db.Monitoramentos;
        }

        // GET: api/Monitoramentos/5
        [ResponseType(typeof(Monitoramento))]
        public IHttpActionResult GetMonitoramento(int id)
        {
            Monitoramento monitoramento = db.Monitoramentos.Find(id);
            if (monitoramento == null)
            {
                return NotFound();
            }

            return Ok(monitoramento);
        }

        // PUT: api/Monitoramentos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMonitoramento(int id, Monitoramento monitoramento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != monitoramento.Id)
            {
                return BadRequest();
            }

            db.Entry(monitoramento).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonitoramentoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Monitoramentos
        [ResponseType(typeof(Monitoramento))]
        public IHttpActionResult PostMonitoramento(Monitoramento monitoramento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Monitoramentos.Add(monitoramento);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = monitoramento.Id }, monitoramento);
        }

        // DELETE: api/Monitoramentos/5
        [ResponseType(typeof(Monitoramento))]
        public IHttpActionResult DeleteMonitoramento(int id)
        {
            Monitoramento monitoramento = db.Monitoramentos.Find(id);
            if (monitoramento == null)
            {
                return NotFound();
            }

            db.Monitoramentos.Remove(monitoramento);
            db.SaveChanges();

            return Ok(monitoramento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MonitoramentoExists(int id)
        {
            return db.Monitoramentos.Count(e => e.Id == id) > 0;
        }
    }
}