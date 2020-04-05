namespace SchoolJournal.Models
{
    /// <summary>
    /// Academic year business entity.
    /// </summary>
    public class AcademicYear
    {
        public AcademicYear(int start)
        {
            StartsAt = start;
        }
        
        /// <summary>
        /// Gets start year.
        /// </summary>
        public int StartsAt { get; }

        /// <summary>
        /// Gets end year.
        /// </summary>
        public int EndsAt => StartsAt + 1;

        /// <summary>
        /// Gets string representation of the academic year.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{StartsAt}/{EndsAt}";
        }
    }
}