using System;
using System.Diagnostics;
using CreateDynamicControls.Classes.Containers;

namespace CreateDynamicControls.Classes.Extensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Iterate T, present property names, values and type.
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="sender">Instance of T</param>        
        public static void IterateClassProperties<T>(this T sender)
        {
            foreach (var propertyInfo in sender.GetType().GetProperties())
            {
                Debug.WriteLine(propertyInfo.PropertyType == typeof(DateTime?)
                    ? $"{propertyInfo.Name.FirstPart(),10}: {((DateTime) propertyInfo.GetValue(sender, null)):d} {propertyInfo.PropertyType}"
                    : $"{propertyInfo.Name.FirstPart(),10}: {propertyInfo.GetValue(sender, null)} {propertyInfo.PropertyType}");
            }
        }
        public static void EmployeeProperties<T>(this T sender) where T: Employee
        {
            foreach (var propertyInfo in sender.GetType().GetProperties())
            {
                Debug.WriteLine(propertyInfo.PropertyType == typeof(DateTime?)
                    ? $"{propertyInfo.Name.FirstPart(),10}: {((DateTime)propertyInfo.GetValue(sender, null)):d} {propertyInfo.PropertyType}"
                    : $"{propertyInfo.Name.FirstPart(),10}: {propertyInfo.GetValue(sender, null)} {propertyInfo.PropertyType}");
            }
        }
    }
}