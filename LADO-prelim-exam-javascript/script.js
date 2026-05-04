function formatNumber(n) {
	if (Number.isNaN(n)) return 'NaN';
	return +n.toString();
}

function compute(num1, num2, op) {
	switch (op) {
		case '+':
		case 'add':
		case 'addition':
			return num1 + num2;
		case '-':
		case 'subtract':
		case 'subtraction':
			return num1 - num2;
		case '*':
		case 'x':
		case 'multiply':
		case 'multiplication':
			return num1 * num2;
		case '/':
		case 'divide':
		case 'division':
			if (num2 === 0) return Infinity;
			return num1 / num2;
		default:
			return NaN;
	}
}

function appendHistory(num1, num2, op, result) {
	const history = document.getElementById('history');
	const div = document.createElement('div');
	div.className = 'entry';
	div.textContent = `${num1} ${op} ${num2} = ${result}`;
	history.prepend(div);
}

function startCalculator() {
	while (true) {
		const n1Raw = prompt('Enter the first number (num1):');
		if (n1Raw === null) break;
		const num1 = parseFloat(n1Raw);

		const n2Raw = prompt('Enter the second number (num2):');
		if (n2Raw === null) break;
		const num2 = parseFloat(n2Raw);

		let opRaw = prompt('Choose operation: +, -, *, / ');
		if (opRaw === null) break;
		opRaw = opRaw.trim().toLowerCase();

		if (Number.isNaN(num1) || Number.isNaN(num2)) {
			alert('One or both inputs were not valid numbers. Please try again.');
			const tryAgain = confirm('Do another calculation?');
			if (!tryAgain) break;
			else continue;
		}

		const result = compute(num1, num2, opRaw);

		let displayResult;
		if (result === Infinity) displayResult = 'Error: Division by zero';
		else if (Number.isNaN(result)) displayResult = 'Invalid operation';
		else displayResult = result;

		alert(`Result: ${displayResult}`);
		appendHistory(num1, num2, opRaw, displayResult);

		const again = confirm('Do another calculation? (OK = yes, Cancel = done)');
		if (!again) break;
	}
}

document.getElementById('startBtn').addEventListener('click', startCalculator);

