using System;
using Robots.Domain;

namespace Robots.Application.UseCases
{
    public class MoveRobotUseCase : IUseCase<MoveRequest, MoveResponse>
    {
        public MoveResponse Execute(MoveRequest request)
        {
            var robot = new Robot(request.StartPosition);
            foreach (var command in request.Commands)
            {
                robot.Move(command);
            }

            int cleaned = robot.GetCleanedVertices();

            return new MoveResponse(cleaned);
        }
    }
}
