using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = _brandService;
        }
        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);

            return Ok(createdBrandResponse);//200 demiş olduk ok ile
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandService.GetAll());
        }
    }
}



//200 başarılı demek
//201 başarılı ve eklendi demek
//400 hata demek
