function fetchLoggedInUser() {
    fetch('/get_logged_in_user')
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            console.log(data); // Wyświetl dane zwrócone przez endpoint (do debugowania)
            if (data.logged_in) {
                document.getElementById('welcomeMessage').textContent = `Witaj, ${data.username || 'UŻYTKOWNIK'}!`;
            } else {
                document.getElementById('welcomeMessage').textContent = 'Witaj, UŻYTKOWNIK!';
            }
        })
        .catch(error => {
            console.error('Błąd podczas pobierania danych o zalogowanym użytkowniku:', error);
            // Dodatkowe informacje do debugowania
            if (error.response) {
                console.log('Response status:', error.response.status);
                console.log('Response text:', error.response.statusText);
            } else {
                console.log('No response from server');
            }
            document.getElementById('welcomeMessage').textContent = 'Witaj, UŻYTKOWNIK!';
        });
}
