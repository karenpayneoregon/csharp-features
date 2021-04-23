namespace SwitchExpressionStackOverflow
{
    public class Operations
    {
        public static int SetIdSecteur(ProjectItem sender) => sender.IdPlateforme switch
        {
            1 when sender.IdSecteur == 1 => 1,
            1 when sender.IdSecteur == 2 => 2,
            1 when sender.IdSecteur == 4 => 3,
            3 when sender.IdSecteur == 1 => 4,
            3 when sender.IdSecteur == 2 => 5,
            3 when sender.IdSecteur == 4 => 6,
            2 when sender.IdSecteur == 1 => 7,
            2 when sender.IdSecteur == 2 => 8,
            2 when sender.IdSecteur == 4 => 9,
            _ => sender.IdPlateformeSecteur
        };
    }
}