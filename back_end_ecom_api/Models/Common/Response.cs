namespace back_end_ecom_api.Models.Common
{
    public interface IResponseData
    {

    }

    public class ResponseMessageModel<T>
    {
        public string Message { get; set; } = string.Empty;
        public int StatusCode { get; set; } = 200;
        public T? Data { get; set; }
    }

    public class PaginationSet<T> where T : class, new()
    {
        public IEnumerable<T> list { get; set; }
        public int page { get; set; }

        public int count
        {
            get
            {
                return list != null ? list.Count() : 0;
            }
        }
        public int total_page { get; set; } = 1;
        public int total_count { get; set; } = 0;
        public int max_page { get; set; }
    }

    public class Response
    {
    }
}
