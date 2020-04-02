using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MessageBoardAPI.Models
{
  public class Group
  {
   public int GroupId { get; set; }
   public string Topic { get; set; }
   public virtual ICollection<Message> Messages { get; set; }
  }
}