using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wurzelbot
{
    public static class GlobalVariables
    {
        public static string JsonFilePath { get; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Storage\Data\coordinates.json");
        public static string JsonData { get; } = File.ReadAllText(JsonFilePath);
    }
}
