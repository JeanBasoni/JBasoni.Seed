using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Seed.Componente.ReturnObject
{
    public class VoidResponse : IResponse
    {
        public VoidResponse(params Mensagem[] mensagens)
        {
            this.Mensagens = mensagens.ToList();
        }

        public List<Mensagem> Mensagens { get; set; }
        public bool Ok { get; protected set; }
        public bool HasAlerta { get; protected set; }
        public bool HasError { get; protected set; }
        public bool HasInfo { get; protected set; }

        public VoidResponse AddMensagem(TipoDeMensagem tipo, string texto)
        {
            if (!Mensagens.Any()) Mensagens = new List<Mensagem>();

            Mensagens.Add(new Mensagem(texto, tipo));

            switch (tipo)
            {
                case TipoDeMensagem.Ok:
                    HasError = false;
                    HasAlerta = false;
                    HasInfo = false;
                    Ok = true;
                    break;
                case TipoDeMensagem.Alerta:
                    HasError = false;
                    HasAlerta = true;
                    HasInfo = false;
                    Ok = false;
                    break;
                case TipoDeMensagem.Erro:
                    HasError = true;
                    HasAlerta = false;
                    HasInfo = false;
                    Ok = false;
                    break;
                case TipoDeMensagem.Info:
                    HasError = false;
                    HasAlerta = false;
                    HasInfo = true;
                    Ok = false;
                    break;
            }

            return new VoidResponse(Mensagens.ToArray());
        }
    }
}
