namespace KendoUI.Mvc.UI
{
    using System.Collections.Generic;
    using KendoUI.Mvc.Infrastructure;
    using KendoUI.Mvc.Extensions;

    internal class ChartLineSerializer : IChartSerializer
    {
        private readonly ChartLine line;

        public ChartLineSerializer(ChartLine line)
        {
            this.line = line;
        }

        public virtual IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();
            
            FluentDictionary.For(result)
                .Add("width", line.Width, () => line.Width.HasValue)
                .Add("opacity", line.Opacity, () => line.Opacity.HasValue)
                .Add("color", line.Color, () => line.Color.HasValue())
                .Add("dashType", line.DashType.ToString().ToLowerInvariant(), () => line.DashType.HasValue)
                .Add("visible", line.Visible, () => line.Visible.HasValue);

            return result;
        }
    }
}