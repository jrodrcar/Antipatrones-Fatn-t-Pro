using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antipatrones
{
    internal class Program
    {
        public class MonolithicProgressCalculator
        {
            // Método para calcular el progreso del usuario
            public double CalculateProgress(int userId)
            {
                // Aquí se realizaría el cálculo del progreso basado en las actividades del usuario
                // Supongamos que se realizan diversas operaciones complejas aquí

                // Operaciones de base de datos para recuperar actividades del usuario (ejemplo simplificado)
                List<Activity> userActivities = Database.GetActivitiesForUser(userId);

                // Realizar cálculos basados en las actividades del usuario
                double progress = 0;
                foreach (var activity in userActivities)
                {
                    progress += activity.Duration * activity.Intensity; // Cálculo simplificado
                }

                return progress;
            }

            // Método para guardar el progreso del usuario en la base de datos
            public void SaveProgressToDatabase(int userId, double progress)
            {
                // Aquí se realizarían operaciones de base de datos para guardar el progreso del usuario
                // Supongamos que se realizan diversas operaciones de inserción y actualización aquí
            }
        }

        public class Activity
        {
            public int Duration { get; set; }
            public int Intensity { get; set; }
        }

        public class Database
        {
            public static List<Activity> GetActivitiesForUser(int userId)
            {
                // Simulación de recuperación de actividades del usuario desde la base de datos
                return new List<Activity>
        {
            new Activity { Duration = 30, Intensity = 5 },
            new Activity { Duration = 45, Intensity = 7 },
            // Otras actividades...
        };
            }
        }

        public class Programa
        {
            public static void Main(string[] args)
            {
                MonolithicProgressCalculator progressCalculator = new MonolithicProgressCalculator();
                int userId = 123; // Supongamos que el ID del usuario es 123

                // Calcular el progreso del usuario
                double progress = progressCalculator.CalculateProgress(userId);

                // Imprimir el progreso del usuario en la consola
                Console.WriteLine("El progreso del usuario con ID {0} es: {1}", userId, progress);
                Console.ReadLine();
            }
        }

    }
}
