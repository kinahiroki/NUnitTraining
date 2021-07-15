namespace NUnitTraining.NUnitTarget.Calculator.Logic
{
    /// <summary>
    /// 演算インターフェース
    /// </summary>
    /// <remarks>
    /// 演算メソッドを定義する。
    /// </remarks>
    interface ICalculationLogic
    {
        /// <summary>
        /// 足し算
        /// </summary>
        /// <remarks>
        /// ２つの数値の和を求める。
        /// </remarks>
        /// <param name="aggregate">被加数</param>
        /// <param name="addend">加数</param>
        /// <returns>２つの数値の和</returns>
        string Add(string aggregate, string addend);

        string Subtract(string inputFirstNumber, string inputSecondNumber);

        /// <summary>
        /// 掛け算
        /// </summary>
        /// <remarks>
        /// ２つの数値の積を求める。
        /// </remarks>
        /// <param name="multiplicand">被乗数</param>
        /// <param name="multiplier">乗数</param>
        /// <returns>２つの数値の積</returns>
        string Multiply(string multiplicand, string multiplier);

        string Divide(string inputFirstNumber, string inputSecondNumber);
    }
}
