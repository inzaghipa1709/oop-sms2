using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class EFDatabase
    {
        public static void Start()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbDataCtx>();
            optionsBuilder.UseMySQL(@"server=localhost;port=8080;database=ABCDEF;uid=root");
            var context = new MyDbDataCtx(optionsBuilder.Options);

            context.Database.EnsureCreated();

            // Insert
            //EFCore.Models.Mahasiswa mahasiswa = newEFCore.Models.Mahasiswa();
            //mahasiswa.Nama = "Inzaghi Posuma";
            //mahasiswa.Email = "inzaghi.posuma@student.pradita.ac.id";
            //context.Mahasiswas.Add(mahasiswa);
            //context.SaveChanges();

            // Update
            //var mhs = context.Mahasiswas.FirstOrDefault(m => m.ID == 2);
            //mhs.Nama = "Bryan Elmer";
            //mhs.Email = "bryan.elmer@student.pradita.ac.id";
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
