using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace JsonWebService
{
    /// <summary>
    /// Summary description for PersonService
    /// </summary>
    [WebService(Namespace = "http://local.childsupport.org/Person")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PersonService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetPerson(string ID)
        {
            Person person = new Person()
            {
                ARP = "AR2CH2GS11111"
                ,
                FirstName = "Carlo"
                ,
                LastName = "Spader"
                ,
                IsActive = true
                ,
                Authenticated = true
            };

            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(person);

        }
    }

    public class Person
    {
        public string ARP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public bool Authenticated { get; set; }
    }
}
