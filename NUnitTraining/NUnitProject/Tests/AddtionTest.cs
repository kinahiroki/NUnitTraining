using NUnit.Framework;
using NUnitTargetProject.Calculator.Logic;

namespace NUnitProject.Tests
{
    /// <summary>
    /// 足し算テストクラス
    /// </summary>
    /// <remarks>
    /// 足し算クラスの検証を行うテストクラス
    /// </remarks>
    [TestFixture]
    public class AddtionTest
    {
        [Test]
        public void AddTest()
        {
            // テストケースは「AAA(Arrange, Act, Assert)」パターンに基づき記載する。
            // Arrange(配置)
            // テストを行うためのセットアップを行うセクション
            var inputAugend = "1.09999";
            var inputAddend = "1.00009";
            var inputNumberOfSignificantFigures = "2";

            // Act(実行)
            // テスト対象を呼び出すセクション
            var testTarget = new Addtion(inputAugend, inputAddend, inputNumberOfSignificantFigures);
            var actualResult = testTarget.Add();

            // Assert(検証)
            // 実施結果が期待結果を満たしているかを確認するセクション
            Assert.AreEqual("2.10", actualResult);
        }
    }
}
