# Commands list for client-server communication  
Client will send a message, then wait for a response from the server. Server will wait for a message, then send an appropriate response.  
No other messages will be initiated by the server, the client can expect to always receive one, and only one, message in response to every one it sends.

All messages will have two segments, separated by a newline. The first segment is a single word, and determines the main goal of the message. The second segment of the message contains the main message content.

Connections will not be maintained after the message was received and response sent. To send another message, a new connection should be opened.  
Once a message has finished being written to the stream, that stream should be closed to allow for processing.

## Client
### Logging in
Send login type
* `LOGIN` for logging in with an existing account. eg.

        LOGIN
        [username]
        [password]

* `REGISTER` for creating a new account, student id is required. eg.

        REGISTER
        [username]
        [password]
        [studentid]

### Admin messages
#### ADD
For adding items directly to tables. Used for students, rooms, and floors/buildings if we get that far.  
Second word will be the type of item being added, either `Student` or `Room`.  
Message body will contain the information to be added to table in xml format.

        ADD Student
        <student>
            <studentid></studentid>
            <name></name>
        </student>

#### REMOVE
    REMOVE Student
    [studentid]

#### Get all rooms
When an admin wants to get a list of every room, just send the header `ROOMS` with an empty body

### Student Messages
#### Get available rooms
To get a list of rooms that are available from the server during a date range, send the beginning date and end date to the server with the `AVAILABLE` header

    AVAILABLE
    [StartDate]
    [EndDate]

#### Reserve room
When the user has made their selection of room and dates, they need to tell the server they want to reserve it. Use the `RESERVE` header, the room id, and the date range

    RESERVE
    [RoomID]
    [StartDate]
    [EndDate]

## Server response messages
### Logging in
Respond with account type. No message body needs to be sent.
* `FAIL` Username/Password incorrect or account not created
* `ADMIN` Admin login successful
* `STUDENT` Atudent login successful or account created successful

### Admin responses
#### ROOMS
When the admin requests a list of rooms, the server will send an xml of a `List<DormRoom>` with a `ROOMS` header

    ROOMS
    <roomlist>          <-- or whatever the xml serializer does to serialize a list
        <room 1></room 1>
        <room 2></room 2>
    </roomlist>

#### ADD
When adding a room, the server will respond with `SUCCESS` or `FAIL` depending on whether the room was added or not

### Student responses
#### AVAILABLE
When given a start date and end date, will send rooms that are available during those dates.

    ROOMS
    [xml of List<DormRoom>]

#### RESERVE
When the student reserves a room, the server will respond with either `SUCCESS` or `FAIL` for if the room was able to be reserved.