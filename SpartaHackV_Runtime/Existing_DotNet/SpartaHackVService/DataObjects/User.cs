using Microsoft.Azure.Mobile.Server;

namespace SpartaHackVService.DataObjects
{

    public class User : EntityData
    {
        public string Text { get; set; }
        public bool Complete { get; set; }
    }
}