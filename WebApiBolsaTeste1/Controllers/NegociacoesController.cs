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
    public class NegociacoesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Negociacoes
        public IQueryable<Negociacao> GetNegociacaos()
        {
            return db.Negociacaos;
        }

        // GET: api/Negociacoes/5
        [ResponseType(typeof(Negociacao))]
        public IHttpActionResult GetNegociacao(int id)
        {
            Negociacao negociacao = db.Negociacaos.Find(id);
            if (negociacao == null)
            {
                return NotFound();
            }

            return Ok(negociacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NegociacaoExists(int id)
        {
            return db.Negociacaos.Count(e => e.Id == id) > 0;
        }
    }
}