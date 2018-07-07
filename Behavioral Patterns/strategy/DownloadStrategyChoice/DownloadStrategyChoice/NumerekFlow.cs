namespace DownloadStrategyChoice
{
    class NumerekFlow
    {
        public IDownloadStrategy Strategy { get; set; }

        public NumerekFlow(IDownloadStrategy strategy)
        {
            this.Strategy = strategy;
        }
     }
}
