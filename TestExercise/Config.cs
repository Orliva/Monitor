using System;
using System.Drawing;

namespace TestExercise.Configuration
{
    class Config
    {
        public static string ImageSrcPath { get; set; }
        public static float TemperatureThreshold { get; set; }
        public static int MaxCountItem { get; set; }

        public static readonly string logPath;
        public static readonly Color errorBackColor;
        public static readonly Color goodBackColor;

        static Config()
        {
            goodBackColor = Color.Green;
            errorBackColor = Color.Red;
            logPath = Environment.CurrentDirectory + "log.txt";
            ImageSrcPath = string.Empty;
            TemperatureThreshold = 37.0f;
        }
    }
}
