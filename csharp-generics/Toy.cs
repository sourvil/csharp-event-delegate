using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_generics
{
    public class Toy<T> //where T : class -- error
    {
        private T _value;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Toy() { }

        /// <summary>
        /// Generic Constructor
        /// </summary>
        /// <param name="t"></param>
        public Toy(T t) { _value = t; }        

        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public T DefaultValue()
        {
            return default(T);
        }

    }
}
