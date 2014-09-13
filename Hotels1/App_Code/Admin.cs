using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
public class Admin : User
{
    private String hotel;
    public Admin(String name, String lastName, int id, String password, String hotel): base(name, lastName, id, password)
    {
        this.hotel = hotel;
    }
}
