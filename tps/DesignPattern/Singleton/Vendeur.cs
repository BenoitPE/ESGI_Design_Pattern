using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Vendeur
    {
        private static Vendeur _instance = null;
        public int sales { get; set; }

        public static Vendeur Instance()
        {
            if (_instance == null)
                _instance = new Vendeur();
            return _instance;
        }
    }
}
