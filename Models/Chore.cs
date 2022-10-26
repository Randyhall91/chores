namespace chores.Models;

public class Chore
{
  public string Id { get; set; }
  public string Title { get; set; }
  public int Priority { get; set; }
  public bool IsComplete { get; set; }
  public string OwnerId { get; set; }

}