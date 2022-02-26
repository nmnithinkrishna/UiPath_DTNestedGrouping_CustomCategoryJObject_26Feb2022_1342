using System;

namespace CustomCategoryJObject
{
    public class Category
    {
        public int id { get; set; }

        public string title { get; set; }

        public Category[] subs { get; set; }
    }
}
