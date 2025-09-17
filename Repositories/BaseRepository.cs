namespace hrm_api.Services;

public class BaseRepository<T> where T : class
{
    protected readonly T _dbContext;

    public BaseRepository(T dbContext)
    {
        _dbContext = dbContext;
    }
}