using Portfolio.Core.Modal;

namespace Portfolio.Web.EndPoints.UserEndPoints;

public class UsersListResponse
{
  public List<Users> Users { get; set; }  = new List<Users>();
}
