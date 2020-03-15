using System;
using System.Collections.Generic;

namespace MeetupsApi.Data
{
    public partial class MeetupResponse
    {
        public Meetups Meetup { get; set; }
        public Users Organizer { get; set; }
        public double TempDay {get;set;}
        public double BirrasCount { get; set; }

    }
}
