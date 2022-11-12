using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Class1
    {
        string autore, titolo;
        int anno, nPagine;
        public Class1(string autore, string titolo, int anno, int nPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.anno = anno;
            this.nPagine = nPagine;
        }
        public Class1()
        {

        }

        public string Autore { get { return autore; } set { autore = value; } }
        public string Titolo { get { return titolo; } set { titolo = value; } }
        public int Anno { get { return anno; } set { anno = value; } }
        public int NPagine { get { return nPagine; } set { nPagine = value} }
        public string toString() { return ("L'autore è " + this.autore + ", il titolo è " + this.titolo + "pubblicato nell'anno"+ this.anno + "con" + this.nPagine + "pagine" ); }
        int tempoLettura;
        public int getTempoLettura() { return tempoLettura; }
        
        public int readingTime()
        {
            if (nPagine < 100)
            {
                return tempoLettura = 1;
            } else if (100 < nPagine > 200)
            {
                tempoLettura = 2;
            } else if (nPagine > 200) 
            { 
                tempoLettura = 3;
            }
        }
    }
}
