using Microsoft.Azure.Mobile.Server;

namespace SpartaHackVService.DataObjects
{
    public class List : EntityData
    {
        public string title { get; set; }

        public string date { get; set; }

        public List()
        {
            title = System.DateTime.Now.ToShortDateString();
            date = System.DateTime.Now.ToShortDateString();
        }
    }

}