using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EmployeeManagement.Authorization.Roles;
using EmployeeManagement.Authorization.Users;
using EmployeeManagement.MultiTenancy;

namespace EmployeeManagement.EntityFrameworkCore
{
    public class EmployeeManagementDbContext : AbpZeroDbContext<Tenant, Role, User, EmployeeManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EmployeeManagementDbContext(DbContextOptions<EmployeeManagementDbContext> options)
            : base(options)
        {
        }
    }
}
