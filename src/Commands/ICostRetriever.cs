public interface ICostRetriever
{
    Task<IEnumerable<CostItem>> RetrieveCosts(bool includeDebugOutput, Guid subscriptionId,
        TimeframeType timeFrame, DateOnly from, DateOnly to);

    Task<IEnumerable<CostNamedItem>> RetrieveCostByServiceName(bool includeDebugOutput,
        Guid subscriptionId, TimeframeType timeFrame, DateOnly from, DateOnly to);

    Task<IEnumerable<CostNamedItem>> RetrieveCostByLocation(bool includeDebugOutput, Guid subscriptionId,
        TimeframeType timeFrame, DateOnly from, DateOnly to);

    Task<IEnumerable<CostNamedItem>> RetrieveCostByResourceGroup(bool includeDebugOutput, Guid subscriptionId,
        TimeframeType timeFrame, DateOnly from, DateOnly to);

    Task<IEnumerable<CostItem>> RetrieveForecastedCosts(bool includeDebugOutput, Guid subscriptionId);
}