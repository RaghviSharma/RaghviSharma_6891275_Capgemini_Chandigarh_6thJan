// Register page functionality
document.addEventListener('DOMContentLoaded', function () {
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

    // Reset messages
    document.querySelectorAll('[id$="Error"]').forEach(el => el.textContent = '');
    document.getElementById('registerError').style.display = 'none';
    document.getElementById('registerSuccess').style.display = 'none';

    let isValid = true;

    // Validation
    if (!fullName || fullName.length < 3) {
        document.getElementById('fullNameError').textContent = 'Full name must be at least 3 characters';
        isValid = false;
    }

    if (!email || !validateEmail(email)) {
        document.getElementById('emailError').textContent = 'Enter a valid email';
        isValid = false;
    }

    if (!password || password.length < 6) {
        document.getElementById('passwordError').textContent = 'Password must be at least 6 characters';
        isValid = false;
    }

    if (password !== confirmPassword) {
        document.getElementById('confirmPasswordError').textContent = 'Passwords do not match';
        isValid = false;
    }

    if (!isValid) return;

    try {
        // ✅ FIXED PAYLOAD (IMPORTANT)
        const response = await apiClient.register({
            name: fullName,        // 🔥 changed from fullName → name
            email: email,
            password: password
            // phoneNumber removed unless backend supports it
        });

        console.log("API Response:", response);

        // ✅ FIXED RESPONSE CHECK
        if (!response || !response.token) {
            const errorMsg = response?.message || "Registration failed. Try again.";
            showError(errorMsg);
            return;
        }

        // ✅ Store auth
        AuthManager.setToken(response.token);

        const user = {
            userId: response.userId,
            email: response.email,
            fullName: response.fullName || fullName
        };

        AuthManager.setUser(user);

        // ✅ Success UI
        document.getElementById('registerSuccess').textContent =
            'Registration successful! Redirecting...';
        document.getElementById('registerSuccess').style.display = 'block';

        setTimeout(() => {
            window.location.href = '/';
        }, 2000);

    } catch (error) {
        console.error("Register Error:", error);

        // Better error message
        const errorMsg =
            error.message.includes('fetch')
                ? "Cannot connect to server. Is API running?"
                : error.message;

        showError(errorMsg);
    }
}

// Utility functions
function validateEmail(email) {
    return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email);
}

function showError(message) {
    const errorDiv = document.getElementById('registerError');
    errorDiv.textContent = message;
    errorDiv.style.display = 'block';
}