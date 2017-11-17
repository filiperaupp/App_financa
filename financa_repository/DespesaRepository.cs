using System.Collections.Generic;
using System.Linq;
using financa_domain;
using Microsoft.EntityFrameworkCore;

namespace financa_repository
{
    public class DespesaRepository : IDespesaRepository
    {
        private DataContext context;
        public DespesaRepository(DataContext context) {
            this.context = context;
        }

        public Despesa GetById(int id) {
            return context.Despesas.SingleOrDefault(x=> x.id == id);
        }

        public List<Despesa> GetAll(){
            return context.Despesas.ToList();
        }

        public void Create(Despesa despesa){
            context.Despesas.Add(despesa);
            context.SaveChanges();
        }

        public void Delete (int id){
            context.Despesas.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update (Despesa despesa){
            context.Entry(despesa).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}