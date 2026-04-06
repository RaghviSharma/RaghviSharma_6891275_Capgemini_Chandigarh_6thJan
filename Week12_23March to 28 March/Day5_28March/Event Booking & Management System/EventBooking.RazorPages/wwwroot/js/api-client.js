// API Client configuration
const API_BASE_URL = 'http://localhost:5010';

class ApiClient {
    constructor(baseUrl = API_BASE_URL) {
        this.baseUrl = baseUrl;
    }

    async request(endpoint, options = {}) {
        const url = `${this.baseUrl}${endpoint}`;
        const token = localStorage.getItem('token');

        const headers = {
            'Content-Type': 'application/json',
            ...options.headers
        };

        if (token) {
            headers['Authorization'] = `Bearer ${token}`;
        }

        try {
            const response = await fetch(url, {
                ...options,
                headers,
                credentials: 'include'
            });

            if (response.status === 401) {
                // Token expired or invalid
                localStorage.removeItem('token');
                localStorage.removeItem('user');
                window.location.href = '/Auth/Login';
                return null;
            }

            if (!response.ok) {
                const error = await response.json().catch(() => ({
                    message: `HTTP Error ${response.status}`
                }));
                throw new Error(error.message || `HTTP Error ${response.status}`);
            }

            return await response.json().catch(() => null);
        } catch (error) {
            console.error('API Request Error:', error);
            throw error;
        }
    }

    // Events API
    async getEvents() {
        return this.request('/api/events', { method: 'GET' });
    }

    async getEventById(id) {
        return this.request(`/api/events/${id}`, { method: 'GET' });
    }

    // Bookings API
    async createBooking(eventId, seatsBooked) {
        return this.request('/api/bookings', {
            method: 'POST',
            body: JSON.stringify({ eventId, seatsBooked })
        });
    }

    async getUserBookings() {
        return this.request('/api/bookings/my-bookings', { method: 'GET' });
    }

    async getBookingById(id) {
        return this.request(`/api/bookings/${id}`, { method: 'GET' });
    }

    async cancelBooking(id) {
        return this.request(`/api/bookings/${id}`, { method: 'DELETE' });
    }

    // Auth API
    async register(data) {
        return this.request('/api/auth/register', {
            method: 'POST',
            body: JSON.stringify(data)
        });
    }

    async login(email, password) {
        return this.request('/api/auth/login', {
            method: 'POST',
            body: JSON.stringify({ email, password })
        });
    }

    async getCurrentUser() {
        return this.request('/api/auth/me', { method: 'GET' });
    }
}

// Global API client instance
const apiClient = new ApiClient();
