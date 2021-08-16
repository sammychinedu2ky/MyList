using System;
using System.Collections.Generic;

#nullable disable

namespace MyList.Model
{
    public partial class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Completed { get; set; }
    }
}
