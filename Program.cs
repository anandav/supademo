namespace superbase.demo;

class Program
{
    static void Main(string[] args)
    {
        SupabaseDemo supabaseDemo = new SupabaseDemo();
        supabaseDemo.StartSignIn();
        Console.WriteLine("Hello, World!");
    }

    //    public static MauiApp CreateMauiApp()
    //    {
    //        // ...
    //        var builder = MauiApp.CreateBuilder();
    //
    //        var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
    //        var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");
    //        var options = new SupabaseOptions
    //        {
    //            AutoRefreshToken = true,
    //                             AutoConnectRealtime = true,
    //                             // SessionHandler = new SupabaseSessionHandler() <-- This must be implemented by the developer
    //        };
    //
    //        // Note the creation as a singleton.
    //        builder.Services.AddSingleton(provider => new Supabase.Client(url, key, options));
    //    }
}
