using System;
using System.Collections.Generic;
using System.Linq;

namespace FileLibrary
{
    /// <summary>
    /// Creates incrementing file name.
    /// </summary>
    public sealed class Incrementer
    {
        private static readonly Lazy<Incrementer> Lazy = new Lazy<Incrementer>(() => new Incrementer());

        public static Incrementer Instance => Lazy.Value;

        private List<int> _baseList = new List<int>();

        /// <summary>
        /// Populate HashSet with random numbers.
        /// HastSet items are unique.
        /// </summary>
        private void CreateList()
        {
            _baseList = new List<int>();

            for (var index = 1; index < 9000; index++)
            {
                _baseList.Add(index);
            }
        }
        /// <summary>
        /// Return a left padded number prefix with REF: 0001
        /// .Any ask if there are any values when called.
        /// </summary>
        /// <returns></returns>
        public string GetReferenceValue()
        {
            if (!_baseList.Any())
            {
                CreateList();
            }

            var number = _baseList.FirstOrDefault();
            _baseList.Remove(number);

            return $" Import{number:D4}.txt";

        }

        /// <summary>
        /// Instantiate List
        /// </summary>
        private Incrementer()
        {
            CreateList();
        }
        /// <summary>
        /// Used to reset at a given time e.g. right before midnight,
        /// perhaps by a scheduled job.
        /// </summary>
        public void Reset()
        {
            CreateList();
        }
    }
}