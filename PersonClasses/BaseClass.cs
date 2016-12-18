using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClasses
{
    public class BaseClass
    {
        public event EventHandler OnChanged;

        public void SetValue<T>(ref T field, T value) // <T> suvalist tüüpi mmuutuja aga sama sugune 
        {
            if (value == null) return; //kui väli on null siis mine välja
            if (value.Equals(field)) return;//
            field = value;
            DoOnChanged();

        }

        protected void DoOnChanged()
        {
            if (OnChanged == null) return;
            OnChanged(this, null);
        }
    }
}
