using Microsoft.Azure.Mobile.Server;

namespace SpartaHackVService.DataObjects
{

    public class User : EntityData
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}