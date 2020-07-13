using Microsoft.AspNetCore.Mvc;
using cs_burgershack_api.Services;
using System;
using System.Collections.Generic;
using cs_burgershack_api.Models;

namespace cs_burgershack_api.Controllers
{
  [ApiController]
  [Route("api/[contoller]")]

  public class BurgersController : ControllerBase
  {

    private readonly BurgerService _service;
    
    public BurgersController(BurgerService service)
    {
      _service = service;
    }
    
    [HttpGet] //GetAll
    public ActionResult<IEnumerable<Burger>> Get()
    {
      try
      {
         return Ok(_service.Get()); 
      }
      catch (Exception e)
      {
          return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")] //GetById

    public ActionResult<Burger> Get(int id)
    {
      try
      {
          return Ok(_service.Get(id));
      }
      catch (Exception e)
      {
          return BadRequest(e.Message);
      }
    }
     [HttpPost] //Post
     public ActionResult<Burger> Create([FromBody] Burger newBurger)
     {
       try
      {
          return Ok(_service.Create(newBurger));
      }
      catch (Exception e)
      {
          return BadRequest(e.Message);
      }
     }
      [HttpPut("{id}")] //Put

    public ActionResult<Burger> Edit([FromBody] Burger editBurger, int id)
    {
        try
      {
          editBurger.Id = id;
          return Ok(_service.Edit(editBurger));
      }
      catch (Exception e)
      {
          return BadRequest(e.Message);
      }
    }
     [HttpDelete("{id}")] //Delete
    
    public ActionResult<Burger> Delete(int id)
    {
       try
      {
          return Ok(_service.Delete(id));
      }
      catch (Exception e)
      {
          return BadRequest(e.Message);
      }
    }
  }
}