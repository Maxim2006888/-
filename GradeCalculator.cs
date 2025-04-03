using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текущий_контроль
{
    public static class GradeCalculator
    {
        public static double CalculateTotalScore(double[] scores)
        {
            if (scores == null || scores.Length == 0)
                throw new ArgumentException("Список баллов не может быть пустым.");

            double total = 0;
            foreach (var score in scores)
            {
                if (score < 0)
                    throw new ArgumentException("Баллы не могут быть отрицательными.");
                total += score;
            }
            return total;
        }

        public static string GetGrade(double totalScore)
        {
            int roundedScore = (int)Math.Round(totalScore); // Округляем перед сравнением

            if (roundedScore >= 45) return "5";
            if (roundedScore >= 40) return "4";
            if (roundedScore >= 30) return "3";
            if (roundedScore >= 20) return "2";
            return "1";
        }

    }
}
