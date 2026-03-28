// Register page functionality
document.addEventListener('DOMContentLoaded', function() {
    const registerForm = document.getElementById('registerForm');
    if (registerForm) {
        registerForm.addEventListener('submit', async (e) => {
            e.preventDefault();
            await handleRegister();
        });
    }
});

async function handleRegister() {
    const fullName = document.getElementById('fullName').value.trim();
    const email = document.getElementById('email').value.trim();
    const phoneNumber = document.getElementById('phoneNumber').value.trim();
    const password = document.getElementById('password').value;
    const confirmPassword = document.getElementById('confirmPassword').value;

    // Reset error messages
    const errorElements = document.querySelectorAll('[id$="Error"]');
    errorElements.forEach(el => el.textContent = '');
    document.getElementById('registerError').style.display = 'none';
    document.getElementById('registerSuccess').style.display = 'none';

    // Client-side validation
    let isValid = true;

    if (!fullName) {
        document.getElementById('fullNameError').textContent = 'Full name is required';
        isValid = false;
    } else if (fullName.length < 3) {
        document.getElementById('fullNameError').textContent = 'Full name must be at least 3 characters';
        isValid = false;
    }

    if (!email) {
        document.getElementById('emailError').textContent = 'Email is required';
        isValid = false;
    } else if (!validateEmail(email)) {
        document.getElementById('emailError').textContent = 'Please enter a valid email address';
        isValid = false;
    }

    if (!password) {
        document.getElementById('passwordError').textContent = 'Password is required';
        isValid = false;
    } else if (password.length < 6) {
        document.getElementById('passwordError').textContent = 'Password must be at least 6 characters';
        isValid = false;
    }

    if (password !== confirmPassword) {
        document.getElementById('confirmPasswordError').textContent = 'Passwords do not match';
        isValid = false;
    }

    if (!isValid) return;

    try {
        const response = await apiClient.register({
            fullName,
            email,
            phoneNumber,
            password
        });

        if (!response || !response.success) {
            document.getElementById('registerError').textContent = response?.message || 'Registration failed. Please try again.';
            document.getElementById('registerError').style.display = 'block';
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

        // Show success message and redirect
        document.getElementById('registerSuccess').textContent = 'Registration successful! Redirecting...';
        document.getElementById('registerSuccess').style.display = 'block';

        setTimeout(() => {
            window.location.href = '/';
        }, 2000);
    } catch (error) {
        document.getElementById('registerError').textContent = 'An error occurred. Please try again.';
        document.getElementById('registerError').style.display = 'block';
        console.error('Register error:', error);
    }
}

function validateEmail(email) {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}
