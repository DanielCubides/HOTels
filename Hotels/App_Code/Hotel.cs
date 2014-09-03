using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hotel
/// </summary>
public class Hotel
{
    private int rate;
    private String address;
    private LinkedList<String> reservations;
    private LinkedList<Client> clients;
    private Admin admin;

    public Hotel(int rate, String address, LinkedList<String> reservations, LinkedList<Client> clients, Admin admin)
    {
        this.rate = rate;
        this.address = address;
        this.reservations = reservations;
        this.clients = clients;
        this.admin = admin;
    }

    public int getRate()
    {
        return rate;
    }

    public void setRate(int rate)
    {
        this.rate = rate;
    }

    public String getAddress()
    {
        return address;
    }

    public void setAddress(String address)
    {
        this.address = address;
    }

    public LinkedList<String> getReservations()
    {
        return reservations;
    }

    public void setReservations(LinkedList<String> reservations)
    {
        this.reservations = reservations;
    }

    public LinkedList<Client> getClients()
    {
        return clients;
    }

    public void setClients(LinkedList<Client> clients)
    {
        this.clients = clients;
    }

    public Admin getAdmin()
    {
        return admin;
    }

    public void setAdmin(Admin admin)
    {
        this.admin = admin;
    }

}