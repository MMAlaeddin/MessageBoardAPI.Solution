using System.Collections.Generic;

namespace MessageBoardAPI.Models
{
  public class Group
  {
    public int GroupId { get; set; }
    public string Topic { get; set; }
    public int MessageId { get; set; }
    public virtual ICollection<Message> Messages { get; set; }
  }
}
