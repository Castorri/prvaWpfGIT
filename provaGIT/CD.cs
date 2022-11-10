using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// andrea Baravelli 22/11/10


namespace provaGIT
{
    internal class CD: Brano
    {

        List<Brano> brani= new List<Brano>() ;

        internal string titolo { get; set; }

        internal string autore { get; set; }

        internal CD (List<Brano> brani)
        {
          this.brani=brani;
             titolo.getTitolo();
            autore.getAutore();
            

        }
        internal virtual void toString()
        {

            brani.ToString();

        }
        //internal virtual void getTitolo()
        //{



        //}


        //internal virtual void getAutore()
        //{




        //}


    }
}
