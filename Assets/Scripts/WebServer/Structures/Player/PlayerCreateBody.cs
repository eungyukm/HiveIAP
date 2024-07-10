namespace RM2.Login.Structures.Player
{
    public class PlayerCreateBody
    {
        public byte Slot { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public short ClassId { get; set; } = 0;
        public string Face { get; set; } = string.Empty;
        public string Customize { get; set; } = string.Empty;
        
        public bool IsFirstCreation { get; set; } = false;
        public string AccountName { get; set; } = string.Empty;
    }
}