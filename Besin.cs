using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    class Besin
    {
        
        private string _ad;


        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {

                if (string.IsNullOrWhiteSpace(_ad))
                {
                    _ad = value;
                }

            }
        }
    }
}
