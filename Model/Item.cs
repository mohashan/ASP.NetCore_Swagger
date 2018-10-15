using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger.Model
{
    public class Item
    {
        public Item(int id, string value)
        {
            Id = id;
            Value = value;

        }
        public int Id { get; set; }
        public string Value { get; set; }
    }


}
