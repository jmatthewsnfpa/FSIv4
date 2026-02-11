namespace FSIv4.Data.Models
{
    public class QueryBuilderModel
    {
        public List<FilterCondition> Conditions { get; set; } = new();
        public List<string> SelectedColumns { get; set; } = new();
        //public int? RowLimit { get; set; } = 1000;
        public string SortColumn { get; set; }
        public bool SortDescending { get; set; }
        public bool IncludeAllColumns { get; set; } = true;
        public string TableName { get; set; } = "FSI"; // "FSI" or "ProtectedTowns"
    }

    public class FilterCondition
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Column { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public string SecondValue { get; set; } // For BETWEEN operator
        public string ValueType { get; set; }
        public DateTime? DateValue { get; set; }
        public DateTime? DateSecondValue { get; set; }
        public int? IntValue { get; set; }
        public int? IntSecondValue { get; set; }
    }

    public class ColumnDefinition
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string DataType { get; set; }
        public List<string> Operators { get; set; } = new();
        public bool IsEnum { get; set; }
        public bool IsNullable { get; set; }
    }

    public class PreviewResult
    {
        public List<Dictionary<string, object>> Data { get; set; } = new();
        public int TotalCount { get; set; }
        public int PreviewCount { get; set; }
        public List<string> Columns { get; set; } = new();
        public string TableName { get; set; }
    }
}
