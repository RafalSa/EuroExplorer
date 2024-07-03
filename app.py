from flask import Flask, render_template
from flask_socketio import SocketIO, send, emit

app = Flask(__name__)
app.config['SECRET_KEY'] = 'secret!'
socketio = SocketIO(app)

messages = []

@app.route('/')
def chat():
    return render_template('chat.html')

@socketio.on('message')
def handle_message(data):
    username = data['username']
    message = data['message']
    msg_id = len(messages) + 1
    messages.append({'id': msg_id, 'username': username, 'message': message})
    emit('message', {'id': msg_id, 'username': username, 'message': message}, broadcast=True)

@socketio.on('delete_message')
def handle_delete_message(data):
    msg_id = data['id']
    username = data['username']
    global messages
    messages = [msg for msg in messages if not (msg['id'] == msg_id and msg['username'] == username)]
    emit('delete_message', {'id': msg_id}, broadcast=True)

if __name__ == '__main__':
    socketio.run(app, debug=True)
