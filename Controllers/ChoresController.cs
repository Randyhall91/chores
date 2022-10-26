namespace chores.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _cs;
  private readonly Auth0Provider _auth0Provider;




  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      var chores = _cs.GetChores();
      return chores;
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Chore>> Create([FromBody] Chore choreData)
  {
    try
    {
      var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      choreData.OwnerId = userInfo?.Id;

      Chore chore = _cs.AddChore(choreData);
      return Ok(chore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  // [HttpGet("{id}")]
  // public ActionResult<Chore> Get(string id)
  // {
  //   try
  //   {
  //     var chore = _cs.GetChoreById(id);
  //     return Ok(chore);
  //   }
  //   catch (Exception e)
  //   {
  //     return BadRequest(e.Message);
  //   }
  // }

  // [HttpPut("{id}")]
  // public ActionResult<Chore> UpdateChore([FromBody] Chore choreData, string id)
  // {
  //   try
  //   {
  //     Chore chore = _cs.UpdateChore(choreData, id);
  //     return Ok(chore);
  //   }
  //   catch (System.Exception e)
  //   {
  //     return BadRequest(e.Message);
  //   }
  // }
  // [HttpDelete("{id}")]
  // public ActionResult<Chore> DeleteChore(string id)
  // {
  //   try
  //   {
  //     Chore chore = _cs.DeleteChore(id);
  //     return Ok(chore);
  //   }
  //   catch (System.Exception e)
  //   {

  //     return BadRequest(e.Message);
  //   }
  // }


  public ChoresController(ChoresService cs, Auth0Provider auth0Provider)
  {
    _cs = cs;
    _auth0Provider = auth0Provider;
  }
}