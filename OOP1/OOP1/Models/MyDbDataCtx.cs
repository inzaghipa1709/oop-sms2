using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Models
{
    public class MyDbDataCtx : DbContext
    {
        public DbSet<Mahasiswa> Mahasiswas { get; set; }

        public MyDbDataCtx(DbContextOptions<MyDbDataCtx> options) : base(options) { }
    }
}
