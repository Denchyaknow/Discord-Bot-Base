// See https://aka.ms/new-console-template for more information

namespace Dencho
{
    using DSharpPlus;
    using System.Threading.Tasks;
    using DSharpPlus.CommandsNext;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Msgs.Add("enter", "You Entered the dungeon!");
            //Msgs.Add("l", "You go left");
            //Msgs.Add("r", "You go right");
            //Msgs.Add("am i pretty", "Sure Mang, The Prettiest!");
            //Msgs.Add("how pretty", "Somewhat ish...");
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "MjExNDEyNDM5MjQ0MjEwMTc2.V6WrLQ.k7S2M8ApFrH4Zhi0jV9uiCpx2h0",
                TokenType = TokenType.Bot
            });
            var commands = discord.UseCommandsNext(new CommandsNextConfiguration() 
            {
                StringPrefixes = new[] { "." }
            });
            commands.RegisterCommands<EnterDungeon>();
            //discord.MessageCreated += async (s, e) =>
            //{
            //    if (e.Message.Content.ToLower().StartsWith("."))
            //    {
            //        var user = e.Author.Username;
            //        var msg = e.Message.Content.ToLower().Split('.')[1];
            //        var reply = GetReply(msg);
            //        if(reply != string.Empty)
            //        await e.Message.RespondAsync(@"@"+user+" "+reply);
            //    }

            //};

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        private static string GetReply(string _msg)
        {
            foreach(KeyValuePair<string,string> key in Msgs)
            {
            if(_msg.Contains(key.Key))
                    return key.Value;

            }
            return string.Empty;
        }


        public static IDictionary<string, string> Msgs = new Dictionary<string, string>();
    }
}