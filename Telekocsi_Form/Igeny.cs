using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekocsi_Form
{
    class Igeny
    {
        public string Azonosito { get; private set; }
        public string Indulas { get; private set; }
        public string Cel { get; private set; }
        public int Szemelyek { get; private set; }
        public string Utvonal { get; private set; }

        public Igeny(string azonosito, string indulas, string cel, int szemelyek)
        {
            Azonosito = azonosito;
            Indulas = indulas;
            Cel = cel;
            Szemelyek = Convert.ToInt32(szemelyek);
            Utvonal = Indulas + "-" + Cel;

        }
        public int VanAuto(List<Auto> auto)
        {
            int i = 0;
            while (i < auto.Count &&
                !(
                Utvonal == auto[i].Utvonal &&
                Szemelyek <= auto[i].Ferohely))
            {
                i++;
            }
            if (i < auto.Count)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}
