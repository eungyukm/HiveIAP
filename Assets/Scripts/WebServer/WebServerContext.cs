public static class WebServerContext
{
    public static string Token { get; set; } = "";
    public static string HashedWorldId { get; set; } = "";
    public static int WorldId { get; set; } = 0;

    public static string HashedPlayerId { get; set; } = "";
    public static long PlayerId { get; set; } = 0;
}