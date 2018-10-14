using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Seed.Componente.ReturnObject
{
    public class Response<T> : VoidResponse, IResponse<T>, IResponse
    {
        public Response() { }
        public Response(T value)
        {
            Value = value;
            HasValue = true;
            Ok = true;
        }

        public T Value { get; set; }
        public bool HasValue { get; }

        public static implicit operator Response<T>(T value)
        {
            var response = new Response<T>(value);
            return response;
        }
    }
}
