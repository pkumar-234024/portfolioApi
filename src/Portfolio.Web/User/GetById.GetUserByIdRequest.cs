namespace Portfolio.Web.Endpoints.UserEndPoints;

public class GetUserByIdRequest
{
  public const string Route = "/Users/{Users:int}";
  public static string BuildRoute(int contributorId) => Route.Replace("{Users:int}", contributorId.ToString());

  public int Id { get; set; }
}
