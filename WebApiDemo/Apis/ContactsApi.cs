using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WebApiDemo.Resources;

namespace WebApiDemo.Apis
{
    [ServiceContract]
    public class ContactsApi
    {
        [WebGet(UriTemplate="")]
        public IEnumerable<Contact> Get()
        {
            yield return new Contact {ContactId = 1, Name = "Phil Haack"};
            yield return new Contact {ContactId = 2, Name = "HongMei Ge"};
            yield return new Contact {ContactId = 3, Name = "Glenn Block"};
            yield return new Contact {ContactId = 4, Name = "Howard Dierking"};
            yield return new Contact {ContactId = 5, Name = "Jeff Handley"};
            yield return new Contact {ContactId = 6, Name = "Yavor Georgiev"};
        }
    }
}