namespace CBF.Domain.Response;
public class PagedResponse<T>
{
    public IEnumerable<T> Result { get; set; }
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
    public int TotalItems { get; set; }
}
