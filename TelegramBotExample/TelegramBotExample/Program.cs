using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramBotExample
{
    public class Program
    {
        public static ITelegramBotClient _botClient;

        private static void Main(string[] args)
        {
            _botClient = new TelegramBotClient("api_token");

            _botClient.OnMessage += Bot_OnMessage;
            _botClient.StartReceiving();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            _botClient.StopReceiving();
        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

                var me = _botClient.GetMeAsync().Result;

                await _botClient.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text: $"Hello, {me.FirstName}"
                );
            }
        }
    }
}
