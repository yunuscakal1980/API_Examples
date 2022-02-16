using API_Examples.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API_Examples.Controllers
{
    public class OgrenciController : ApiController
    {
        [HttpPost]
        public bool Post(Ogrenci _ogrenci)
        {
            System.Threading.Thread.Sleep(10000);

            return _ogrenci.Post();
        }

        [HttpPost]
        public async Task<bool> PostAsync(Ogrenci _ogrenci)
        {
            System.Threading.Thread.Sleep(10000);

            return await Task.Run(() => _ogrenci.Post());
        }

        [HttpGet]
        public DataTable Get()
        {
            System.Threading.Thread.Sleep(10000);

            Ogrenci _ogrenci = new Ogrenci();
            return _ogrenci.Get();
        }

        [HttpGet]
        public async Task<DataTable> GetAsync()
        {
            System.Threading.Thread.Sleep(10000);

            Ogrenci _ogrenci = new Ogrenci();
            return await Task.Run(() => _ogrenci.Get());
        }

        [HttpGet]
        public DataTable Get(int id)
        {
            System.Threading.Thread.Sleep(10000);

            Ogrenci _ogrenci = new Ogrenci();
            return _ogrenci.Get(id);
        }

        [HttpGet]
        public async Task<DataTable> GetAsync(int id)
        {
            System.Threading.Thread.Sleep(10000);

            Ogrenci _ogrenci = new Ogrenci();
            return await Task.Run(() => _ogrenci.Get(id));
        }

        [HttpPut]
        public bool Put(Ogrenci _ogrenci)
        {
            System.Threading.Thread.Sleep(10000);

            return _ogrenci.Put();
        }

        [HttpPut]
        public async Task<bool> PutAsync(Ogrenci _ogrenci)
        {
            System.Threading.Thread.Sleep(10000);

            return await Task.Run(() => _ogrenci.Put());
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            System.Threading.Thread.Sleep(10000);

            Ogrenci _ogrenci = new Ogrenci();
            return _ogrenci.Delete(id);
        }

        [HttpDelete]
        public async Task<bool> DeleteAsync(int id)
        {
            System.Threading.Thread.Sleep(10000);

            Ogrenci _ogrenci = new Ogrenci();
            return await Task.Run(() => _ogrenci.Delete(id));
        }
    }
}
