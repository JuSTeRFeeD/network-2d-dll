namespace NetworkContract
{
    public enum InfoType
    {
        // Connection
        Disconnect = 1,

        // Chat
        ChatMessage = 1000,

        // Gameplay
        NewPlayerPlayerConnected = 2000,
        MovePlayer = 2100,
    }
}