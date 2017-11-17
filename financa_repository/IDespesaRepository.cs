using System.Collections.Generic;
using financa_domain;

namespace financa_repository
{
    public interface IDespesaRepository
    {
         Despesa GetById(int id);
         List<Despesa> GetAll();
         void Create (Despesa despesa);
         void Delete (int id);
         void Update (Despesa despesa);


    }
}