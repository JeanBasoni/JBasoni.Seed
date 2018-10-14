using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Seed.Componente.ReturnObject
{
    public class Mensagem
    {
        public Mensagem(string texto, TipoDeMensagem tipoDeMensagem)
        {
            Texto = texto;
            Tipo = tipoDeMensagem;
        }
        public string Texto { get; set; }
        public TipoDeMensagem Tipo { get; set; }
    }
}
