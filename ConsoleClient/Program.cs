using System;
using Newtonsoft.Json;

namespace MyMessenger_Stepik
{
  class Program
  {
    static void Main(string[] args)
    {
      Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
      string output = JsonConvert.SerializeObject(msg);
      Console.WriteLine(output);
      Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
      Console.WriteLine(deserializedMsg);
      //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-10-23T12:37:36.0265865Z"}
      //RusAl < 23.10.2022 12:37:36 >: Privet
    }
  }
}
