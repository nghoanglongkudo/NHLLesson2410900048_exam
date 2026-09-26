using Microsoft.EntityFrameworkCore;

public class NHLLesson2410900048_examContext(DbContextOptions<NHLLesson2410900048_examContext> options) : DbContext(options)
{
    public DbSet<NguyenHoangLong2410900048_exam.Models.NhlEmployee> NhlEmployee { get; set; } = default!;
}
