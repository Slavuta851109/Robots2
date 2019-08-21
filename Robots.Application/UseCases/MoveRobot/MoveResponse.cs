namespace Robots.Application.UseCases
{
    public class MoveResponse
    {
        public int CleanedVertices { get; }

        public MoveResponse(int cleanedVertices)
        {
            this.CleanedVertices = cleanedVertices;
        }
    }
}