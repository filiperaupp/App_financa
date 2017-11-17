using System;

namespace financa_domain
{
    public class Despesa
    {
        public int id { get; set; }
        public DateTime dataDespesa { get; set; }
        public string numDoc { get; set; }
        public TipoDespesa grupoDespesa { get; set; }
        public string estabelecimento { get; set; }
        public double valor { get; set; }
        
        
        
        
        
        
        
    }
}
