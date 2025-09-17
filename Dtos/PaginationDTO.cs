namespace DTOLayer
{
    public class PaginationDTO
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public PaginationDTO()
        {
            PageNumber = 1;
            PageSize = 5000;
        }
        public PaginationDTO Validate()
        {
            PageNumber = PageNumber < 1 ? 1 : PageNumber;
            PageSize = PageSize > 5000 ? 10 : PageSize;
            return this;
        }
        public PaginationDTO(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 5000 ? 10 : pageSize;
        }

        public int GetSkip()
        {
            return (PageNumber - 1) * PageSize;
        }
    }
}