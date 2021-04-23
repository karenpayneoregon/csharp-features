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

            projet.IdPlateformeSecteur = projet.IdPlateforme switch
            {
                1 when projet.IdSecteur == 1 => 1,
                1 when projet.IdSecteur == 2 => 2,
                1 when projet.IdSecteur == 4 => 3,
                3 when projet.IdSecteur == 1 => 4,
                3 when projet.IdSecteur == 2 => 5,
                3 when projet.IdSecteur == 4 => 6,
                2 when projet.IdSecteur == 1 => 7,
                2 when projet.IdSecteur == 2 => 8,
                2 when projet.IdSecteur == 4 => 9,
                _ => projet.IdPlateformeSecteur
            };



        }
    }
}
