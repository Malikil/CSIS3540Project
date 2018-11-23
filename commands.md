# Commands list for client-server communication  
Client will send a message, then wait for a response from the server. Server will wait for a message, then send an appropriate response.  
No other messages will be initiated by the server, the client can expect to always receive one, and only one, message in response to every one it sends.

All messages will have several segments, separated by semi-colons (`;`). The first word will be all caps, and determines the main goal of the message. The last segment of a message will always be `END`, even if messages don't have other information in the body.  
A special exception exists for logging in, as that message is only sent once as the first message sent either way. `END` is not required for login.

Whitespace next to semicolons should be ignored, and can optionally be included to help readability of commands in-code. Whitespace can include newlines, so when reading information make sure to keep reading until `END` is found.  
If the first segment of a message is empty, that signals the end of the connection. Even if `END` would otherwise be received later.

## Client
### Logging in
Send login type
* `LOGIN` for logging in with an existing account. Use the format `LOGIN;<username>;<password>`
* `REGISTER` for creating a new account, student id is required. Use the format `REGISTER;<username>;<password>;<studentid>`
### Admin messages
#### ADD
For adding items directly to tables. Used for students, rooms, and floors/buildings if we get that far.  
Second word will be the type of item being added, either `Student` or `Room`.  
Remaining words are filled with information to be added to table, split by semicolons, they must be in the same order as the column listing on the ERD, completely leaving out the PK id field for that table.  
e.g `ADD;Student;Jeremy;Smith`

#### REMOVE
e.g `REMOVE;Student;10`

## Server response messages
### Logging in
Respond with account type
* `FAIL` Username/Password incorrect or account not created
* `ADMIN` Admin login successful
* `STUDENT` Atudent login successful or account created successful

### Admin responses
When sending a table: `KEYWORD;tableschema.xsd;tablecontents.xml;END`
#### ROOMS
When the admin requests a list of rooms, the server will need to send the table. I'm thinking just the table, could be in xml format for clarity, or we could make some sort of compression algorithm in an attempt to keep the streams from working too hard.
