using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPractice.infrastucture.Models
{
    public class ToDoCategory
    {
        public int Id { get; set; }
        public ToDoItem ToDoItem { get; set; } //Calling the ToDoItem classs
        public Category Category { get; set; } //Same as to Category

    }
}
