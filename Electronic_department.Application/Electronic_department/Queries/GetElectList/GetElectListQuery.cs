using System;
using MediatR;

namespace Electronic_department.Application.Electronic_department.Queries.GetElectList
{
    public class GetElectListQuery : IRequest<ElectListVm>
    {
        public Guid UserId { get; set; }
    }
}
