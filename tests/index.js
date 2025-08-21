export function greet(namePassedIn, secondName) {

	if (!namePassedIn) {
		throw new Error('Invalid input');
	}

	if (secondName) {
		return 'Welcome to SALT, ' + namePassedIn + ' and ' + secondName;
	}

	return 'Welcome to SALT, ' + namePassedIn;
}

const greeting = greet('Marcus');
if (greeting === 'Welcome to SALT, Marcus') {
	console.log('IT WORKS');
}
else {
	console.log('IT FAILS');
}