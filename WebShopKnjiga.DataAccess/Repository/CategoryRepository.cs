using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopKnjiga.DataAccess.Data;
using WebShopKnjiga.DataAccess.Repository.IRepository;
using WebShopKnjiga.Models.Models;

namespace WebShopKnjiga.DataAccess.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public void Update(Category category)
    { 
        _context.Update(category);
    }
}
