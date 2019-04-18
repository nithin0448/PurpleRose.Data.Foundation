using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleRose.Data.Foundation.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class CollectionNameAttribute : Attribute
    {
        public CollectionNameAttribute(string name)
        {
            _name = name;
        }

        private string _name { get; set; }

        public virtual string Name
        {
            get { return _name; }
        }

        public static string GetCollectionName<T>()
        {
            return typeof(T).Name;
        }
    }
}
