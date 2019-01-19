using Microsoft.Azure.Mobile.Server;

namespace SpartaHackVService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public string List_ID { get; set; } //list id

        public bool Complete { get; set; }
    }

}