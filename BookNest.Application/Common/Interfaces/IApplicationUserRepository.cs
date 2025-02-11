using BookNest.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookNest.Domain.Entities;

namespace BookNest.Application.Common.Interfaces
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
    }
}