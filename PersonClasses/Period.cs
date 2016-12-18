using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonClasses
{
    public class Period<T>: BaseClass
    {
        private T f;
        private T t;

        public Period()
        {
            f = default(T);//01/01/0001 kell 00:00:00
            t = default(T);
        }

        public T From
        {
            get { return t;}
            set { SetValue(ref t, value); }
        }
        public T To
        {
            get { return f; }
            set { SetValue(ref f, value); }
        }

    }
}
