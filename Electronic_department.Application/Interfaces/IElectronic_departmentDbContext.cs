using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Electronic_department.Domain;

namespace Electronic_department.Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Elect> Electronic_department { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
