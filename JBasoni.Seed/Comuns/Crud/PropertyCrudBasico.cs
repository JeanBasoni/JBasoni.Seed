using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Seed.Comuns.Crud
{
    public class PropertyCrudBasico : IPropertyCrudBasico
    {
        public Guid Id { get; protected set; }

        public DateTime DataDeCadastro => DateTime.Now;

        public void ChangeGuidId(Guid id) => Id = id;

        public void GenerateGuidId() => Id = Guid.NewGuid();
    }
}
