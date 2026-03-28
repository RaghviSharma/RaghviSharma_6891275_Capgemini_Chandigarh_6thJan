// Authentication utilities
class AuthManager {
    static setToken(token) {
        localStorage.setItem('token', token);
    }

    static getToken() {
        return localStorage.getItem('token');
    }

    static setUser(user) {
        localStorage.setItem('user', JSON.stringify(user));
    }

    static getUser() {
        const user = localStorage.getItem('user');
        return user ? JSON.parse(user) : null;
    }

    static isAuthenticated() {
        return !!this.getToken();
    }

    static logout() {
        localStorage.removeItem('token');
        localStorage.removeItem('user');
    }
}

// Update UI based on authentication state
function updateAuthUI() {
    const isAuthenticated = AuthManager.isAuthenticated();
    const authNav = document.getElementById('authNav');
    const logoutNav = document.getElementById('logoutNav');
    const userInfoNav = document.getElementById('userInfoNav');
    const userEmail = document.getElementById('userEmail');

    if (isAuthenticated) {
        const user = AuthManager.getUser();
        if (authNav) authNav.style.display = 'none';
        if (logoutNav) logoutNav.style.display = 'block';
        if (userInfoNav) {
            userInfoNav.style.display = 'block';
            if (userEmail) userEmail.textContent = `Welcome, ${user?.fullName || user?.email}`;
        }
    } else {
        if (authNav) authNav.style.display = 'block';
        if (logoutNav) logoutNav.style.display = 'none';
        if (userInfoNav) userInfoNav.style.display = 'none';
    }
}

// Logout function
function logout() {
    AuthManager.logout();
    window.location.href = '/Auth/Login';
}

// Initialize auth UI on page load
document.addEventListener('DOMContentLoaded', updateAuthUI);
