using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Muistio
{
    public interface IMuistio
    {
        Task<List<Kirjaus>> ReadAsync();
        Task WriteAsync(Kirjaus kirjaus);
        Task DeleteAsync(Kirjaus kirjaus);
    }
}
