namespace Core.Service.Cms
{
    public class ResponseModel
    {
        public required int total {  get; set; }
        public required IEnumerable<ContentResponseModel<PropertiesConfigRouteModel>> items { get; set; }
    }
    public class ContentResponseModel<Properties> where Properties : class
    {
        public string? name { get; set; }
        public required string createDate { get; set; }
        public required string updateDate { get; set; }
        public required string id { get; set; }
        public required string contentType { get; set; }
        public required object cultures { get; set; }
        public required Properties properties { get; set; }
    }
}

public class RouteResponseModel
{
    public required string path { get; set; }
    public required StartItemResponseModel startItem { get; set; }
}
public class StartItemResponseModel
{
    public required string id { get; set; }
    public required string path { get; set; }
}
public class PropertiesConfigRouteModel
{
    public required string name_custom { get; set; }
    public required string url { get; set; }
}
