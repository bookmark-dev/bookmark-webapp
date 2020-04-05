using System;
using System.Collections.Generic;
using BookMark.RestApi.Abstracts;

namespace BookMark.RestApi.Models {
	public class Event : AModel {
		public long EventID { get; set; }
    public string Name { get; set; }
    public DateTime DateTime { get; set; }
    public string Location { get; set; }
    public string Info { get; set; }
    public bool IsPublic { get; set; }

		public long OrganizationID { get; set; }
        
		#region NAVIGATIONAL PROPERTIES
		public Organization Organization { get; set; }
		public List<UserEvent> UserEvents { get; set; }
		#endregion // NAVIGATIONAL PROPERTIES

		public Event() {
			EventID = DateTime.Now.Ticks;
		}

    public override long GetID() {
			return EventID;
		}
	}
}