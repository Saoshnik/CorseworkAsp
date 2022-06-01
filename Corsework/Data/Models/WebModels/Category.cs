using Corsework.Data.Models.CsModels;
using System.Collections.Generic;

namespace Corsework.Data.Models.WebModels
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // public string Description { get; set; }

        public List<Part> Parts { get; set; }
    }
}
