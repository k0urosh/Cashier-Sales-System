using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    class FormProvider
    {
        public static ProductSelection Ps
        {
            get
            {
                if (_ps == null)
                {
                    _ps = new ProductSelection();
                }
                return _ps;
            }
        }
        private static ProductSelection _ps;
    }
}
