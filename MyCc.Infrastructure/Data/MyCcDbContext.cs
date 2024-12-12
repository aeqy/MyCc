using Microsoft.EntityFrameworkCore;

namespace MyCc.Infrastructure.Data;

public class MyCcDbContext(DbContextOptions<MyCcDbContext> options): DbContext(options)
{
    
}