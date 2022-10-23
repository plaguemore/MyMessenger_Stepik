using System;
using Newtonsoft.Json;

namespace MyMessenger_Stepik
{
  class Program
  {
    private static int MessageID;
    private static string UserName;
    private static MessangerClientAPI API = new MessangerClientAPI();

    private static void GetNewMessages()
    {
      Message msg = API.GetMessage(MessageID);
      while (msg != null)
      {
        Console.WriteLine(msg);
        MessageID++;
        msg = API.GetMessage(MessageID);
      }
    }
    static void Main(string[] args)
    {
      //Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
      //string output = JsonConvert.SerializeObject(msg);
      //Console.WriteLine(output);
      //Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
      //Console.WriteLine(deserializedMsg);
      //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-10-23T12:37:36.0265865Z"}
      //RusAl < 23.10.2022 12:37:36 >: Privet
      MessageID = 1;
      Console.WriteLine("Введите Ваше имя:");
      //UserName = "RusAl";
      UserName = Console.ReadLine();
      string MessageText = "";
      while (MessageText != "exit")
      {
        GetNewMessages();
        MessageText = Console.ReadLine();
        if (MessageText.Length > 1)
        {
          Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
          API.SendMessage(Sendmsg);
        }
      }
    }
  }
}
