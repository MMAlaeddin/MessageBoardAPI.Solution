using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MessageBoardAPI.Models
{
    public class Message
    {
    public int MessageId { get; set; }
    public string Description { get; set; }
    public int GroupId { get; set; }
    public virtual Group Group { get; set;}
  }
}
