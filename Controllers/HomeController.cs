


using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("/")]
public class HomeController : ControllerBase {


    public HomeController() {

    }
    

    [HttpGet]
    public IActionResult Index() {

        return Ok(new { ServiceName = "sr-admin-service", Status = "Active", Version = "1.0.0" });
    }


}