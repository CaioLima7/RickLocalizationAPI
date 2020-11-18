using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rick : IRick
    {
        bool disposed;

        public RickEntity GetRickDetails(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Ricks.Where(p => p.Id == id).First();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }

        public IList<RickandMortyEntity> GetCards()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.RickandMorty.ToList();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }

        public RickHistoricEntity GetHistoric(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.RickHistorics.Where(p => p.Id == id).First();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }


        }

        public async Task<RickEntity> GetRickDetailsAsync(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = await db.Ricks.Where(p => p.Id == id).FirstAsync();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }

        public async Task<IList<RickandMortyEntity>> GetCardsAsync()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = await db.RickandMorty.ToListAsync();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }

        public async Task<RickHistoricEntity> GetHistoricAsync(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = await db.RickHistorics.Where(p => p.Id == id).FirstAsync();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }

        public ICollection<NavigationEntity> GetNavigations()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Navigations.ToList();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }

        //public IEnumerable<NavigationEntity> GetNavigationsWithPagination(string sort, string order, int page)
        public Tuple<IEnumerable<NavigationEntity>, int> GetNavigationsWithPagination(string sort, string order, int page, int rickId)
        {
            var db = new Context();
            try
            {
                if (order != "desc")
                {
                    IEnumerable<NavigationEntity> result = db.Navigations.Where(p => p.RickId == rickId).OrderBy(p => p.Date).AsQueryable().Take(10);
                    var count = result.Count();
                    return new Tuple<IEnumerable<NavigationEntity>, int>(result, count);
                }
                else
                {
                    var result = db.Navigations.Where(p => p.RickId == rickId).OrderByDescending(p => p.Date).AsQueryable().Take(10);
                    var count = result.Count();
                    return new Tuple<IEnumerable<NavigationEntity>, int>(result, count);
                }
            }
            catch (DbUpdateException e)
            {
            }
            catch (Exception ex)
            {
            }

            return null;
        }

        public ICollection<NavigationEntity> GetNavigationById(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Navigations.Where(p => p.Id == id).ToList();
                    return result;
                }
                catch (DbUpdateException e)
                {
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            disposed = true;
        }
    }
}
