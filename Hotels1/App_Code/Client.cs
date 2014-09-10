using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for Client
/// </summary>
public class Client : User
{
    private LinkedList<String> reservations;
    public Client(String name, String lastName, int id, String password) : base(name,lastName, id,password)
    {
        reservations = new LinkedList<String>();
    }
}
