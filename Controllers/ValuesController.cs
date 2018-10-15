using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swagger.Model;

namespace Swagger.Controllers
{
   
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<Item> Items = new List<Item>();

        public ValuesController()
        {
            Items.Add(new Item(1, "Value1"));
            Items.Add(new Item(2, "Value2"));
        
        }

        // GET api/values
        /// <summary>
        /// Get List Of Values
        /// </summary>
        /// <returns>IEnumerable of Values</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            return Items;
        }

        // GET api/values/5
        /// <summary>
        /// Get An Item By Id
        /// </summary>
        /// <param name="id">Id of Item</param>
        /// <returns>Item with Id you request</returns>
        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            return Items.FirstOrDefault(c=>c.Id == id);
        }

        // POST api/values
        /// <summary>
        /// Add A Vale 
        /// </summary>
        /// <param name="value">Value to add</param>
        [HttpPost]
        public void Post([FromBody] Item item)
        {
            Items.Add(item);
        }

        // PUT api/values/5
        /// <summary>
        /// Edit the Value
        /// </summary>
        /// <param name="id">Id of Value that you want to edit</param>
        /// <param name="value">New value</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item item)
        {
            var temp = Items.FirstOrDefault(c => c.Id == id);
            if(temp == null)
            {
                return;
            }

            item.Value = item.Value;
        }

        // DELETE api/values/5
        /// <summary>
        /// Delete a Value
        /// </summary>
        /// <param name="id">Id of Value to Delete</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var temp = Items.FirstOrDefault(c => c.Id == id);
            if (temp == null)
            {
                return;
            }
            Items.Remove(temp);
        }
    }
}
