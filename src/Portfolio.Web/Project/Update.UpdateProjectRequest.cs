using Portfolio.Core.Modal;

namespace Portfolio.Web.EndPoints.ProjectEndPoints;

public class UpdateProjectRequest
{
  public int Id { get; set; } 
  public required Projects project { get; set; }
}
