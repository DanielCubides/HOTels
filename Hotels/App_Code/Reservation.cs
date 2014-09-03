using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Reservation
/// </summary>
public class Reservation
{
	private DateTime StartDate;
    private DateTime EndDate;
    private Room room;
    private Client client;

    public Reservation(DateTime StartDate, DateTime EndDate, Room room, Client client)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.room = room;
        this.client = client;
    }

    public DateTime getStartDate()
    {
        return StartDate;
    }

    public void setStartDate(DateTime StartDate)
    {
        this.StartDate = StartDate;
    }

    public DateTime getEndDate()
    {
        return EndDate;
    }

    public void setEndDate(DateTime EndDate)
    {
        this.EndDate = EndDate;
    }

    public Room getRoom()
    {
        return room;
    }

    public void setRoom(Room room)
    {
        this.room = room;
    }

    public Client getClient()
    {
        return client;
    }

    public void setClient(Client client)
    {
        this.client = client;
    }
}