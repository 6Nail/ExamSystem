using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public DbSet<Result> Results { get; set; }
    }
   
    
    
    
}
