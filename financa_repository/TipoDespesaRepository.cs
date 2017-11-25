using System.Collections.Generic;
using System.Linq;
using financa_domain;
using Microsoft.EntityFrameworkCore;

namespace financa_repository
{
    public class TipoDespesaRepository : ITipoDespesaRepository
    {
        private DataContext context;

        public TipoDespesaRepository (DataContext context) {
            this.context = context;
        }

        public TipoDespesa GetById (int id) {
            return context.TiposDespesas.SingleOrDefault(x=> x.id == id);
        }

        public List<TipoDespesa> GetAll (){
            return context.TiposDespesas.ToList();
        }

        public void Create (TipoDespesa tipoDesp) {
            context.TiposDespesas.Add(tipoDesp);
            context.SaveChanges();
        }

        public void Delete (int id) {
            context.TiposDespesas.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update (TipoDespesa tipoDesp) {
            context.Entry(tipoDesp).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}