using Microsoft.AspNetCore.Mvc;
using WebAPIs.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }


        //// GET: api/<UsuarioController>
        //[HttpGet]
        //public IEnumerable<UsuarioModel> Get()
        //{
        //    List<UsuarioModel> usuarioModels = new List<UsuarioModel>();

        //    usuarioModels.Add(new UsuarioModel() { Id = 1, Name = "Adriana Coradin", Email = "adriana.coradin@gmail.com"});
        //    return usuarioModels;
        //}




        //// GET api/<UsuarioController>/5
        //[HttpGet("{id}")]
        //public  UsuarioModel Get(int id)
        //{
        //    UsuarioModel usuario = new UsuarioModel() { Id = 1, Name = "Adriana Coradin", Email = "adriana.coradin@gmail.com" };
        //    return usuario;
        //}






        //// POST api/<UsuarioController>
        //[HttpPost]
        //public void Post([FromBody] UsuarioModel usuario)
        //{
        //}


        //// PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] UsuarioModel usuario)
        //{
        //}



        //// DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
