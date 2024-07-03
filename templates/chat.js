var socket = io();

socket.on('message', function (data) {
    var li = document.createElement('li');
    li.id = 'msg-' + data.id;
    li.innerHTML = '<b>' + data.username + ':</b> ' + data.message + ' <button onclick="deleteMessage(' + data.id + ')">Delete</button>';
    document.getElementById('messages').appendChild(li);
});

socket.on('delete_message', function (data) {
    var msgElem = document.getElementById('msg-' + data.id);
    if (msgElem) {
        msgElem.remove();
    }
});

function sendMessage() {
    var username = document.getElementById('username').value;
    var message = document.getElementById('message').value;
    socket.emit('message', { username: username, message: message });
}

function deleteMessage(msgId) {
    var username = document.getElementById('username').value;
    socket.emit('delete_message', { id: msgId, username: username });
}
