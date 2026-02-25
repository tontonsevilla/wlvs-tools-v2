namespace WLVSToolsV2.Web.Common.Models.Chats
{
    public class ChatResponse
    {
        public string Reply { get; set; } = "";

        public bool HasReply
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Reply);
            }
        }
    }
}
