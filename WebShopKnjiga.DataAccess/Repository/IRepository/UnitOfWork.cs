using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopKnjiga.DataAccess.Data;

namespace WebShopKnjiga.DataAccess.Repository.IRepository;

public class UnitOfWork : IUnitOfWork
{
    private ApplicationDbContext _context;
    public ICategoryRepository Category { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    { 
        _context = context;
        Category = new CategoryRepository(_context);
    }
    public void Save()
    {
        _context.SaveChanges();
    }
}

