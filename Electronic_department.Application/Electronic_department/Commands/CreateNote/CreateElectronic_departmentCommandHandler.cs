using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Electronic_department.Application.Electronic_department.Commands.CreateNote
{
    public class CreateNoteCommandHandler
        :IRequestHandler<CreateElectCommand, Guid>
    {
        private readonly IElectronic_departmentDbContext _dbContext;

        public CreateElectCommandHandler(IElectronic_departmentDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(CreateElectCommand request,
            CancellationToken cancellationToken)
        {
            var elect = new Elect
            {
                UserId = request.UserId,
                Title = request.Title,
                Details = request.Details,
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
                EditDate = null
            };

            await _dbContext.Electronic_department.AddAsync(note, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return elect.Id;
        }
    }
}
