using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectAplicationWebMVC.Models;

namespace ProjectAplicationWebMVC.Data
{
    public class ProjectAplicationWebMVCContext : DbContext
    {
        public ProjectAplicationWebMVCContext (DbContextOptions<ProjectAplicationWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectAplicationWebMVC.Models.Department> Department { get; set; }
    }
}
