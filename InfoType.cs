namespace NetworkContract
{
    public enum InfoType
    {
        // Connection
        Disconnect = 1,
        Connect = 2, 
        PlayerConnect = 3,
        PlayerDisconnect = 4,
        
        // Chat
        ChatMessage = 1000,

        // Gameplay
        MovePlayer = 2000,
    }
}