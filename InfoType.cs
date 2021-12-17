namespace NetworkContract
{
    public enum InfoType
    {
        // Connection
        Disconnect = 1,
        NewPlayerConnected = 2,
        
        // Chat
        ChatMessage = 1000,

        // Gameplay
        MovePlayer = 2000,
    }
}