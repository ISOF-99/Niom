using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Turin.Context;
using Turin.Entity;

namespace ConsoleApp.Repositories
{
    internal class CustomerRepository : Reposi<CustomerEntity>
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override CustomerEntity Get(Expression<Func<CustomerEntity, bool>> expression)
        {
            var entity = _context.Customers
                .Include(i => i.Address)
                .Include(i => i.Role)
                .FirstOrDefault(expression.Compile());

            return entity!;
        }

        public override IEnumerable<CustomerEntity> GetAll()
        {
            return _context.Customers
                .Include(i => i.Address)
                .Include(i => i.Role)
                .ToList();
        }
    }

    internal class CustomerEntityA
    {
        public string Email { get; internal set; }
        public int Id { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int RoleId { get; internal set; }
        public int AddressId { get; internal set; }
    }
}
