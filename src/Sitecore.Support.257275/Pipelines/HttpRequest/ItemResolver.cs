using Sitecore.Pipelines.HttpRequest;

namespace Sitecore.Support.Pipelines.HttpRequest
{
  public class ItemResolver:Sitecore.Pipelines.HttpRequest.ItemResolver
  {
    public override void Process(HttpRequestArgs args)
    {
      bool permissionDenied = args.PermissionDenied;
      base.Process(args);
      args.PermissionDenied |= permissionDenied;
    }
  }
}