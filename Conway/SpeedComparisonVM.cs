using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway
{
    public class SpeedComparisonVM
    {
        public decimal? InfectionSpeed { get; set; }
        public decimal? InfectionSpeedTwoDaysQuarantine { get; set; }
        public decimal? InfectionSpeedThreeDaysQuarantine { get; set; }
        public decimal InfectionPercentage { get; set; }
        public decimal InfectionPercentageTwoDaysQuarantine { get; set; }
        public decimal InfectionPercentageThreeDaysQuarantine { get; set; }

    }
}
