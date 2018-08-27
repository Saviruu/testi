using System;
using System.Collections.Generic;
using System.Text;

namespace Muistio
{
    public class Kirjaus
    {/*
        public Kirjaus(string otsikko, string sisalto, DateTime luontiPaiva, string id)
        {
            Otsikko = otsikko;
            Sisalto = sisalto;
            LuontiPaiva = luontiPaiva;
            Id = id;
        }*/

        public string Otsikko { get; set; }
        public string Sisalto { get; set; }
        public DateTime LuontiPaiva { get; set; } = DateTime.Now;
        public string Id { get; set; }=Guid.NewGuid().ToString();

        public override string ToString()
        {
            return Otsikko + " " + LuontiPaiva;
        }

    }
}
