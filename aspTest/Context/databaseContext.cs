using aspTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspTest.Context
{
    public class databaseContext:DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options) : base(options)
        {

        }
        public DbSet<studentModel> studentModels { get; set; }
        public DbSet<TeacherModel> teacherModels { get; set; }
    }
}
