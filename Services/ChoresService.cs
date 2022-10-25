namespace chores.Services;

public class ChoresService
{
  private readonly FakeDb _db;
  public List<Chore> GetChores()
  {

    return _db.Chores;
  }

  public Chore AddChore(Chore choreData)
  {
    _db.Chores.Add(choreData);
    return choreData;

  }

  public Chore GetChoreById(string id)
  {
    Chore chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Invalid ID");
    }
    return chore;
  }

  public Chore UpdateChore(Chore choreData, string id)
  {
    Chore chore = this.GetChoreById(id);
    chore.Title = choreData.Title;
    chore.Priority = choreData.Priority;
    chore.IsComplete = choreData.IsComplete;
    return chore;
  }
  public ChoresService(FakeDb db)
  {
    _db = db;
  }

  internal Chore DeleteChore(string id)
  {
    Chore chore = this.GetChoreById(id);
    int choreIndex = _db.Chores.FindIndex(c => c.Id == id);
    _db.Chores.RemoveAt(choreIndex);

    return chore;
  }
}