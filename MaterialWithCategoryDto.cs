using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MaterialWithCategoryDto
    {
        public MaterialRefDto Material { get; set; }

        public enum Category
        {
            DecisionProject,
            Presentation,
            Other,
            Attachment
        }
        public IEnumerable<MaterialRefDto> DraftsToMerge { get; set; }

    }
}