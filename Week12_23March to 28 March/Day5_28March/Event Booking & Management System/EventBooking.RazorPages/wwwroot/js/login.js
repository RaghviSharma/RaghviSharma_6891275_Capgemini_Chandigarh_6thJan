// Login page functionality
document.addEventListener('DOMContentLoaded', function() {
    const loginForm = document.getElementById('loginForm');
    if (loginForm) {
        loginForm.addEventListener('submit', async (e) => {
            e.preventDefault();
            await handleLogin();
        });
    }
});

async function handleLogin() {
    const email = document.getElementById('email').value.trim();
    const password = document.getElementById('password').value.trim();
    const loginError = document.getElementById('loginError');
    const emailError = document.getElementById('emailError');
    const passwordError = document.getElementById('passwordError');

    // Reset error messages
    loginError.style.display = 'none';
    emailError.textContent = '';
    passwordError.textContent = '';

    // Client-side validation
    let isValid = true;

    if (!email) {
        emailError.textContent = 'Email is required';
        isValid = false;
    } else if (!validateEmail(email)) {
        emailError.textContent = 'Please enter a valid email address';
        isValid = false;
    }

    if (!password) {
        passwordError.textContent = 'Password is required';
        isValid = false;
    } else if (password.length < 6) {
        passwordError.textContent = 'Password must be at least 6 characters';
        isValid = false;
    }

    if (!isValid) return;

    try {
        const response = await apiClient.login(email, password);

        if (!response || !response.success) {
            loginError.textContent = response?.message || 'Login failed. Please try again.';
            loginError.style.display = 'block';
            return;
        }

        // Store authentication data
        AuthManager.setToken(response.token);
        const user = {
            userId: response.userId,
            email: response.email,
            fullName: response.fullName
        };
        AuthManager.setUser(user);

        // Redirect to events page
        window.location.href = '/';
    } catch (error) {
        loginError.textContent = 'An error occurred. Please try again.';
        loginError.style.display = 'block';
        console.error('Login error:', error);
    }
}

function validateEmail(email) {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}
