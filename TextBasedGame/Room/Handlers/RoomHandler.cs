using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using Colorful;
using TextBasedGame.Character.Handlers;
using TextBasedGame.Shared.Constants;
using TextBasedGame.Shared.Utilities;

namespace TextBasedGame.Room.Handlers
{
    public class RoomHandler
    {
        // This is the logic for prompting the user for input continuously
        // until the user enters keywords to get to another room.
        // (Calls into a separate method to act on the input)
        public static Models.Room EnterRoom(Character.Models.Character player, Models.Room room)
        {
            Models.Room nextRoom = null;

            // Implement this while loop such that:
            //      1. It runs forever until the user enters a room keyword (one from a room connected to current room - RoomKeywords.cs)
            //      2. Prints the current room description to the console every time the loop runs
            //      3. Ask for user input, and calls PlayerActionHandler.HandlePlayerInput to handle the input
            //          - Note that the PlayerActionHandler returns null, unless the input matches a room keyword (then it returns the next room)
            //      4. If the PlayerActionHandler returns null, the loop iterates again. Otherwise, returns the next room
            while (nextRoom == null)
            {
                // Print out the current Room's Room.InitialRoomDescription to the console if Room.RoomEntered is false,
                // Otherwise print Room.GenericRoomDescription to the console
                // E.C.: Use TypingAnimation.Animate to print to console

                // Now write to the console the ConsoleStrings.PlayerInputPrompt to ask the user for input

                // Call ReadLine to get the input from the user; store this in a variable

                //Set nextRoom to the return value of PlayerActionHandler.HandlePlayerInput (otherwise we loop forever!)
            }

            return nextRoom;
        }

        // Returns a Room that matches the players input keyword
        public static Models.Room FindAnyMatchingRoomByKeywords(string inputSubstring, Models.Room currentRoom)
        {
            // Implement this helper method such that:
            //      1. Returns null if inputString is null or empty
            //      2. Split the inputSubstring into a list of words using ConsoleStrings.StringDelimiters
            //      3. Loop on each of those words:
            //              - Check each possible exit of the currentRoom for a match between the word and KeywordsToEnter
            //      4. If it matches, return the currentRoom.AvailableExits.<Direction>
            //      5. Otherwise, return null

            return null;
        }

        // Returns an item in a room matching by the users input keyword
        public static List<string> GetAllRoomItemKeywords(Models.Room currentRoom)
        {
            var keywords = new List<string>();

            // Implement this helper method such that:
            //      1. Check if the currentRoom has InventoryItems
            //              - Loop on all items, add KeywordsForPickup that are not null or empty to the keywords variable
            //      2. Check if the currentRoom has WeaponItems
            //              - Loop on all weapons, add KeywordsForPickup that are not null or empty to the keywords variable
            //      3. Return the keywords list

            return keywords;
        }
    }
}