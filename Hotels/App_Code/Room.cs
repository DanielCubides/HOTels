using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Room
/// </summary>
public class Room
{
	private int number;
    private String description;
    private LinkedList<String> reservations;
    private double cost;

    public Room(int number, String description, LinkedList<String> reservations, double cost)
    {
        this.number = number;
        this.description = description;
        this.reservations = reservations;
        this.cost = cost;
    }

    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public LinkedList<String> getReservations() {
        return reservations;
    }

    public void setReservations(LinkedList<String> reservations) {
        this.reservations = reservations;
    }

    public double getCost() {
        return cost;
    }

    public void setCost(double cost) {
        this.cost = cost;
    }
    
}