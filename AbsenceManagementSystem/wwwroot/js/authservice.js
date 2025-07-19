export async function login(username, password) {
    debugger;
    const response = await fetch('https://localhost:7077/api/login/login', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ username, password })
    });

    if (!response.ok) {
        throw new Error('Invalid credentials');
    }

    const data = await response.json();
    return data.token;
}
