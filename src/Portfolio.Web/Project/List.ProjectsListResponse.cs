using Portfolio.Core.Modal;

namespace Portfolio.Web.EndPoints.ProjectEndPoints;

public class ProjectsListResponse
{
  public List<Projects> Projects { get; set; } = new List<Projects>();
}
