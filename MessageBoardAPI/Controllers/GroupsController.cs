using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MessageBoardAPI.Models;

namespace MessageBoardAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GroupsController : ControllerBase
  {
    private MessageBoardAPIContext _db;
    public GroupsController(MessageBoardAPIContext db)
    {
      _db = db;
    }
    [HttpGet("{id}")]
    public ActionResult<Group> Get(int id)
    {
      return _db.Groups.FirstOrDefault(entry => entry.GroupId == id);
    }
    [HttpPost]
    public void Post([FromBody] Group group)
    {
      _db.Groups.Add(group);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Group> Get(int id)
    {
      return _db.Groups.FirstOrDefault(entry => entry.GroupId == id);
    }
  }
}