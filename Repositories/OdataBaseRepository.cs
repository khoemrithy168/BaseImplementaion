using AutoMapper;
using hrm_api.Data;
using hrm_api.Dtos;
using hrm_api.Model.Base;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace hrm_api.Services;

public abstract class OdataBaseRepository<T> : BaseRepository<AppDbContext> where T : BaseEntity
{
     private readonly IMapper _mapper;
    public OdataBaseRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    // public IQueryable<T> GetQueryable(IdentityDTO dto)
    // {
    //     return _dbContext.Set<T>().AsQueryable();
    // }

    public AppDbContext GetDB()
    {
        return (AppDbContext) _dbContext;
    }

    [EnableQuery(MaxExpansionDepth = 4)]
    public virtual IQueryable<T> GetQueryable()
    {
        return _dbContext.Set<T>().Where(x => x.Status > 0).AsQueryable();
    }

    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public virtual async Task<T> SaveAsync(T entity)
    {
        _dbContext.Set<T>().Add(entity); 
        await _dbContext.SaveChangesAsync();
        return entity;
    }
    
    public virtual async Task<T> SaveAsync(T entity, IdentityDTO identityDto)
    {
        _dbContext.Set<T>().Add(entity); 
        entity.CreatedBy = identityDto.Username;
        entity.CreatedDateTime = DateTime.Now;
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<T> UpdateAsync(int id, Delta<T> delta, IdentityDTO getTokenInfo)
    {
        var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(x=>x.ObjectID == id && x.Status == 1);

        if (entity == null)
        {
            throw new ArgumentException("Entity not found");
        }

        delta.Patch(entity);
        entity.ModifiedBy = getTokenInfo.Username;
        entity.ModifiedDateTime = DateTime.Now;
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<TDto> UpdateDtoAsync<TDto>(int id, TDto dto, IdentityDTO getTokenInfo)
        where TDto : class
    {
        if (_mapper == null)
            throw new InvalidOperationException("Mapper is required for DTO operations");

        var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.ObjectID == id && x.Status == 1);

        if (entity == null)
        {
            throw new ArgumentException("Entity not found");
        }
        _mapper.Map(dto, entity);

        entity.ModifiedBy = getTokenInfo.Username;
        entity.ModifiedDateTime = DateTime.Now;

        await _dbContext.SaveChangesAsync();
        return _mapper.Map<TDto>(entity);
    }
    
    public virtual async Task<T> DeleteAsync(int id )
    {
        var entity = await _dbContext.Set<T>().FindAsync(id);

        if (entity == null)
        {
            throw new ArgumentException("Entity not found");
        }
    
        entity.Disable();
        await _dbContext.SaveChangesAsync();
        return entity;
    }
    internal int GetRenewalInterval(string renewalType)
    {
        // Map RenewalType to interval in months
        return renewalType switch
        {
            "Quarterly" => 3,
            "Half - Yearly" => 6,
            "Yearly" => 12,
            "Monthly" => 1,
            _ => 0 // Unsupported or unknown types
        };
    }

    // public async Task<string> GenerateInvoice(bool IsTaxInvoice = false)
    // {
    //    var count = await _dbContext.Invoices.CountAsync(x =>
    //         x.FiscalYear == DateTime.Now.Year  && x.Status > 0 ); //&& x.Month == DateTime.Now.Month
    //    
    //    return  IsTaxInvoice ? $"PMF{DateTime.Now.Year}01{count + 1:D6}" : $"PMF{DateTime.Now.Year}02{count + 1:D6}";
    // }

    // public async Task<string> GenerateQuotationNumberRange(string prefix)
    // {
    //     var now = DateTime.UtcNow;
    //     var currentYear = now.Year;
    //     var currentMonth = now.Month;
    //     var yearMonthPrefix = $"{prefix}{currentYear}{currentMonth:D2}";
    //
    //     // Get quotation numbers for this year/month and process in memory
    //     var quotationNumbers = await _dbContext.Quotations
    //         .Where(x => x.FiscalYear == currentYear
    //                     && x.Month == currentMonth
    //                     && x.QuotationNumber.StartsWith(yearMonthPrefix))
    //         .Select(x => x.QuotationNumber)
    //         .ToListAsync();
    //
    //     var maxSequenceNumber = 0;
    //     if (quotationNumbers.Any())
    //     {
    //         maxSequenceNumber = quotationNumbers
    //             .Select(qn => qn.Substring(yearMonthPrefix.Length))
    //             .Where(seq => seq.Length == 6 && seq.All(char.IsDigit))
    //             .Select(seq => int.Parse(seq))
    //             .DefaultIfEmpty(0)
    //             .Max();
    //     }
    //
    //     var nextSequence = maxSequenceNumber + 1;
    //     return $"{yearMonthPrefix}{nextSequence:D6}";
    // }
    
    // public async Task<string> GenerateReceipt()
    // {
    //     var count = await _dbContext.Payments.CountAsync(x =>
    //         x.FiscalYear == DateTime.Now.Year && x.Month == DateTime.Now.Month && x.Status > 0 ); //
    //    
    //     return  $"PMF{DateTime.Now.Year}{DateTime.Now.Month:D2}03{count + 1:D6}";
    // }
}