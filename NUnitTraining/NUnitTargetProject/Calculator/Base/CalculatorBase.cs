namespace NUnitTargetProject.Calculator.Base
{
    /// <summary>
    /// 演算基底クラス
    /// </summary>
    /// <remarks>
    /// 各演算クラスの共通処理を定義
    /// </remarks>
    public class CalculatorBase
    {
        /// <summary>有効桁数</summary>
        /// <remarks>有効桁数</remarks>
        internal int NumberOfSignificantFigures { get; private set; }

        /// <summary>
        /// 演算クラス用引数チェック
        /// </summary>
        /// <remarks>
        /// 演算を行う際に使う数値のチェックを行う。
        /// チェック内容は以下の通りとする。
        /// ①必須チェック
        /// ②数値チェック
        /// </remarks>
        /// <param name="argNumber1">引数の数値1</param>
        /// <param name="argNumber2">引数の数値2</param>
        /// <returns>チェック結果</returns>
        internal bool IsCheckArgumentValue(string argNumber1, string argNumber2)
        {
            if (string.IsNullOrEmpty(argNumber1) ||
                string.IsNullOrEmpty(argNumber2))
            {
                // いずれかの値が未設定の場合
                return false;
            }

            if (!decimal.TryParse(argNumber1, out _) ||
                !decimal.TryParse(argNumber2, out _))
            {
                // 数値以外の場合
                return false;
            }

            return true;
        }

        /// <summary>
        /// 有効桁数チェック
        /// </summary>
        /// <remarks>
        /// 設定されている有効桁数のチェックを行う。
        /// 設定値が数値以外の場合はfalseを返す。
        /// 未設定の場合は、デフォルト値を使うため、trueを返す。
        /// </remarks>
        /// <param name="numberOfSignificantFigures">有効桁数</param>
        /// <returns>チェック結果</returns>
        internal bool IsCheckArgumentNumberOfSignificantFigures(string numberOfSignificantFigures)
        {
            if (!string.IsNullOrEmpty(numberOfSignificantFigures) &&
                !int.TryParse(numberOfSignificantFigures, out _))
            {
                // 設定値が数値以外の場合
                return false;
            }

            return true;
        }

        /// <summary>
        /// 有効桁数の設定
        /// </summary>
        /// <remarks>
        /// 引数チェック後の有効桁数を設定する。
        /// ただし、未設定の場合はデフォルト値"0"を設定する。
        /// </remarks>
        /// <param name="numberOfSignificantFigures">有効桁数</param>
        internal void SetNumberOfSignificantFigures(string numberOfSignificantFigures)
        {
            if (string.IsNullOrEmpty(numberOfSignificantFigures))
            {
                // 未設定の場合
                NumberOfSignificantFigures = 0;
            }
            else
            {
                // 設定済の場合
                NumberOfSignificantFigures = int.Parse(numberOfSignificantFigures);
            }
        }
    }
}
