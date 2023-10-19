using Microsoft.AspNetCore.Components;

namespace FeatureManagement.Client.Pages;

public class CounterBase : ComponentBase
{
    public long Count { get; set; }

    public void IncreaseCount()
    {
        Count++;
    }

    public void DecreaseCount()
    {
        Count--;
    }
}
