using PurpleRose.Data.Foundation.Attributes;
using System;
using System.Collections.Generic;
using System.Text;


namespace PurpleRose.Data.Foundation.Entity
{
    [CollectionName("ToDoItem")]
    public class ToDoItem : BaseEntity
    {
        public int SerialNo { get; set; }

        public string Title { get; set; }

        public bool IsComplete { get; set; }
    }
}
