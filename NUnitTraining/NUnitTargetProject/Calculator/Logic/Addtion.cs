using NUnitTargetProject.Calculator.Base;
using System;

namespace NUnitTargetProject.Calculator.Logic
{
    /// <summary>
    /// 足し算クラス
    /// </summary>
    /// <remarks>
    /// 足し算クラス
    /// </remarks>
    public class Addtion : CalculatorBase
    {
        /// <summary>有効な被加数</summary>
        /// <remarks>有効な被加数</remarks>
        private decimal Augend { get; set; }

        /// <summary>有効な加数</summary>
        /// <remarks>有効な加数</remarks>
        private decimal Addend { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 足し算処理で使う数値の引数チェックを行う。
        /// 引数チェックでエラーの場合、例外を返す。
        /// </remarks>
        /// <exception cref="ArgumentException">引数の値が不正だった場合</exception>
        /// <param name="augend">チェック前の被加数</param>
        /// <param name="addend">チェック前の加数</param>
        /// <param name="numberOfSignificantFigures">有効桁数 ※デフォルトは0桁</param>
        public Addtion(string augend, string addend, string numberOfSignificantFigures)
        {
            if (!IsCheckArgumentValue(augend, addend) ||
                !IsCheckArgumentNumberOfSignificantFigures(numberOfSignificantFigures))
            {
                // 引数チェックエラーの場合
                throw new ArgumentException();
            }

            // 演算で使う数値の設定
            Augend = decimal.Parse(augend);
            Addend = decimal.Parse(addend);

            // 有効桁数の設定
            SetNumberOfSignificantFigures(numberOfSignificantFigures);
        }

        /// <summary>
        /// 足し算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の和を求める。
        /// さらに計算後は、指定した有効桁数に丸め処理を行う。
        /// </remarks>
        /// <returns>和</returns>
        public string Add()
        {
            decimal result = decimal.Add(Augend, Addend);
            return decimal.Round(result, NumberOfSignificantFigures).ToString();
        }
    }
}
