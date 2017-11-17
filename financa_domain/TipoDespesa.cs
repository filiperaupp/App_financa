using System.Collections.Generic;

namespace financa_domain
{
    public class TipoDespesa
    {
        public int id { get; set; }
        public string nome { get; set; }
        
        public IEnumerable<Despesa> Despesas { get; set; }
    }
}