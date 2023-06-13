using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OopServer1.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : Controller
    {

        public MahasiswaController()
        {
        }

        [HttpPost]
        [Route("AddStudent")]
        public Mahasiswa AddStudent([FromBody] Mahasiswa dataClient)
        {
            dataClient.Id = 2222;
            dataClient.Nama = "Namamu sudah saya rubah ya...";
            return dataClient;
        }


        [HttpGet]
        [Route("GetMahasiswas")]
        public IList<Mahasiswa> GetMahasiswas()
        {
            var mhss = new List<Mahasiswa>() { new Mahasiswa() { Email="hhhh", Nama="jjjjj" }, new Mahasiswa() { Email = "CCCC", Nama = "aaaa" } };
            return mhss;
        }


    }
}
