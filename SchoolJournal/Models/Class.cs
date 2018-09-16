using System;
using System.Collections.Generic;


namespace SchoolJournal.Models
{
    public class Class
    {
        private readonly string _name;
        private readonly List<Pupil> _pupils;


        public Class(string name)
        {
            _name = name;
            _pupils = new List<Pupil>();
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public void AddPupil(Pupil pupil)
        {
            _pupils.Add(pupil);
        }


        public IReadOnlyList<Pupil> ListPupils
        {
            get
            {
                return _pupils;
            }
        }

    }

}
