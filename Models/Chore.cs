namespace chores.Models;

public class Chore
{
  public string Id { get; private set; }
  public string Title { get; set; }
  public int Priority { get; set; }
  public bool IsComplete { get; set; }



  public Chore(string title, int priority, bool isComplete)
  {
    Id = Guid.NewGuid().ToString();
    Title = title;
    Priority = priority;
    IsComplete = isComplete;
  }
}