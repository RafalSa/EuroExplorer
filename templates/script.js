function fetchLoggedInUser() {
    fetch('/get_logged_in_user')
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            console.log(data); // Sprawdź, co jest zwracane przez endpoint
            if (data.logged_in) {
                document.getElementById('welcomeMessage').textContent = `Witaj, ${data.username || 'UŻYTKOWNIK'}!`;
            } else {
                document.getElementById('welcomeMessage').textContent = 'Witaj, UŻYTKOWNIK!';
            }
        })
        .catch(error => {
            console.error('Błąd podczas pobierania danych o zalogowanym użytkowniku:', error);
            document.getElementById('welcomeMessage').textContent = 'Witaj, UŻYTKOWNIK!';
        });
}
