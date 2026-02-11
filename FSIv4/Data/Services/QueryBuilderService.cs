using FSIv4.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace FSIv4.Data.Services
{
    public interface IQueryBuilderService
    {
        Task<PreviewResult> GetPreviewDataAsync(QueryBuilderModel query);
        Task<Stream> GenerateCsvStreamAsync(QueryBuilderModel query);
        List<ColumnDefinition> GetAvailableColumns(string tableName);
        Dictionary<string, List<string>> GetEnumOptions();
        Task<int> GetTotalRecordsCountAsync(string tableName);
    }

    public class QueryBuilderService : IQueryBuilderService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;
        private readonly ILogger<QueryBuilderService> _logger;

        public QueryBuilderService(
            IDbContextFactory<ApplicationDbContext> dbFactory,
            ILogger<QueryBuilderService> logger)
        {
            _dbFactory = dbFactory;
            _logger = logger;
        }

        public List<ColumnDefinition> GetAvailableColumns(string tableName)
        {
            return tableName switch
            {
                "FSI" => GetFSIColumns(),
                "ProtectedTowns" => GetProtectedTownsColumns(),
                _ => GetFSIColumns()
            };
        }

        private List<ColumnDefinition> GetFSIColumns()
        {
            return new List<ColumnDefinition>
    {
        new() { Name = "NfpaFdid", DisplayName = "NFPA FDID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "NfirsId", DisplayName = "NFIRS ID", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS", "STARTS WITH" } },
        new() { Name = "FdName", DisplayName = "Fire Department Name", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS", "STARTS WITH" } },
        new() { Name = "CreatedDt", DisplayName = "Created Date", DataType = "datetime",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "UpdatedDt", DisplayName = "Updated Date", DataType = "datetime",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Street", DisplayName = "Street Address", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "Street2", DisplayName = "Street Address 2", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "City", DisplayName = "City", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "CountyNo", DisplayName = "County Number", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "State", DisplayName = "State", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "StateId", DisplayName = "State ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "StateGroup", DisplayName = "State Group", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "StateGroupOverride", DisplayName = "State Group Override", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Zipcode", DisplayName = "Zip Code", DataType = "string",
               Operators = new List<string> { "=", "!=", "STARTS WITH" } },
        new() { Name = "Zipcode2", DisplayName = "Zip Code 2", DataType = "string",
               Operators = new List<string> { "=", "!=", "STARTS WITH" } },
        new() { Name = "Region", DisplayName = "Region", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "Country", DisplayName = "Country", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "AddressDt", DisplayName = "Address Date", DataType = "datetime",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Phone", DisplayName = "Phone", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "PhoneDt", DisplayName = "Phone Date", DataType = "datetime",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Email", DisplayName = "Email", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "EmailDt", DisplayName = "Email Date", DataType = "datetime",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Fax", DisplayName = "Fax", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "FaxDt", DisplayName = "Fax Date", DataType = "datetime",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "ContactName", DisplayName = "Contact Name", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS", "STARTS WITH" } },
        new() { Name = "ContactRank", DisplayName = "Contact Rank", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "ContactRankId", DisplayName = "Contact Rank ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "ContactDt", DisplayName = "Contact Date", DataType = "datetime",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "RecordType", DisplayName = "Record Type", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "RecordTypeId", DisplayName = "Record Type ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "RecordStatus", DisplayName = "Record Status", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "CrossRefId", DisplayName = "Cross Reference ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "SmSa", DisplayName = "SM/SA", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "DataSource", DisplayName = "Data Source", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "SquareMiles", DisplayName = "Square Miles", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Community", DisplayName = "Community Type", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "CommunityId", DisplayName = "Community ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Population", DisplayName = "Population", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "PopInterval", DisplayName = "Population Interval", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "PopIntervalId", DisplayName = "Population Interval ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "TypeEmps", DisplayName = "Employee Type", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "TypeEmpsId", DisplayName = "Employee Type ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "PaidEmps", DisplayName = "Paid Employees", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "PaidEmpsWomen", DisplayName = "Paid Employees Women", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "WorkWeek", DisplayName = "Work Week", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "EmpsPerShift", DisplayName = "Employees Per Shift", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "VolsComp", DisplayName = "Volunteer Compensation", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "Vols", DisplayName = "Volunteers", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "VolsWomen", DisplayName = "Volunteers Women", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Pumpers", DisplayName = "Pumpers", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Ladders", DisplayName = "Ladders", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Combo", DisplayName = "Combo Units", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "MarineVessels", DisplayName = "Marine Vessels", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "OtherSupport", DisplayName = "Other Support", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "OtherVehicles", DisplayName = "Other Vehicles", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "ThermalEquipment", DisplayName = "Thermal Equipment", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Stations", DisplayName = "Stations", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Ems", DisplayName = "EMS Service", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "EmsId", DisplayName = "EMS ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Ambulance", DisplayName = "Ambulance Service", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "Dispatch", DisplayName = "Dispatch", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "DispatchId", DisplayName = "Dispatch ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Training", DisplayName = "Training", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "TrainingId", DisplayName = "Training ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "CodeEnforcement", DisplayName = "Code Enforcement", DataType = "enum", IsEnum = true,
               Operators = new List<string> { "=", "!=" } },
        new() { Name = "CodeEnforcementId", DisplayName = "Code Enforcement ID", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "LastReturned", DisplayName = "Last Returned", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "LastSent", DisplayName = "Last Sent", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "Notes", DisplayName = "Notes", DataType = "string",
               Operators = new List<string> { "=", "!=", "CONTAINS" } },
        new() { Name = "FdSurveyStatus1", DisplayName = "Survey Status 1", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyStatus2", DisplayName = "Survey Status 2", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyStatus3", DisplayName = "Survey Status 3", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyStatus4", DisplayName = "Survey Status 4", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyStatus5", DisplayName = "Survey Status 5", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyStatus6", DisplayName = "Survey Status 6", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyStatus7", DisplayName = "Survey Status 7", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyYears1", DisplayName = "Survey Years 1", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyYears2", DisplayName = "Survey Years 2", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyYears3", DisplayName = "Survey Years 3", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyYears4", DisplayName = "Survey Years 4", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyYears5", DisplayName = "Survey Years 5", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyYears6", DisplayName = "Survey Years 6", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
        new() { Name = "FdSurveyYears7", DisplayName = "Survey Years 7", DataType = "int",
               Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } }
    };
        }

        private List<ColumnDefinition> GetProtectedTownsColumns()
        {
            return new List<ColumnDefinition>
            {
                new() { Name = "TownProtectedId", DisplayName = "Town ID", DataType = "int",
                       Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
                new() { Name = "TownProtectedName", DisplayName = "Town Name", DataType = "string",
                       Operators = new List<string> { "=", "!=", "CONTAINS", "STARTS WITH" } },
                new() { Name = "NfpaFdid", DisplayName = "NFPA FDID", DataType = "int",
                       Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
                new() { Name = "FdName", DisplayName = "Fire Department Name", DataType = "string",
                       Operators = new List<string> { "=", "!=", "CONTAINS", "STARTS WITH" } },
                new() { Name = "City", DisplayName = "City", DataType = "string",
                       Operators = new List<string> { "=", "!=", "CONTAINS" } },
                new() { Name = "State", DisplayName = "State", DataType = "enum", IsEnum = true,
                       Operators = new List<string> { "=", "!=" } },
                new() { Name = "CreatedDt", DisplayName = "Created Date", DataType = "datetime",
                       Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
                new() { Name = "UpdatedDt", DisplayName = "Updated Date", DataType = "datetime",
                       Operators = new List<string> { "=", "!=", ">", "<", "BETWEEN" } },
            };
        }

        public Dictionary<string, List<string>> GetEnumOptions()
        {
            return new Dictionary<string, List<string>>
    {
        { "State", Enum.GetNames(typeof(EnumList.StateList)).ToList() },
        { "Region", Enum.GetNames(typeof(EnumList.Region)).ToList() },
        { "Country", Enum.GetNames(typeof(EnumList.Country)).ToList() },
        { "RecordStatus", Enum.GetNames(typeof(EnumList.Status)).ToList() },
        { "Community", Enum.GetNames(typeof(EnumList.Community)).ToList() },
        { "PopInterval", Enum.GetNames(typeof(EnumList.PopInt)).ToList() },
        { "TypeEmps", Enum.GetNames(typeof(EnumList.EmployeeType)).ToList() },
        { "VolsComp", Enum.GetNames(typeof(EnumList.VolunteersCompensation)).ToList() },
        { "Ems", Enum.GetNames(typeof(EnumList.Ems)).ToList() },
        { "Ambulance", Enum.GetNames(typeof(EnumList.Ambulance)).ToList() },
        { "Dispatch", Enum.GetNames(typeof(EnumList.Dispatch)).ToList() },
        { "Training", Enum.GetNames(typeof(EnumList.Training)).ToList() },
        { "CodeEnforcement", Enum.GetNames(typeof(EnumList.CodeEnforcement)).ToList() },
        { "ContactRank", Enum.GetNames(typeof(EnumList.Rank)).ToList() },
        { "RecordType", Enum.GetNames(typeof(EnumList.RecordType)).ToList() }
    };
        }

        public async Task<int> GetTotalRecordsCountAsync(string tableName)
        {
            await using var context = await _dbFactory.CreateDbContextAsync();

            return tableName switch
            {
                "FSI" => await context.FSI.CountAsync(),
                "ProtectedTowns" => await context.ProtectedTowns.CountAsync(),
                _ => 0
            };
        }

        public async Task<PreviewResult> GetPreviewDataAsync(QueryBuilderModel query)
        {
            try
            {
                if (query.TableName == "FSI")
                {
                    return await GetFSIPreviewDataAsync(query);
                }
                else if (query.TableName == "ProtectedTowns")
                {
                    return await GetProtectedTownsPreviewDataAsync(query);
                }

                return new PreviewResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting preview data");
                throw;
            }
        }

        private async Task<PreviewResult> GetFSIPreviewDataAsync(QueryBuilderModel query)
        {
            await using var context = await _dbFactory.CreateDbContextAsync();

            var dbQuery = context.FSI.AsQueryable();

            // Apply filters
            dbQuery = ApplyFilters(dbQuery, query.Conditions);

            // Apply sorting
            if (!string.IsNullOrEmpty(query.SortColumn))
            {
                dbQuery = ApplySorting(dbQuery, query.SortColumn, query.SortDescending);
            }

            // Get total count
            var totalCount = await dbQuery.CountAsync();

            // Get preview data with limit
            var previewData = await dbQuery
                //.Take(query.RowLimit ?? 100)
                .Take(100) //Set Limit. Remove and use above option for user slect limit
                .ToListAsync();

            return new PreviewResult
            {
                Data = ConvertToDictionaryList(previewData),
                TotalCount = totalCount,
                PreviewCount = previewData.Count,
                Columns = GetColumnNames(previewData),
                TableName = query.TableName
            };
        }

        private async Task<PreviewResult> GetProtectedTownsPreviewDataAsync(QueryBuilderModel query)
        {
            await using var context = await _dbFactory.CreateDbContextAsync();

            var dbQuery = context.ProtectedTowns.AsQueryable();

            // Apply filters
            dbQuery = ApplyFilters(dbQuery, query.Conditions);

            // Apply sorting
            if (!string.IsNullOrEmpty(query.SortColumn))
            {
                dbQuery = ApplySorting(dbQuery, query.SortColumn, query.SortDescending);
            }

            // Get total count
            var totalCount = await dbQuery.CountAsync();

            // Get preview data with limit
            var previewData = await dbQuery
                //.Take(query.RowLimit ?? 100)
                .Take(100) //Set Limit. Remove and use above option for user slect limit
                .ToListAsync();

            return new PreviewResult
            {
                Data = ConvertToDictionaryList(previewData),
                TotalCount = totalCount,
                PreviewCount = previewData.Count,
                Columns = GetColumnNames(previewData),
                TableName = query.TableName
            };
        }

        private IQueryable<T> ApplyFilters<T>(IQueryable<T> query, List<FilterCondition> conditions)
        {
            foreach (var condition in conditions)
            {
                if (string.IsNullOrEmpty(condition.Column) || string.IsNullOrEmpty(condition.Operator))
                    continue;

                var whereClause = BuildWhereClause(condition);
                if (!string.IsNullOrEmpty(whereClause))
                {
                    query = query.Where(whereClause, GetConditionValues(condition));
                }
            }
            return query;
        }

        private string BuildWhereClause(FilterCondition condition)
        {
            return condition.Operator.ToUpper() switch
            {
                "=" => $"{condition.Column} == @0",
                "!=" => $"{condition.Column} != @0",
                "CONTAINS" => $"{condition.Column}.Contains(@0)",
                "STARTS WITH" => $"{condition.Column}.StartsWith(@0)",
                ">" => $"{condition.Column} > @0",
                "<" => $"{condition.Column} < @0",
                "BETWEEN" => $"{condition.Column} >= @0 && {condition.Column} <= @1",
                _ => null
            };
        }

        private object[] GetConditionValues(FilterCondition condition)
        {
            if (condition.Operator.ToUpper() == "BETWEEN")
            {
                return new object[] { condition.Value, condition.SecondValue };
            }
            return new object[] { condition.Value };
        }

        private IQueryable<T> ApplySorting<T>(IQueryable<T> query, string sortColumn, bool descending)
        {
            var orderClause = $"{sortColumn} {(descending ? "DESC" : "ASC")}";
            return query.OrderBy(orderClause);
        }

        private List<Dictionary<string, object>> ConvertToDictionaryList<T>(List<T> data)
        {
            var result = new List<Dictionary<string, object>>();

            foreach (var item in data)
            {
                var dict = new Dictionary<string, object>();
                var properties = typeof(T).GetProperties();

                foreach (var prop in properties)
                {
                    dict[prop.Name] = prop.GetValue(item) ?? "";
                }

                result.Add(dict);
            }

            return result;
        }

        private List<string> GetColumnNames<T>(List<T> data)
        {
            if (!data.Any())
                return new List<string>();

            return typeof(T).GetProperties().Select(p => p.Name).ToList();
        }

        public async Task<Stream> GenerateCsvStreamAsync(QueryBuilderModel query)
        {
            if (query.TableName == "FSI")
            {
                return await GenerateFSICsvStreamAsync(query);
            }
            else if (query.TableName == "ProtectedTowns")
            {
                return await GenerateProtectedTownsCsvStreamAsync(query);
            }

            return new MemoryStream();
        }

        private async Task<Stream> GenerateFSICsvStreamAsync(QueryBuilderModel query)
        {
            await using var context = await _dbFactory.CreateDbContextAsync();

            var dbQuery = context.FSI.AsQueryable();

            // Apply filters
            dbQuery = ApplyFilters(dbQuery, query.Conditions);

            // Apply sorting
            if (!string.IsNullOrEmpty(query.SortColumn))
            {
                dbQuery = ApplySorting(dbQuery, query.SortColumn, query.SortDescending);
            }

            var memoryStream = new MemoryStream();
            await using var writer = new StreamWriter(memoryStream, Encoding.UTF8, leaveOpen: true);

            // Write UTF-8 BOM for Excel compatibility
            await writer.WriteAsync('\ufeff');

            // Write headers
            var headers = GetHeaders(query, "FSI");
            await writer.WriteLineAsync(string.Join(",", headers.Select(EscapeCsvValue)));

            // Stream data
            await foreach (var fsi in dbQuery.AsAsyncEnumerable())
            {
                var rowValues = GetFSIRowValues(fsi, query);
                await writer.WriteLineAsync(string.Join(",", rowValues.Select(EscapeCsvValue)));

                if (writer.BaseStream.Length > 1024 * 1024 * 10) // 10MB chunks
                {
                    await writer.FlushAsync();
                }
            }

            await writer.FlushAsync();
            memoryStream.Position = 0;
            return memoryStream;
        }

        private List<string> GetHeaders(QueryBuilderModel query, string tableName)
        {
            if (query.IncludeAllColumns)
            {
                return GetAvailableColumns(tableName)
                    .Select(c => c.DisplayName)
                    .ToList();
            }
            else
            {
                // Map column names to display names
                var availableColumns = GetAvailableColumns(tableName);
                return query.SelectedColumns
                    .Select(col => availableColumns.FirstOrDefault(c => c.Name == col)?.DisplayName ?? col)
                    .ToList();
            }
        }

        private List<string> GetFSIRowValues(FSI fsi, QueryBuilderModel query)
        {
            var values = new List<string>();
            var properties = typeof(FSI).GetProperties();

            if (query.IncludeAllColumns)
            {
                // Return all property values
                foreach (var prop in properties)
                {
                    values.Add(FormatValue(prop.GetValue(fsi), prop.PropertyType));
                }
            }
            else
            {
                // Return only selected columns
                foreach (var column in query.SelectedColumns)
                {
                    var prop = properties.FirstOrDefault(p => p.Name == column);
                    values.Add(FormatValue(prop?.GetValue(fsi), prop?.PropertyType));
                }
            }
            return values;
        }

        private async Task<Stream> GenerateProtectedTownsCsvStreamAsync(QueryBuilderModel query)
        {
            await using var context = await _dbFactory.CreateDbContextAsync();

            var dbQuery = context.ProtectedTowns.AsQueryable();

            // Apply filters
            dbQuery = ApplyFilters(dbQuery, query.Conditions);

            // Apply sorting
            if (!string.IsNullOrEmpty(query.SortColumn))
            {
                dbQuery = ApplySorting(dbQuery, query.SortColumn, query.SortDescending);
            }

            var memoryStream = new MemoryStream();
            await using var writer = new StreamWriter(memoryStream, Encoding.UTF8, leaveOpen: true);

            // Write UTF-8 BOM for Excel compatibility
            await writer.WriteAsync('\ufeff');

            // Write headers
            var headers = GetHeaders(query, "ProtectedTowns");
            await writer.WriteLineAsync(string.Join(",", headers.Select(EscapeCsvValue)));

            // Stream data
            await foreach (var town in dbQuery.AsAsyncEnumerable())
            {
                var rowValues = GetProtectedTownsRowValues(town, query);
                await writer.WriteLineAsync(string.Join(",", rowValues.Select(EscapeCsvValue)));

                if (writer.BaseStream.Length > 1024 * 1024 * 10)
                {
                    await writer.FlushAsync();
                }
            }

            await writer.FlushAsync();
            memoryStream.Position = 0;
            return memoryStream;
        }

        private List<string> GetProtectedTownsRowValues(ProtectedTowns town, QueryBuilderModel query)
        {
            var values = new List<string>();
            var properties = typeof(ProtectedTowns).GetProperties();

            if (query.IncludeAllColumns)
            {
                foreach (var prop in properties)
                {
                    values.Add(FormatValue(prop.GetValue(town), prop.PropertyType));
                }
            }
            else
            {
                foreach (var column in query.SelectedColumns)
                {
                    var prop = properties.FirstOrDefault(p => p.Name == column);
                    values.Add(FormatValue(prop?.GetValue(town), prop?.PropertyType));
                }
            }
            return values;
        }

        private string FormatValue(object value, Type propertyType)
        {
            if (value == null)
                return "";

            try
            {
                // Handle TimeOnly? (nullable TimeOnly)
                if (value is TimeOnly timeOnly)
                {
                    return timeOnly.ToString("HH:mm:ss");
                }

                // Handle nullable TimeOnly explicitly
                if (value.GetType() == typeof(TimeOnly?))
                {
                    var nullableTime = (TimeOnly?)value;
                    return nullableTime?.ToString("HH:mm:ss") ?? "";
                }

                // Handle DateOnly (both nullable and non-nullable)
                if (value is DateOnly dateOnly)
                {
                    return dateOnly.ToString("yyyy-MM-dd");
                }

                // Handle nullable DateOnly
                if (value.GetType() == typeof(DateOnly?))
                {
                    var nullableDate = (DateOnly?)value;
                    return nullableDate?.ToString("yyyy-MM-dd") ?? "";
                }

                // Handle DateTime
                if (value is DateTime dateTime)
                {
                    return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                }

                // Handle nullable DateTime
                if (value.GetType() == typeof(DateTime?))
                {
                    var nullableDateTime = (DateTime?)value;
                    return nullableDateTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "";
                }

                // Handle enums
                if (propertyType.IsEnum || (Nullable.GetUnderlyingType(propertyType)?.IsEnum ?? false))
                {
                    return value.ToString() ?? "";
                }

                // Default conversion
                return value.ToString() ?? "";
            }
            catch
            {
                return "";
            }
        }

        private string EscapeCsvValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            // Prevent formula injection
            if (value.StartsWith("=") || value.StartsWith("+") ||
                value.StartsWith("-") || value.StartsWith("@") ||
                value.StartsWith("\t") || value.StartsWith("\""))
            {
                value = "'" + value;
            }

            bool needsQuotes = value.Contains(",") ||
                              value.Contains("\"") ||
                              value.Contains("\n") ||
                              value.Contains("\r") ||
                              value.StartsWith(" ") ||
                              value.EndsWith(" ");

            if (needsQuotes)
            {
                value = value.Replace("\"", "\"\"");
                return $"\"{value}\"";
            }

            return value;
        }
    }
}
