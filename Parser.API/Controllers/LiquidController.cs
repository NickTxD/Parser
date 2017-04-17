using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Parser.API.Filters;
using Parser.BLL.Contracts;
using Parser.DTO;

namespace Parser.API.Controllers
{
    public class LiquidController : ApiController
    {
        private readonly ILiquidBLL liquidBLL;

        public LiquidController(ILiquidBLL liquidBLL)
        {
            this.liquidBLL = liquidBLL;
        }

        [MethodDebugFilter]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return this.Request.CreateResponse(this.liquidBLL.GetAll().Select(x => new LiquidDTO().MapFromModel(x)).ToArray());
        }
        [HttpGet]
        public HttpResponseMessage Get(Guid id)
        {
            return this.Request.CreateResponse(new LiquidDTO().MapFromModel(this.liquidBLL.GetById(id)));
        }
    }
}
