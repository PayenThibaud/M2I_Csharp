using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01.Bibliotheque;

namespace Essaie.TestNUnit
{
    internal class CalculTest
    {
        [TestFixture]
        public class GradingCalculatorTests
        {
            [TestCase(95, 90, 'A', TestName = "Score_95_Presence_90_Should_Return_A")]
            [TestCase(85, 90, 'B', TestName = "Score_85_Presence_90_Should_Return_B")]
            [TestCase(65, 90, 'C', TestName = "Score_65_Presence_90_Should_Return_C")]
            [TestCase(95, 65, 'B', TestName = "Score_95_Presence_65_Should_Return_B")]
            [TestCase(95, 55, 'F', TestName = "Score_95_Presence_55_Should_Return_F")]
            [TestCase(65, 55, 'F', TestName = "Score_65_Presence_55_Should_Return_F")]
            [TestCase(50, 90, 'F', TestName = "Score_50_Presence_90_Should_Return_F")]

            public void GetGrade_Should_Return_Correct_Grade(int score, int attendancePercentage, char expectedGrade)
            {
                
                var calculator = new GradingCalculator
                {
                    Score = score,
                    AttendancePercentage = attendancePercentage
                };
                
                char result = calculator.GetGrade();
                
                Assert.AreEqual(expectedGrade, result);
            }
        }
    }
}