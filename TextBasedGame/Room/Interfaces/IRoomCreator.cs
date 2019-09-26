using System.Collections.Generic;
using TextBasedGame.Item.Models;
using TextBasedGame.Room.Models;
using TextBasedGame.Shared.Models;

namespace TextBasedGame.Room.Interfaces
{
    public interface IRoomCreator
    {
        // Declare all getters for any Rooms you will use here
        Models.Room YourBedroom { get; }
        // Add a getter here for each room that you want to exist in the game
    }
}