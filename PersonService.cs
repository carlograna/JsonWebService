using System;   
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace JsonWebService
{
    public class CustomerService : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }


        public void ProcessRequest(HttpContext context)
        {
            try
            {

                switch(context.Request.HttpMethod)
                {
                    case "POST":
                        ReturnPerson();

                        break;

                    case "GET":
                        ReturnPerson();

                        break;
                }

            }
            catch(Exception ex)
            {
                HttpContext.Current.Response.Write("Invalid web service request" + ex);
            }
        }

        public void ReturnPerson()
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
            HttpContext.Current.Response.Write(js.Serialize(person));
        }

    }
}