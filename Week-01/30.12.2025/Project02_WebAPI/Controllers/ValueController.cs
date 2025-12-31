using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project02_WebAPI.Controllers
{
    [Route("api/value")]  // /api/value
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet] // /api/value
        public string   GetAll()
        {
            return "Ürünler listelendi";
        }
        [HttpGet("{id}")] // /api/value/bye
       // [Route("bye")]
        public string Get(int id)//dışardan id değeri alacaksa bu methodun parametre alması gerekiyor.(ve o id yi int i diyerek tanımlıyoruz)
        {
            return $"{id}id'li ürün getirildi.";
        }
        [HttpPost]  // /api/value
        public string Add()
        {
            return "Kayıt eklendi";
        }
        [HttpPut]  // /api/value
        public string Update()
        {
            return "Güncellendi";
        }
        [HttpDelete]  // /api/value
        public string Remove()
        {
            return "Kayıt silindi";
        }
    }
}
