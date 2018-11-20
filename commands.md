# Commands list for client-server communication  
Client will send a message, then wait for a response from the server. Server will wait for a message, then send an appropriate response.  
No other messages will be initiated by the server, the client can expect to always receive one, and only one, message in response to every one it sends.

All messages will have several components, separated by semi-colons (`;`). The first word will be all caps, and determines the main goal of the message. For messages with only one word (i.e there is no further information beyond the key word), the word will still be all caps, but no semicolons are required.  
Non-newline whitespace next to semicolons will be ignored, and can optionally be included to help readability of commands in-code. Newlines are reserved for the end of a message, and should not be included anywhere in the middle of a message.

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
#### ROOMS
When the admin requests a list of rooms, the server will need to send the table. I'm thinking just the table, could be in xml format for clarity, or we could make some sort of compression algorithm in an attempt to keep the streams from working too hard.
