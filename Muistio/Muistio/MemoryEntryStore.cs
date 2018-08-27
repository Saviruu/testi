using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muistio
{
    class MemoryEntryStore : IMuistio
    {
        Dictionary<string, Kirjaus> entries = new Dictionary<string, Kirjaus>();
        public Task DeleteAsync(Kirjaus kirjaus)
        {
            entries.Remove(kirjaus.Id);
            return Task.CompletedTask;
        }

        public Task<List<Kirjaus>> ReadAsync()
        {
            var result = entries.Values.ToList();
            return Task.FromResult(result);
        }

        public Task WriteAsync(Kirjaus kirjaus)
        {
            entries[kirjaus.Id] = kirjaus;
            return Task.CompletedTask;
        }
    }
}
