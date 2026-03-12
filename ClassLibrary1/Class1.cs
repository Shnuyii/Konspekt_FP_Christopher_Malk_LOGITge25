namespace ClassLibrary1
{
    public class Class1
    {
        public Class1(string messageString)
        {
            MsgForUser = messageString;
        }
        public string MsgForUser { get; set; } = "Helloooooo";

        public void WhatsTheWord()
        {
            Console.WriteLine(MsgForUser);
        }
    }
}
