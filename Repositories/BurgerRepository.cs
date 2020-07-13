using System;
using System.Collections.Generic;
using System.Data;
using cs_burgershack_api.Models;
using Dapper;

namespace cs_burgershack_api.Repositories
{
  public class BurgerRepository
  {
    public readonly IDbConnection _db;

    public BurgerRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Burger> GetAll()
    {
      string sql = "SELECT * FROM burgers;";
      return _db.Query<Burger>(sql);

    }

    internal Burger GetById(int id)
    {
      string sql = "SELECT * FROM burgers WHERE id = @id";
      return _db.QueryFirstOrDefault<Burger>(sql, new { id });
    }

    internal Burger Create(Burger newBurger)
    {
      string sql = @"
      INSERT INTO burgers
      (name, price, description)
      VALUES
      (@Name, @Price, @Description);
      SELECT LAST_INSERT_ID();";

      int id = _db.ExecuteScalar<int>(sql, newBurger);
      newBurger.Id = id;
      return newBurger;
    }

    internal Burger Edit(Burger original)
    {
      string sql = @"
      UPDATE burgers
      SET
        name = @Name,
        price = @Price,
        description = @Description
        WHERE id = @id;
        SELECT * FROM burgers WHERE id=@id;";
        return _db.QueryFirstOrDefault<Burger>(sql, original);
    }

    internal Burger Delete(Burger burgerToDelete)
    {
      string sql = "DELETE FROM burgers WHERE id = @Id";
      _db.Execute(sql, burgerToDelete);
      return burgerToDelete;
    }
  }

}