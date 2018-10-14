using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Seed.Comuns.Crud
{
    public interface IPropertyCrudBasico
    {
        Guid Id { get; }
        DateTime DataDeCadastro { get; }

        void ChangeGuidId(Guid id);
        void GenerateGuidId();
    }
}
