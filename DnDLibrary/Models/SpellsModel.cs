using System;
using System.Collections.Generic;
using System.Text;

namespace DnDLibrary
{
    public class SpellsModel
    {
        public string _Id { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Higher_Level { get; set; }
        public int Page { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string Material { get; set; }
        public string Ritual { get; set; }
        public string Duration { get; set; }
        public string Concentration { get; set; }
        public string Cating_Time { get; set; }
        public string Level { get; set; }
        public ICollection<SchoolOfMagic> School { get; set; }
        public ICollection<PlayerClasses> Classes { get; set; }
        public ICollection<PlayerSubclasses> Subclasses { get; set; } //There is also a "Name" fir the land. Need to figure that out too.
        public Uri Url { get; set; }
    }

    public class SchoolOfMagic
    {
        public string Name { get; set; }
        public Uri Url { get; set; }
    }

    public class PlayerClasses
    {
        string Name { get; set; }
        public Uri Url { get; set; }
    }

    public class PlayerSubclasses
    {
        string Name { get; set; }
        public Uri Url { get; set; }
    }
}
