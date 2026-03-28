// Events page functionality
let allEvents = [];
let filteredEvents = [];
const bookingModal = new bootstrap.Modal(document.getElementById('bookingModal'));

document.addEventListener('DOMContentLoaded', async function() {
    await loadEvents();

    // Search functionality
    const searchInput = document.getElementById('searchInput');
    if (searchInput) {
        searchInput.addEventListener('input', filterEvents);
    }

    // Seats change listener
    const seatsInput = document.getElementById('seatsBooked');
    if (seatsInput) {
        seatsInput.addEventListener('change', updateTotalPrice);
    }
});

async function loadEvents() {
    try {
        // Check if user is authenticated
        if (!AuthManager.isAuthenticated()) {
            // Redirect to login if not authenticated
            window.location.href = '/Auth/Login';
            return;
        }

        showLoadingSpinner(true);
        const events = await apiClient.getEvents();

        if (!events || events.length === 0) {
            showNoEventsMessage(true);
            showLoadingSpinner(false);
            return;
        }

        allEvents = events;
        filteredEvents = [...allEvents];
        renderEvents(filteredEvents);
        showLoadingSpinner(false);
    } catch (error) {
        showErrorMessage('Failed to load events. Please try again.');
        showLoadingSpinner(false);
        console.error('Load events error:', error);
    }
}

function renderEvents(events) {
    const container = document.getElementById('eventsContainer');
    const noEventsMsg = document.getElementById('noEventsMessage');

    if (!events || events.length === 0) {
        container.style.display = 'none';
        noEventsMsg.style.display = 'block';
        return;
    }

    container.innerHTML = '';
    events.forEach(event => {
        const eventCard = createEventCard(event);
        container.appendChild(eventCard);
    });

    container.style.display = 'flex';
    noEventsMsg.style.display = 'none';
}

function createEventCard(event) {
    const col = document.createElement('div');
    col.className = 'col-md-6 col-lg-4 mb-4';

    const remainingSeats = event.availableSeats - event.bookedSeats;
    const isAvailable = remainingSeats > 0;
    const seatStatus = isAvailable ? `${remainingSeats} seats` : 'Sold out';

    col.innerHTML = `
        <div style="border: 1px solid var(--border-color); border-radius: 0.75rem; padding: 1.5rem; height: 100%; display: flex; flex-direction: column; transition: all 0.2s ease;">
            <h5 style="font-weight: 600; margin-bottom: 0.75rem; color: #1f2937;">${escapeHtml(event.title)}</h5>
            
            <p style="color: #6b7280; font-size: 0.95rem; margin-bottom: 1rem; flex-grow: 1;">${escapeHtml(event.description)}</p>
            
            <div style="margin-bottom: 1.5rem;">
                <div style="display: flex; justify-content: space-between; margin-bottom: 0.75rem; font-size: 0.9rem;">
                    <span style="color: #6b7280;">${escapeHtml(event.location)}</span>
                    <span style="color: #6b7280;">${new Date(event.date).toLocaleDateString()}</span>
                </div>
            </div>

            <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 1.5rem;">
                <div style="font-size: 1.5rem; font-weight: 700; color: var(--primary-color);">$${event.price.toFixed(2)}</div>
                <div style="font-size: 0.85rem; color: ${isAvailable ? '#10b981' : '#ef4444'}; font-weight: 500;">${seatStatus}</div>
            </div>

            <button class="btn ${isAvailable ? 'btn-primary' : 'btn-secondary'} w-100" 
                    onclick="openBookingModal(${event.id})"
                    style="padding: 0.625rem; font-size: 0.95rem;" ${!isAvailable ? 'disabled' : ''}>
                ${isAvailable ? 'Book Now' : 'Sold Out'}
            </button>
        </div>
    `;

    return col;
}

function filterEvents() {
    const searchTerm = document.getElementById('searchInput').value.toLowerCase();

    filteredEvents = allEvents.filter(event => {
        return event.title.toLowerCase().includes(searchTerm) ||
               event.description.toLowerCase().includes(searchTerm) ||
               event.location.toLowerCase().includes(searchTerm);
    });

    renderEvents(filteredEvents);
}

function openBookingModal(eventId) {
    const event = allEvents.find(e => e.id === eventId);
    if (!event) return;

    document.getElementById('eventId').value = eventId;
    document.getElementById('eventTitle').textContent = event.title;
    document.getElementById('eventDate').textContent = new Date(event.date).toLocaleDateString();
    document.getElementById('seatPrice').textContent = `$${event.price.toFixed(2)}`;
    document.getElementById('seatsBooked').value = '1';
    document.getElementById('seatsBooked').max = event.availableSeats - event.bookedSeats;
    
    updateTotalPrice();
    bookingModal.show();
}

function updateTotalPrice() {
    const seatPriceText = document.getElementById('seatPrice').textContent.replace('$', '');
    const seatPrice = parseFloat(seatPriceText);
    const seatsBooked = parseInt(document.getElementById('seatsBooked').value) || 0;
    const totalPrice = (seatPrice * seatsBooked).toFixed(2);
    document.getElementById('totalPrice').textContent = `$${totalPrice}`;
}

async function submitBooking() {
    const eventId = parseInt(document.getElementById('eventId').value);
    const seatsBooked = parseInt(document.getElementById('seatsBooked').value);
    const bookingError = document.getElementById('bookingError');
    const seatsError = document.getElementById('seatsError');

    bookingError.style.display = 'none';
    seatsError.style.display = 'none';

    // Validation
    if (!seatsBooked || seatsBooked < 1 || seatsBooked > 100) {
        seatsError.textContent = 'Please enter a valid number of seats (1-100)';
        seatsError.style.display = 'block';
        return;
    }

    try {
        const response = await apiClient.createBooking(eventId, seatsBooked);

        if (!response || !response.id) {
            bookingError.textContent = response?.message || 'Booking failed. Please try again.';
            bookingError.style.display = 'block';
            return;
        }

        // Show success message
        bookingModal.hide();
        showSuccessNotification('Booking confirmed! Check your bookings page for details.');

        // Reload events
        await loadEvents();
    } catch (error) {
        bookingError.textContent = error.message || 'An error occurred. Please try again.';
        bookingError.style.display = 'block';
        console.error('Booking error:', error);
    }
}

function showLoadingSpinner(show) {
    document.getElementById('loadingSpinner').style.display = show ? 'block' : 'none';
}

function showNoEventsMessage(show) {
    document.getElementById('noEventsMessage').style.display = show ? 'block' : 'none';
}

function showErrorMessage(message) {
    const errorDiv = document.getElementById('errorMessage');
    errorDiv.textContent = message;
    errorDiv.style.display = 'block';
}

function showSuccessNotification(message) {
    const alertDiv = document.createElement('div');
    alertDiv.className = 'alert alert-success alert-dismissible fade show';
    alertDiv.innerHTML = `${message}<button type="button" class="btn-close" data-bs-dismiss="alert"></button>`;
    
    const container = document.querySelector('.container');
    container.insertBefore(alertDiv, container.firstChild);

    setTimeout(() => alertDiv.remove(), 5000);
}

function escapeHtml(text) {
    const div = document.createElement('div');
    div.textContent = text;
    return div.innerHTML;
}
