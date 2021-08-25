using System;
using System.Drawing;
using TestExercise.Configuration;

namespace TestExercise.Data
{
    public class Profile
    {
        public string FamilyName { get; private set; } // Фамилия
        public string FirstName { get; private set; } // Имя
        public string SecondName { get; private set; } // Отчество
        public float Temperature { get; private set; }
        public Image Photo { get; private set; }
        public DateTime DateCreation { get; private set; } 

        public Profile(string familyName, string firstName, string secondName, in float temperature, Image photo, in DateTime dateCreation)
        {
            FamilyName = familyName;
            FirstName = firstName;
            SecondName = secondName;
            Temperature = temperature;
            Photo = photo;
            DateCreation = dateCreation;
        }

        /// <summary>
        /// Метод для сравнения экземпляров Profile
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int ComparisonProfileDateCreation(Profile first, Profile second) => 
            DateTime.Compare(first.DateCreation, second.DateCreation);

        /// <summary>
        /// Получаем цвета для Profile в зависимости от пороговой величины температуры.
        /// Первое значение для цвета рамки, второе для фона
        /// </summary>
        /// <returns></returns>
        public (Color, Color) GetColor()
        {
            if (Temperature < Config.TemperatureThreshold)
                return (Color.FromArgb(3, 102, 102), Color.FromArgb(153, 226, 180));
            else
                return (Color.FromArgb(255, 10, 84), Color.FromArgb(249, 190, 199));
        }

        /// <summary>
        /// Получаем полное имя
        /// </summary>
        /// <returns></returns>
        public string GetFullNameStr() => FamilyName + " " + FirstName + " " + SecondName;
    }
}
