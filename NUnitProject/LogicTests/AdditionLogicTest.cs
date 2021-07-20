using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitProject.LogicTests
{
    // ①テストクラスの宣言
    // (1) [TestFixure]属性を付与⇒このクラスがテストクラスであることを宣言
    //    ※テストクラスは「public」であること

    [TestFixture]
    public class AdditionLogicTest
    {
        // ②テストケースの追加 Part1
        // (1) [Test]属性を付与⇒テストを行うメソッドであることを宣言
        //    ※テストケースは「public」で戻り値なしのメソッドであること
        // (2) メソッド名は[呼び出すメソッド名] + Test

        [Test]
        public void AddTest()
        {
            // テストケースの記述

        }
    }
}
