namespace Questar.OneRoster.Dto
{
    using System.Collections.Generic;
    using System.Linq;
    using Common;
    using Vocabulary;

    public class OrgData : Base
    {
        public string Name { get; set; }
        public OrgType Type { get; set; }
        public string Identifier { get; set; }
        public GuidRefDto Parent { get; set; }
        public IEnumerable<GuidRefDto> Children { get; set; } = Enumerable.Empty<GuidRefDto>();
    }
}