using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Seed.Componente.ReturnObject
{

    public interface IResponse
    {
        List<Mensagem> Mensagens { get; }
    }
    public interface IResponse<out T> :IResponse
    {
        T Value { get; }
        bool HasValue { get; }
    }
}
