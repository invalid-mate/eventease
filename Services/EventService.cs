using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private List<Event> _events = new();
    private int _nextEventId = 1;
    private int _nextRegistrationId = 1;

    public EventService()
    {
        InitializeSampleData();
    }

    private void InitializeSampleData()
    {
        _events = new List<Event>
        {
            new Event
            {
                Id = _nextEventId++,
                Name = "Tech Conference 2025",
                Date = new DateTime(2025, 11, 15, 9, 0, 0),
                Location = "Convention Center, Vijayawada",
                Description = "Annual technology conference featuring the latest in AI, Cloud, and Web Development",
                Capacity = 500,
                RegisteredCount = 0
            },
            new Event
            {
                Id = _nextEventId++,
                Name = "Blazor Workshop",
                Date = new DateTime(2025, 10, 25, 14, 0, 0),
                Location = "Tech Hub, Hyderabad",
                Description = "Hands-on workshop on building modern web applications with Blazor",
                Capacity = 50,
                RegisteredCount = 0
            },
            new Event
            {
                Id = _nextEventId++,
                Name = "Startup Meetup",
                Date = new DateTime(2025, 11, 5, 18, 0, 0),
                Location = "Innovation Center, Bangalore",
                Description = "Networking event for entrepreneurs and startup enthusiasts",
                Capacity = 150,
                RegisteredCount = 0
            }
        };
    }

    public List<Event> GetAllEvents()
    {
        return _events.OrderBy(e => e.Date).ToList();
    }

    public Event? GetEventById(int id)
    {
        return _events.FirstOrDefault(e => e.Id == id);
    }

    public void AddEvent(Event newEvent)
    {
        newEvent.Id = _nextEventId++;
        _events.Add(newEvent);
    }

    public bool RegisterForEvent(int eventId, Registration registration)
    {
        var eventItem = GetEventById(eventId);
        if (eventItem == null || eventItem.IsFull)
        {
            return false;
        }

        registration.Id = _nextRegistrationId++;
        registration.EventId = eventId;
        eventItem.Registrations.Add(registration);
        eventItem.RegisteredCount++;
        return true;
    }

    public List<Registration> GetEventRegistrations(int eventId)
    {
        var eventItem = GetEventById(eventId);
        return eventItem?.Registrations ?? new List<Registration>();
    }

    public void MarkAttendance(int eventId, int registrationId, bool isAttended)
    {
        var eventItem = GetEventById(eventId);
        var registration = eventItem?.Registrations.FirstOrDefault(r => r.Id == registrationId);
        if (registration != null)
        {
            registration.IsAttended = isAttended;
        }
    }
}
