import json
from flask import Flask, request, jsonify

# Ścieżka do pliku JSON z danymi zalogowanego użytkownika
json_file_path = r'C:\Users\rafal\source\repos\projektObiektowe13\bin\Debug\net8.0-windows\Data\loggedInUser.json'
# Ścieżka do pliku JSON z historią wiadomości
messages_file_path = 'messages.json'

# Funkcja do odczytu danych zalogowanego użytkownika
def read_logged_in_user():
    try:
        with open(json_file_path, 'r') as f:
            data = json.load(f)
            print(f'Zawartość wczytana z pliku JSON: {data}')
        if 'Username' in data:
            return data['Username']
        else:
            raise KeyError('Brak klucza "Username" w pliku JSON.')
    except FileNotFoundError:
        print(f'Błąd: Plik JSON "{json_file_path}" nie został znaleziony.')
    except json.JSONDecodeError as e:
        print(f'Błąd dekodowania JSON: {e}')
    except KeyError as e:
        print(f'Błąd odczytu danych z pliku JSON: {e}')
    except Exception as e:
        print(f'Inny błąd: {e}')
    
    return None


# Funkcja do wczytywania historii wiadomości z pliku JSON
def load_messages():
    try:
        with open(messages_file_path, 'r') as f:
            messages = json.load(f)
    except FileNotFoundError:
        messages = []
    return messages

# Funkcja do zapisywania wiadomości do pliku JSON
def save_messages(messages):
    with open(messages_file_path, 'w') as f:
        json.dump(messages, f, indent=4)

# Funkcja do dodawania wiadomości
def add_message(username, message):
    messages = load_messages()
    messages.append({'username': username, 'message': message})
    save_messages(messages)

# Generowanie HTML z dynamiczną nazwą użytkownika
def generate_html(logged_in_username):
    messages = load_messages()
    
    # Generowanie listy wiadomości
    messages_html = ""
    for msg in messages:
        messages_html += f"<li>{msg['username']}: {msg['message']}</li>"
    
    html_content = f"""
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Wiadomości</title>
    </head>
    <body>
        <h2>Witaj, {logged_in_username}!</h2>
        <div>
            <h3>Wiadomości:</h3>
            <ul id="messages">
                {messages_html}
            </ul>
        </div>
        <div>
            <input type="text" id="messageInput" placeholder="Wpisz wiadomość...">
            <button onclick="sendMessage()">Wyślij wiadomość</button>
        </div>
        
        <script>
            function sendMessage() {{
                var message = document.getElementById("messageInput").value;
                var messageList = document.getElementById("messages");
                var li = document.createElement("li");
                li.textContent = "{logged_in_username}: " + message;
                messageList.appendChild(li);
                
                // Wysyłanie wiadomości do serwera
                fetch('/send_message', {{
                    method: 'POST',
                    headers: {{
                        'Content-Type': 'application/json',
                    }},
                    body: JSON.stringify({{
                        username: "{logged_in_username}",
                        message: message
                    }})
                }});
                
                // Czyszczenie pola tekstowego
                document.getElementById("messageInput").value = "";
            }}
        </script>
    </body>
    </html>
    """
    return html_content

# Inicjalizacja aplikacji Flask
app = Flask(__name__)

# Obsługa żądania GET na główną stronę
@app.route('/')
def index():
    logged_in_username = read_logged_in_user()
    if logged_in_username:
        return generate_html(logged_in_username)
    else:
        return "Nie można wczytać nazwy zalogowanego użytkownika."
    
    # Endpoint do pobierania danych zalogowanego użytkownika
@app.route('/get_logged_in_user', methods=['GET'])
def get_logged_in_user():
    logged_in_username = read_logged_in_user()
    if logged_in_username:
        return jsonify({'logged_in': True, 'username': logged_in_username})
    else:
        return jsonify({'logged_in': False})

# Obsługa żądania POST do dodawania wiadomości
@app.route('/send_message', methods=['POST'])
def send_message():
    try:
        data = request.json
        username = data['username']
        message = data['message']
        
        add_message(username, message)
        
        return jsonify({'status': 'Wiadomość zapisana.'})
    except Exception as e:
        return jsonify({'status': 'Błąd', 'message': str(e)})
    

# Uruchomienie serwera Flask
if __name__ == '__main__':
    app.run(debug=True)
