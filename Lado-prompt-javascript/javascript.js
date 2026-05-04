document.addEventListener('DOMContentLoaded', function () {
    const btn = document.getElementById('startBtn');
    btn.addEventListener('click', chooseDestination);
});

function chooseDestination() {
    let valid = false;
    let choice;
    const promptText = 'Where is your future destination to travel?\n\nChoose one by typing the number or country name:\n1) Japan\n2) France\n3) Canada\n4) Australia\n\n(Example answers: 1, Japan, france)';

    do {
        choice = prompt(promptText);
        if (choice === null) {
            alert('No destination chosen. You can click the button again anytime.');
            return;
        }

        const c = choice.trim().toLowerCase();
        let url = '';

        switch (c) {
            case '1':
            case 'japan':
                url = 'https://www.japan.travel/en/';
                valid = true;
                break;
            case '2':
            case 'france':
                url = 'https://www.france.fr/en';
                valid = true;
                break;
            case '3':
            case 'canada':
                url = 'https://www.canada.travel/';
                valid = true;
                break;
            case '4':
            case 'australia':
                url = 'https://www.australia.com/en';
                valid = true;
                break;
            default:
                alert('Invalid choice. Please try again using a number (1-4) or a country name.');
        }

        if (valid) {
            alert('Great choice — redirecting you to resources for ' + (c === '1' || c === 'japan' ? 'Japan' : c === '2' || c === 'france' ? 'France' : c === '3' || c === 'canada' ? 'Canada' : 'Australia') + '.');
            window.location.href = url;
            return;
        }
    } while (!valid);
}

