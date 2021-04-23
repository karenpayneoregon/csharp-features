# About

From Stackoverflow [question](https://stackoverflow.com/questions/67231144/c-sharp-convert-sql-query-with-case-statement-to-linq), how to translate the following `SQL` to `LINQ`, well there is no LINQ for this.

See my [TechNet article](https://social.technet.microsoft.com/wiki/contents/articles/54200.switch-statement-c.aspx) for more...

Couple of thoughts on which one to use. It depends on how often code needs to be maintained and edited along with if in a team or not, will the method used be understood days, months etc. down the road. Also do not use a switch expression just to use them, use them because it makes sense.

```sql
UPDATE depotProjet.Projets
        SET IdPlateformeSecteur =
            CASE
                WHEN (IdPlateforme = 1 AND IdSecteur = 1) then 1
                WHEN (IdPlateforme = 1 AND IdSecteur = 2) then 2
                WHEN (IdPlateforme = 1 AND IdSecteur = 4) then 3
                WHEN (IdPlateforme = 3 AND IdSecteur = 1) then 4
                WHEN (IdPlateforme = 3 AND IdSecteur = 2) then 5
                WHEN (IdPlateforme = 3 AND IdSecteur = 4) then 6
                WHEN (IdPlateforme = 2 AND IdSecteur = 1) then 7
                WHEN (IdPlateforme = 2 AND IdSecteur = 2) then 8
                WHEN (IdPlateforme = 2 AND IdSecteur = 4) then 9
            
            End
        
        WHERE IdPlateformeSecteur is NULL;  
```

There solution, an if staement which is perfectly fine.

```csharp
if (projet.IdPlateforme == 1 && projet.IdSecteur == 1)
{
    projet.IdPlateformeSecteur = 1;
}
else if (projet.IdPlateforme == 1 && projet.IdSecteur == 2)
{
    projet.IdPlateformeSecteur = 2;
}
else if (projet.IdPlateforme == 1 && projet.IdSecteur == 4)
{
    projet.IdPlateformeSecteur = 3;
}
else if (projet.IdPlateforme == 3 && projet.IdSecteur == 1)
{
    projet.IdPlateformeSecteur = 4;
}
else if (projet.IdPlateforme == 3 && projet.IdSecteur == 2)
{
    projet.IdPlateformeSecteur = 5;
}
else if (projet.IdPlateforme == 3 && projet.IdSecteur == 4)
{
    projet.IdPlateformeSecteur = 6;
}
else if (projet.IdPlateforme == 2 && projet.IdSecteur == 1)
{
    projet.IdPlateformeSecteur = 7;
}
else if (projet.IdPlateforme == 2 && projet.IdSecteur == 2)
{
    projet.IdPlateformeSecteur = 8;
}
else if (projet.IdPlateforme == 2 && projet.IdSecteur == 4)
{
    projet.IdPlateformeSecteur = 9;
}
```

**Option 1**, use a switch statement, still easy to work with

```csharp
switch (projet.IdPlateforme)
{
    case 1 when projet.IdSecteur == 1:
        projet.IdPlateformeSecteur = 1;
        break;
    case 1 when projet.IdSecteur == 2:
        projet.IdPlateformeSecteur = 2;
        break;
    case 1 when projet.IdSecteur == 4:
        projet.IdPlateformeSecteur = 3;
        break;
    case 3 when projet.IdSecteur == 1:
        projet.IdPlateformeSecteur = 4;
        break;
    case 3 when projet.IdSecteur == 2:
        projet.IdPlateformeSecteur = 5;
        break;
    case 3 when projet.IdSecteur == 4:
        projet.IdPlateformeSecteur = 6;
        break;
    case 2 when projet.IdSecteur == 1:
        projet.IdPlateformeSecteur = 7;
        break;
    case 2 when projet.IdSecteur == 2:
        projet.IdPlateformeSecteur = 8;
        break;
    case 2 when projet.IdSecteur == 4:
        projet.IdPlateformeSecteur = 9;
        break;
```

**Option 2** use a switch expression

```csharp
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
}
```


**Option 2 a**, place switch expression in a method using an expesson body.

```csharp
namespace SwitchExpression
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
```

**Class definition**

```csharp
namespace SwitchExpression
{
    public class ProjectItem
    {
        public int IdPlateforme { get; set; }
        public int IdSecteur { get; set; }
        public int IdPlateformeSecteur { get; set; }
    }
}
```
</br>

![img](assets/Versions.png)

![imge](assets/kpTraining.png)
