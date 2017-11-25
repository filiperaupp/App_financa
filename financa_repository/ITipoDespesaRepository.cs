using System.Collections.Generic;
using financa_domain;

namespace financa_repository
{
    public interface ITipoDespesaRepository
    {
         TipoDespesa GetById (int id);
         List<TipoDespesa> GetAll();
         void Create (TipoDespesa tipoDesp);
         void Update (TipoDespesa tipoDesp);
         void Delete (int id);
    }
}