using FeatureManagement.Shared.Features;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace FeatureManagement.Client.Pages;

public class IndexBase : ComponentBase
{
    [Inject]
    public IOptionsSnapshot<FeatureFlagOptions> FeatureFlagsSnapshot { get; set; } = null!;

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }
}
