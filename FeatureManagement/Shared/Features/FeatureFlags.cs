namespace FeatureManagement.Shared.Features;

public class FeatureFlags
{
    public const string FeatureA = "FeatureA";
    public const string FeatureB = "FeatureB";
    public const string FeatureC = "FeatureC";

    public static IEnumerable<string> Features()
    {
        yield return FeatureA;
        yield return FeatureB;
        yield return FeatureC;
    }
}
