using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testAPI.DTO;
using testAPI.testCore.Services;

namespace testAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentService)
        {
            _documentService=documentService;
        }

        [HttpPost]
        //[Route("")] no need
        public ActionResult CreateDocument(CreateDocReqDTO doc)
        {
            try
            {
                _documentService.SaveDocument(doc);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
