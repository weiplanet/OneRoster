namespace Questar.OneRoster.Query
{
    public class Filter
    {
        public Logical? AndOr { get; set; }
        public string FieldName { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }
}