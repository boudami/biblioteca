using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Class1
    {
        string nome, indirizzo;
        int orarioApertura, orarioChiusura;
        public Class1(string nome, string indirizzo, int orarioApertura, int orarioChiusura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioApertura = orarioApertura;
            this.orarioChiusura = orarioChiusura;
        }

        public Class1()
        {

        }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Indirizzo { get { return indirizzo; } set { nome = value; } }
        public int OrarioApertura { get { return orarioApertura; } set { orarioApertura = value; } }
        public int OrarioChiusura { get { return orarioChiusura; } set { orarioChiusura = value; } }

    }
}
