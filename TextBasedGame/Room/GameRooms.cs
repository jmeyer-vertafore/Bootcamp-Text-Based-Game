using System.Collections.Generic;
using TextBasedGame.Item.Models;
using TextBasedGame.Room.Models;
using Items = TextBasedGame.Item.Models.Items;

namespace TextBasedGame.Room
{
    public class GameRooms
    {
        // This is where all Rooms for the game are defined/instantiated
        // Note: These should only ever be referenced by the RoomCreator

        // This is a room object. Add another room that you want in the game below this one
        public static Models.Room YourBedroom = new Models.Room
        {
            RoomName = "Your Bedroom",
            InitialRoomDescription = "You are standing in your bedroom, next to your bed. \n" +
                                     "There's a faint, early morning light coming in through the blinds of your open window. \n" +
                                     "You can feel the cool autumn air coming in from outside.",
            GenericRoomDescription = "You are standing in your bedroom.",
            AsExitDescription = "Behind you is the doorway into your bedroom.",
            AvailableExits = new RoomExit(),
            RoomItems = new Items
            {
                InventoryItems = new List<InventoryItem>()
                {
                    Program.ItemCreator.RunningShoes
                },
                WeaponItems = new List<WeaponItem>()
                {
                    Program.ItemCreator.BaseballBat
                }
            },
            KeywordsToEnter = Constants.RoomKeywords.YourBedroom
        };
    }
}