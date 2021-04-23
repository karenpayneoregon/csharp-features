using System.Diagnostics;

namespace SwitchExpressionStackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var projet = new ProjectItem() { IdPlateforme = 1, IdPlateformeSecteur = 2 };
            projet.IdSecteur = Operations.SetIdSecteur(projet);
            
            Debug.WriteLine($"projet.IdPlateformeSecteur = {projet.IdPlateformeSecteur}");

            
            

        }

        static void Demo(string value)
        {
            if (value is { Length: >0})
            {
                
            }
        }
    }
}
