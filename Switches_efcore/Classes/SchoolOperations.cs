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
#nullable enable
    public class SchoolOperations
    {
        public delegate void OnIteratePersonGrades(PersonGrades personData);
        public static event OnIteratePersonGrades? OnIteratePersonGradesEvent;

        /// <summary>
        /// Get students in a course by course identifier, better solution
        /// then in StudentsForCourse as there is only one condition
        /// </summary>
        /// <param name="courseIdentifier"></param>
        public static List<StudentEntity> GradesForPeople(int courseIdentifier = 2021)
        {
            
            using var context = new SchoolContext();
            
            List<StudentEntity> studentEntities = context
                .StudentGrade
                .Include(studentEntity => studentEntity.Student)
                .Select(StudentGrade.Projection)
                .Where(studentEntity => studentEntity.CourseID == courseIdentifier)
                .ToList();

            foreach (var entity in studentEntities)
            {
                var letterGrade = entity.Grade.Value switch
                {
                    >= 1.00m and <= 2.00m => "F",
                    2.50m => "C",
                    3.00m => "B",
                    3.50m => "A",
                    4.00m => "A+",
                    _ => "unknown",
                };

                OnIteratePersonGradesEvent?.Invoke(new PersonGrades()
                {
                    PersonID = entity.PersonID,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Grade = entity.Grade,
                    GradeLetter = letterGrade
                });

            }

            return studentEntities;
            
        }
        /// <summary>
        /// An attempt (see above for better solution) to get students in a specific course. The issue here
        /// is that we are filtering on course type, student identifier and if there are grades.
        /// </summary>
        /// <param name="courseIdentifier"></param>
        public static void StudentsForCourse(int courseIdentifier)
        {
           
            using var context = new SchoolContext();

            List<PersonEntity> results = context
                .Person
                .Include(person => person.StudentGrade)
                .Select(Person.Projection).Where(p => p.PersonID < 11 && p.Grades.Count >0)
                .ToList();

            foreach (var personEntity in results)
            {
                var studentGrade = personEntity.Grades.FirstOrDefault(x => x.CourseID == courseIdentifier);
                
                if (studentGrade == null) continue;
                {
                    if (studentGrade.Grade == null) continue;
                    
                    /*
                     * C# 9
                     */
                    var letterGrade = studentGrade.Grade.Value switch
                    {
                        >= 1.00m and <= 2.00m => "F",
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
