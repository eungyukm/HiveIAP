
namespace NetProtocol.Packet
{
    public enum WalletType
    {
        NONE = 0,
        RUBY = 2,                      // 루비. 월드내 귀속
        CRON = 4,                     // 크론 (골드). 캐릭터 귀속
        MILEAGE = 5,               // 마일리지. 월드내 귀속
        GUILD_COIN = 9,          // 길드코인. 캐릭터 귀속
        BLOODFOG_POINT = 12,        //블러드포그 포인트
    }
}
