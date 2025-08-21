export function greet(namePassedIn) {

	if (!namePassedIn) {
		throw new Error('Invalid input');
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