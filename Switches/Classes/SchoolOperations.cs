using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Switches.Data;
using Switches.Models;

namespace Switches.Classes
{
    public class SchoolOperations
    {
        public delegate void OnIteratePersonGrades(PersonGrades personData);
        public static event OnIteratePersonGrades OnIteratePersonGradesEvent;
        
        public static void StudentsForCourse(int courseIdentifier)
        {
            
            using var context = new SchoolContext();

            List<PersonEntity> results = context
                .Person
                .Include(p => p.StudentGrade)
                .Select(Person.Projection).Where(p => p.PersonID < 11 && p.Grades.Count >0)
                .ToList();

            foreach (var personEntity in results)
            {
                var studentGrade = personEntity.Grades.FirstOrDefault(x => x.CourseID == courseIdentifier);
                
                if (studentGrade == null) continue;
                {
                    if (studentGrade.Grade == null) continue;
                    
                    var letterGrade = studentGrade.Grade.Value switch
                    {
                        var x when (x >= 1.00m && x <= 2.00m) => "F",
                        2.50m => "C",
                        3.00m => "B",
                        3.50m => "A",
                        4.00m => "A+",
                        _ => "unknown",
                    };

                    OnIteratePersonGradesEvent?.Invoke(new PersonGrades()
                    {
                        PersonID = personEntity.PersonID, 
                        FirstName = personEntity.FirstName, 
                        LastName = personEntity.LastName, 
                        Grade = studentGrade.Grade, 
                        GradeLetter = letterGrade
                    });
                }

            }
        }
    }
}
