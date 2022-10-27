namespace chores.Repositories;

public class ChoresRepository
{
  private readonly IDbConnection _db;
  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Chore> Get()
  {
    var sql = "SELECT * FROM chores";
    return _db.Query<Chore>(sql).ToList();
  }

  public Chore Create(Chore choreData)
  {
    var sql = @"
    INSERT INTO chores
    (id, title, priority, isComplete, ownerId)
    VALUES
    (@Id, @Title, @Priority, @IsComplete, @OwnerId)
    ";
    choreData.Id = _db.ExecuteScalar<string>(sql, choreData);
    return choreData;
  }
  public Chore Delete(int id)
  {
    // TODO this is bad fix tomorrow
    var sql = $"DELETE FROM chores WHERE id = {id}";
    _db.Execute(sql, null);
    return null;
  }
}
