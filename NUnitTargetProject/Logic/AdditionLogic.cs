using System;

namespace NUnitTargetProject.Logic
{
    public class AdditionLogic
    {
        private decimal Augend { get; set; }

        private decimal Addend { get; set; }

        private int NumberOfSignificantFigures { get; set; }

        public AdditionLogic(string num1, string num2, string digits)
        {
            if (!IsConfiguredValidValue(num1) || !IsConfiguredValidValue(num2) || !IsConfiguredValidValue(digits))
            {
                // 有効な値が設定されていない場合
                throw new ArgumentException();
            }

            // 数値の設定
            Augend = decimal.Parse(num1);
            Addend = decimal.Parse(num2);

            // 有効桁数の設定
            if (string.IsNullOrEmpty(digits))
            {
                // 未設定の場合、デフォルト値を設定
                NumberOfSignificantFigures = 0;
            }
            else
            {
                // 設定されている場合
                NumberOfSignificantFigures = int.Parse(digits);
            }
        }

        public string Add()
        {
            var result = decimal.Add(Augend, Addend);
            return decimal.Round(result, NumberOfSignificantFigures).ToString();
        }

        private bool IsConfiguredValidValue(string checkTargetValue)
        {
            if (!string.IsNullOrEmpty(checkTargetValue))
            {
                // 未設定の場合
                return false;
            }

            if (!decimal.TryParse(checkTargetValue, out _))
            {
                // 数値以外が設定されている場合
                return false;
            }

            return true;
        }
    }
}
