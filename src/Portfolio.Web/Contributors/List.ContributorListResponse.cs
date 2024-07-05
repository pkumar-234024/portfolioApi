using Portfolio.Web.ContributorEndpoints;

namespace Portfolio.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
