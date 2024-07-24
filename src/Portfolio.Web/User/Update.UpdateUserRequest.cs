using Portfolio.Core.Modal;

namespace Portfolio.Web.EndPoints.UserEndPoints;

public class UpdateUserRequest
{
  public int Id { get; set; }
  public required Users users { get; set; }
}
