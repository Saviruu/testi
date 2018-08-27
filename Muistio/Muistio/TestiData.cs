using System;
using System.Collections.Generic;
using System.Text;

namespace Muistio
{
    public static class TestiData
    {
        public static void LataaData(this IMuistio store)
        {
            var a = new Kirjaus() { Otsikko = "Koe", Sisalto = "Treeniä kokeeseen" };
            var b = new Kirjaus() { Otsikko = "Testi", Sisalto = "Testi kokeeseen" };

            store.WriteAsync(a).Wait();
            store.WriteAsync(b).Wait();
        }
    }
}
