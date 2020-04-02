using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MessageBoardAPI.Models;
using Microsoft.EntityFrameworkCore;


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
    [HttpGet]
    public ActionResult<IEnumerable<Group>> Get()
    {
      return _db.Groups.ToList();
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Group group)
    {
      group.GroupId = id;
      _db.Entry(group).State = EntityState.Modified;
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var groupDelete = _db.Groups.FirstOrDefault(entry => entry.GroupId == id);
      _db.Groups.Remove(groupDelete);
      _db.SaveChanges();
    }
  }
}