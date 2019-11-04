using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.Model
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public Tag(int tagId, string tagName)
        {
            TagId = tagId;
            TagName = tagName;
        }
    }
}
