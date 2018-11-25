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

### Student Messages
#### Get available rooms
    AVAILABLE
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
When the admin requests a list of rooms, the server will need to send the table. I'm thinking just the table, could be in xml format for clarity, or we could make some sort of compression algorithm in an attempt to keep the streams from working too hard.

### Student responses
#### ROOMS
When given a start date and end date, will send rooms that are available during those dates.

    ROOMS
    [xml of List<DormRoom>]

