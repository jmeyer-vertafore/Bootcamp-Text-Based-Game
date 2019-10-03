# Bootcamp-Text-Based-Game
If you'd like a working version of the game, please unzip the TextBasedGame - For Behavior Example.zip for reference.

# Your tasks:

1. Room.cs
	- Add all room properties necessary for the game to compile
	
2. RoomHandler.cs
	- Implement the EnterRoom method to:
		- Print description of room
		- Ask for and handle player input
		- Repeat until keyword to enter a new room is received (return the new room)
		
	- Implement FindAnyMatchingRoomsByKeyWord to:
		- Split the user input into a list of words
		- Iterate on the list and compare to the room exit keywords
		- If match return the room corresponding to the exit keyword match
		- Otherwise return null if no match
		
	- Implement GetAllRoomItemKeywords to:
		- Check if the current room has InventoryItems
		- If so, iterate over these items and add them to the keywords list
		- Check if the current room has WeaponItems
		- If so, iterate over these items and add them to the keywords list
		
3. GameRooms.cs
	- Add at least one new room object with unique properties
	
4. RoomKeywords.cs
	- Add keywords to YourBedroom so that you can return to the bedroom from the new room
	- Add keywords for their new room as a new list so they can get into the new room from the bedroom
	
5. IRoomCreator.cs
	- Declare a getter for their new room
	
6. RoomCreator.cs
	- Declare a public getter for their new room
	- Add new room to the constructor
	- Add bedroom and new room as exits for one another in AddExitsToAllRooms
    
 
