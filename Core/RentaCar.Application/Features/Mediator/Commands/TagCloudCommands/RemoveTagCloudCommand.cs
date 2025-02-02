using MediatR;

namespace RentaCar.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class RemoveTagCloudCommand: IRequest
    {
        public int Id { get; set; }

        public RemoveTagCloudCommand(int id)
        {
            Id = id;
        }
    }
}