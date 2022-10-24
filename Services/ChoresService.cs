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

  public ChoresService(FakeDb db)
  {
    _db = db;
  }
}