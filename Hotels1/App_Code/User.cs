using System;
using System.Collections.Generic;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for Class1
/// </summary>
public class User
{
    private String name;
    private String lastName;
    private int id;
    private String password;
    private char genere;
    private MailAddress email;
    private String phoneNumber;
    private DateTime brithday;

    public User(String name, String lastName, int id, String password)
    {
        this.name = name;
        this.lastName = lastName;
        this.id = id;
        this.password = password;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public String getLastName()
    {
        return lastName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public String getPassword()
    {
        return password;
    }

    public void setPassword(String password)
    {
        this.password = password;
    }


}
