namespace chores.Services;

public class ChoresService
{
  // private readonly FakeDb _db;
  private readonly ChoresRepository _choresRepo;

  public List<Chore> GetChores()
  {

    return _choresRepo.Get();
  }

  public Chore AddChore(Chore choreData)
  {
    _choresRepo.Create(choreData);
    return choreData;

  }

  // public Chore GetChoreById(string id)
  // {
  //   Chore chore = _choresRepo.Chores.Find(c => c.Id == id);
  //   if (chore == null)
  //   {
  //     throw new Exception("Invalid ID");
  //   }
  //   return chore;
  // }

  // public Chore UpdateChore(Chore choreData, string id)
  // {
  //   Chore chore = this.GetChoreById(id);
  //   chore.Title = choreData.Title;
  //   chore.Priority = choreData.Priority;
  //   chore.IsComplete = choreData.IsComplete;
  //   return chore;
  // }

  // internal Chore DeleteChore(string id)
  // {
  //   Chore chore = this.GetChoreById(id);
  //   int choreIndex = _choresRepo.Chores.FindIndex(c => c.Id == id);
  //   _choresRepo.Chores.RemoveAt(choreIndex);
  //   return chore;
  // }
  public ChoresService(ChoresRepository choresRepository)
  {
    _choresRepo = choresRepository;
  }
}