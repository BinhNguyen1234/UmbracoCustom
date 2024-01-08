namespace Core.DTO.Cms
{
    public class ResponseModel<Properties> where Properties : class
    {
        public required int total { get; set; }
        public required IEnumerable<ItemModel<Properties>> items { get; set; }
    }
    public class ItemModel<Properties> where Properties : class
    {
        public string? name { get; set; }
        public required string createDate { get; set; }
        public required string updateDate { get; set; }
        public required string id { get; set; }
        public required string contentType { get; set; }
        public required object cultures { get; set; }
        public required RouteResponseModel route { get; set; }
        public required Properties properties { get; set; }
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
}
