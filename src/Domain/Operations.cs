using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Operations : IOperations
    {
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public int Register(NavigationEntity navigation)
        {
            using (var db = new Context())
            {
                var result = db.Navigations.Add(navigation);
                db.SaveChanges();
                return navigation.Id;
            }
        }

        public async Task<int> RegisterAsync(NavigationEntity navigation)
        {
            using (var db = new Context())
            {
                var result = await db.Navigations.AddAsync(navigation);
                int id = await db.SaveChangesAsync();
                await db.DisposeAsync();
                return id;
            }
        }
    }
}
