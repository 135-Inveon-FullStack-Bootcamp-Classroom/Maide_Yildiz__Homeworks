﻿namespace IMDB_Clone.Entities
{
    public interface ICrew
    {
        public int CrewID { get; set; }
        public string CrewName { get; set; }
        public string CrewSurname { get; set; }
        public int CrewAge { get; set; }
        public string CrewBio { get; set; }
    }
}
