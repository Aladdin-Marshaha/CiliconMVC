using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class AddressRepository : Repo<AddressEntity>
{
    private readonly DataContext _context;

    public AddressRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}

