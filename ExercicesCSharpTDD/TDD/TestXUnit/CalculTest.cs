using Demo01.Bibliotheque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXUnit
{
    public class GradingCalculatorTests
    {
        [Theory]
        [InlineData(95, 90, 'A', "Score_95_Presence_90_Should_Return_A")]
        [InlineData(85, 90, 'B', "Score_85_Presence_90_Should_Return_B")]
        [InlineData(65, 90, 'C', "Score_65_Presence_90_Should_Return_C")]
        [InlineData(95, 65, 'B', "Score_95_Presence_65_Should_Return_B")]
        [InlineData(95, 55, 'F', "Score_95_Presence_55_Should_Return_F")]
        [InlineData(65, 55, 'F', "Score_65_Presence_55_Should_Return_F")]
        [InlineData(50, 90, 'F', "Score_50_Presence_90_Should_Return_F")]
        public void GetGrade_Should_Return_Correct_Grade(int score, int attendancePercentage, char expectedGrade, string testName)
        {
            
            var calculator = new GradingCalculator
            {
                Score = score,
                AttendancePercentage = attendancePercentage
            };

            char result = calculator.GetGrade();

            Assert.Equal(expectedGrade, result);
        }
    }
}