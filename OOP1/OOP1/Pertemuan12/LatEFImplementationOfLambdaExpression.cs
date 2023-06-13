using Microsoft.EntityFrameworkCore;
using OOP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan12
{
    public class LatEFImplementationOfLambdaExpression
    {
        public static void Start()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbDataCtx>();
            optionsBuilder.UseMySQL(@"server=localhost;port=3306;database=ABCDEF;uid=root;password=mulai");
            var context = new MyDbDataCtx(optionsBuilder.Options);

            context.Database.EnsureCreated();

            // Insert
            //OOP1.Models.Mahasiswa mahasiswa = new OOP1.Models.Mahasiswa();
            //mahasiswa.Nama = "AAAAA";
            //mahasiswa.Email = "AAAAA@gmail.com";
            //context.Mahasiswas.Add(mahasiswa);
            //context.SaveChanges();

            // Update
            //var mhs = context.Mahasiswas.FirstOrDefault(m => m.ID == 2);
            //mhs.Nama = "HHHHHH";
            //mhs.Email = "HHHHH@gmail.com";
            //context.SaveChanges();

            // Select
            //var listMahasiswa = context.Mahasiswas.Where(m => m.Nama.Contains("Har")).ToList();
            //var mhssStartwith = listMahasiswa.Where(m => m.Nama.StartsWith("Ha"));
            //var mhssEndwith = listMahasiswa.Where(m => m.Nama.EndsWith("o"));

            // Delete
            //var mhs = context.Mahasiswas.FirstOrDefault(m => m.ID == 2);
            //context.Mahasiswas.Remove(mhs);
            //context.SaveChanges();

        }
    }
}
