using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace Hotels
{
    /// <summary>
    /// Summary description for Soap
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class Soap : System.Web.Services.WebService
    {

        DBContext dc = new DBContext();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public string getRoom(String id)
        {
            Habitacion room = dc.Habitacions.Find(int.Parse(id));
            return room.Price.ToString();
        }
    }
}
