﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Electronic_department.Application.Electronic_department.Commands.CreateElect;
using Electronic_department.Tests.Common;
using Xunit;

namespace Electronic_department.Tests.Electronic_department.Commands
{
    public class CreateElectCommandHandlerTests : TestCommandBase
    {
        [Fact]
        public async Task CreateElectCommandHandler_Success()
        {
            // Arrange
            var handler = new CreateElectCommandHandler(Context);
            var electName = "elect name";
            var electDetails = "elect details";

            // Act
            var electId = await handler.Handle(
                new CreateElectCommand
                {
                    Title = electName,
                    Details = electDetails,
                    UserId = Electronic_departmentContextFactory.UserAId
                },
                CancellationToken.None);

            // Assert
            Assert.NotNull(
                await Context.Electronic_department.SingleOrDefaultAsync(elect =>
                    elect.Id == electId && elect.Title == electName &&
                    elect.Details == electDetails));
        }
    }
}
