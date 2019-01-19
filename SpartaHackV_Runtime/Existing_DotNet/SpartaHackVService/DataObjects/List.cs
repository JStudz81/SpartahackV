using Microsoft.Azure.Mobile.Server;

namespace SpartaHackVService.DataObjects
{

    public class List : EntityData
    {
        
        public string date = System.DateTime.Now.ToString("MM-dd-yyyy");

        public string title = System.DateTime.Now.ToString("MM-dd-yyyy");

    }
}