// <copyright file="event.cs" company="BlahBlah">
// Copyright BlahBlah. All rights reserved.
// </copyright>

namespace EventNS
{
    using System;
    using System.Text;

    /// <summary>
    ///  Documentation header
    /// </summary>
    public class Event : IComparable
    {
        /// <summary>
        /// Documentation header
        /// </summary>
        private DateTime date;

        /// <summary>
        /// Documentation header
        /// </summary>
        private string title;

        /// <summary>
        /// Documentation header
        /// </summary>
        private string location;

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="date">Dummy text</param>
        /// <param name="title">Dummy text1</param>
        /// <param name="location">Dummy text2</param>
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets dummy text
        /// </summary>
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        /// <summary>
        /// Gets or sets dummy text
        /// </summary>
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        /// <summary>
        /// Gets or sets dummy text
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        /// <summary>
        /// Documentation header
        /// </summary>
        /// <param name="obj">Dummy text</param>
        /// <returns>Dummy text1</returns>
        public int CompareTo(object obj)
        {
            Event objAsEvent = obj as Event;
            int compareByDate = this.date.CompareTo(objAsEvent.date);
            int comapreByTitle = this.title.CompareTo(objAsEvent.title);
            int comapreByLocation = this.location.CompareTo(objAsEvent.location);

            if (compareByDate == 0)
            {
                if (comapreByTitle == 0)
                {
                    return comapreByLocation;
                }
                else
                {
                    return comapreByTitle;
                }
            }
            else
            {
                return compareByDate;
            }
        }

        /// <summary>
        /// Documentation header
        /// </summary>
        /// <returns>Dummy text</returns>
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
