using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a meal cost.")]
        [Range(.01, 9999999999999999999, ErrorMessage = "Please enter a valid meal cost.")]
        public decimal? MealCost { get; set; }

        public decimal? FifteenTip()
        {
            decimal? FifteenTip = 0;
            decimal? FifteenPercent = (decimal?).15;
            FifteenTip = MealCost * FifteenPercent;
            return FifteenTip;
        }

        public decimal? TwentyTip()
        {
            decimal? TwentyTip = 0;
            decimal? TwentyPercent = (decimal?).20;
            TwentyTip = MealCost * TwentyPercent;
            return TwentyTip;
        }


        public decimal? TwentyFiveTip()
        {
            decimal? TwentyFiveTip = 0;
            decimal? TwentyFivePercent = (decimal?).25;
            TwentyFiveTip = MealCost * TwentyFivePercent;
            return TwentyFiveTip;
        }






    }
}
