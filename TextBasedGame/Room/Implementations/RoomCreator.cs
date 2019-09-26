using System.Collections.Generic;
using TextBasedGame.Item.Models;
using TextBasedGame.Room.Interfaces;
using TextBasedGame.Room.Models;
using TextBasedGame.Shared.Models;

namespace TextBasedGame.Room.Implementations
{
    public class RoomCreator : IRoomCreator
    {
        // Declare all getters for any Rooms you will use here
        public Models.Room YourBedroom { get; }
        // Add a getter here for each room that you want to exist in the game

        // Constructor: Add the reference to all the Room Objects here
        public RoomCreator()
        {
            YourBedroom = GameRooms.YourBedroom;
            // Set the getters from above this constructor to the actual GameRoom objects.
            // Hint: refer to the ItemCreator.cs for an example

            AddExitsToAllRooms();
        }

        // Privately used by this class to add the Room references to Room Objects as the Exit Property
        private void AddExitsToAllRooms()
        {
            YourBedroom.AvailableExits = new RoomExit()
            {
                // NorthRoom = YourNextRoom <- (this is the getter from above)
            };
        }
    }
}