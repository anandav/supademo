using Supabase.Gotrue;
using Supabase.Gotrue.Interfaces;
using System.Threading.Tasks;
using static Supabase.Gotrue.Constants;
namespace superbase.demo
{
    public class SupabaseDemo
    {
        public SupabaseDemo()
        {
        }

        public  async Task  StartSignIn()
        {
            Console.WriteLine("Start Sign In called.");
            Client client = new Client(new ClientOptions { AllowUnconfirmedUserSessions = true });
            var status = new NetworkStatus();
            status.Client = client;
            await status.StartAsync("");
            var signInUrl = client.SignIn(Provider.Github);
            Console.WriteLine(signInUrl);

        }

    }
}
