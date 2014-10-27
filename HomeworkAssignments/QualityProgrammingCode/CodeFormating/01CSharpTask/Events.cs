// <copyright file="events.cs" company="BlahBlah">
// Copyright BlahBlah. All rights reserved.
// </copyright>
using System;
using System.Text;
using EventNS;
using Wintellect.PowerCollections;

// Nested classes are used in C#... for reference visit MSDN
// Basically I've reformated the code. I haven't changed code logic at all, just added some fields and changed 1 or 2 variable names, as it was
// absolutely necessary. If you say that using should be inside the namespace, better give me a damn good reason... The only reason for it,
// does not apply in this case...

/// <summary>
///  Documentation header
/// </summary>
public class Program
{
    /// <summary>
    ///  Documentation header
    /// </summary>
    private static EventHolder events = new EventHolder();

    /// <summary>
    ///  Documentation header
    /// </summary>
    private static StringBuilder output = new StringBuilder();

    /// <summary>
    /// Documentation header
    /// </summary>
    /// <param name="args">Dummy text</param>
    public static void Main(string[] args)
    {
        while (ExecuteNextCommand())
        {
        }

        Console.WriteLine(output);
    }

    /// <summary>
    /// Documentation header
    /// </summary>
    /// <returns>Dummy text</returns>
    private static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();

        if (command[0] == 'A')
        {
            AddEvent(command);
            return true;
        }

        if (command[0] == 'D')
        {
            DeleteEvents(command);
            return true;
        }

        if (command[0] == 'L')
        {
            ListEvents(command);
            return true;
        }

        if (command[0] == 'E')
        {
            return false;
        }

        return false;
    }

    /// <summary>
    /// Documentation header
    /// </summary>
    /// <param name="command">Dummy text</param>
    private static void ListEvents(string command)
    {
        int pipeIndex = command.IndexOf('|');
        DateTime date = GetDate(command, "ListEvents");
        string countString = command.Substring(pipeIndex + 1);
        int count = int.Parse(countString);
        events.ListEvents(date, count);
    }

    /// <summary>
    /// Documentation header
    /// </summary>
    /// <param name="command">Dummy text</param>
    private static void DeleteEvents(string command)
    {
        string title = command.Substring("DeleteEvents".Length + 1);
        events.DeleteEvents(title);
    }

    /// <summary>
    /// Documentation header
    /// </summary>
    /// <param name="command">Dummy text</param>
    private static void AddEvent(string command)
    {
        DateTime date;
        string title;
        string location;
        GetParameters(command, "AddEvent", out date, out title, out location);
        events.AddEvent(date, title, location);
    }

    /// <summary>
    /// Documentation header
    /// </summary>
    /// <param name="commandForExecution">Dummy text</param>
    /// <param name="commandType">Dummy text1</param>
    /// <param name="dateAndTime">Dummy text2</param>
    /// <param name="eventTitle">Dummy text3</param>
    /// <param name="eventLocation">Dummy text4</param>
    private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
    {
        dateAndTime = GetDate(commandForExecution, commandType);
        int firstPipeIndex = commandForExecution.IndexOf('|');
        int lastPipeIndex = commandForExecution.LastIndexOf('|');

        if (firstPipeIndex == lastPipeIndex)
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
            eventLocation = string.Empty;
        }
        else
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
            eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
        }
    }

    /// <summary>
    /// Documentation header
    /// </summary>
    /// <param name="command">Dummy text</param>
    /// <param name="commandType">Dummy text1</param>
    /// <returns>Dummy text2</returns>
    private static DateTime GetDate(string command, string commandType)
    {
        DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 19));

        return date;
    }

    /// <summary>
    ///  Documentation header
    /// </summary>
    private static class Messages
    {
        /// <summary>
        ///  Documentation header
        /// </summary>
        public static void EventAdded()
        {
            output.Append("Event added\n");
        }

        /// <summary>
        /// Documentation header
        /// </summary>
        /// <param name="x">Dummy text</param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        /// <summary>
        ///  Documentation header
        /// </summary>
        public static void NoEventsFound()
        {
            output.Append("No events found\n");
        }

        /// <summary>
        ///  Documentation header
        /// </summary>
        /// <param name="eventToPrint">Dummy text</param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }

    /// <summary>
    ///  Documentation header
    /// </summary>
    private class EventHolder
    {
        /// <summary>
        ///  Documentation header
        /// </summary>
        private MultiDictionary<string, Event> orderedByTitle = new MultiDictionary<string, Event>(true);

        /// <summary>
        ///  Documentation header
        /// </summary>
        private OrderedBag<Event> orderedByDate = new OrderedBag<Event>();

        /// <summary>
        ///  Documentation header
        /// </summary>
        /// <param name="date">Dummy text</param>
        /// <param name="title">Dummy text1</param>
        /// <param name="location">Dummy text2</param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.orderedByTitle.Add(title.ToLower(), newEvent);
            this.orderedByDate.Add(newEvent);
            Messages.EventAdded();
        }

        /// <summary>
        /// Documentation header
        /// </summary>
        /// <param name="titleToDelete">Dummy text</param>
        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.orderedByTitle[title])
            {
                removed++;
                this.orderedByDate.Remove(eventToRemove);
            }

            this.orderedByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        /// <summary>
        /// Documentation header
        /// </summary>
        /// <param name="date">Dummy text</param>
        /// <param name="count">Dummy text1</param>
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.orderedByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int shown = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (shown == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                shown++;
            }

            if (shown == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}