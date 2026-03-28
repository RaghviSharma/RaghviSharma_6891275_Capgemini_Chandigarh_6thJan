// My Bookings page functionality
const cancelModal = new bootstrap.Modal(document.getElementById('cancelModal'));

document.addEventListener('DOMContentLoaded', async function() {
    await loadBookings();
});

async function loadBookings() {
    try {
        // Check if user is authenticated
        if (!AuthManager.isAuthenticated()) {
            window.location.href = '/Auth/Login';
            return;
        }

        showLoadingSpinner(true);
        const bookings = await apiClient.getUserBookings();

        if (!bookings || bookings.length === 0) {
            showNoBookingsMessage(true);
            showLoadingSpinner(false);
            return;
        }

        renderBookings(bookings);
        showLoadingSpinner(false);
    } catch (error) {
        showErrorMessage('Failed to load bookings. Please try again.');
        showLoadingSpinner(false);
        console.error('Load bookings error:', error);
    }
}

function renderBookings(bookings) {
    const container = document.getElementById('bookingsContainer');
    const noBookingsMsg = document.getElementById('noBookingsMessage');
    const bookingsList = document.getElementById('bookingsList');

    if (!bookings || bookings.length === 0) {
        container.style.display = 'none';
        noBookingsMsg.style.display = 'block';
        return;
    }

    bookingsList.innerHTML = '';
    bookings.forEach(booking => {
        const row = createBookingRow(booking);
        bookingsList.appendChild(row);
    });

    container.style.display = 'block';
    noBookingsMsg.style.display = 'none';
}

function createBookingRow(booking) {
    const row = document.createElement('tr');
    const eventDate = new Date(booking.event.date).toLocaleDateString();
    const bookedDate = new Date(booking.bookedAt).toLocaleDateString();
    const statusColor = getStatusColor(booking.status);

    row.innerHTML = `
        <td style="padding: 1rem 0.5rem; border-bottom: 1px solid var(--border-color);">
            <div style="font-weight: 600; color: #1f2937;">${escapeHtml(booking.event.title)}</div>
            <div style="font-size: 0.85rem; color: #6b7280;">${escapeHtml(booking.event.location)}</div>
        </td>
        <td style="padding: 1rem 0.5rem; border-bottom: 1px solid var(--border-color); color: #6b7280;">${eventDate}</td>
        <td style="padding: 1rem 0.5rem; border-bottom: 1px solid var(--border-color); color: #6b7280;">${booking.seatsBooked}</td>
        <td style="padding: 1rem 0.5rem; border-bottom: 1px solid var(--border-color); font-weight: 600; color: var(--primary-color);">$${booking.totalPrice.toFixed(2)}</td>
        <td style="padding: 1rem 0.5rem; border-bottom: 1px solid var(--border-color);">
            <span style="display: inline-block; padding: 0.375rem 0.75rem; border-radius: 0.375rem; font-size: 0.85rem; font-weight: 500; background-color: ${statusColor}20; color: ${statusColor};">
                ${booking.status}
            </span>
        </td>
        <td style="padding: 1rem 0.5rem; border-bottom: 1px solid var(--border-color);">
            ${booking.status === 'Confirmed' 
                ? `<button class="btn btn-sm btn-danger" onclick="openCancelModal(${booking.id})" style="padding: 0.375rem 0.75rem; font-size: 0.85rem;">Cancel</button>` 
                : '<span style="color: #d1d5db;">—</span>'}
        </td>
    `;

    return row;
}

function getStatusColor(status) {
    switch (status.toLowerCase()) {
        case 'confirmed':
            return '#10b981';
        case 'cancelled':
            return '#ef4444';
        case 'pending':
            return '#f59e0b';
        default:
            return '#6b7280';
    }
}

function openCancelModal(bookingId) {
    document.getElementById('cancelBookingId').value = bookingId;
    cancelModal.show();
}

async function confirmCancel() {
    const bookingId = parseInt(document.getElementById('cancelBookingId').value);

    try {
        const response = await apiClient.cancelBooking(bookingId);

        cancelModal.hide();
        showSuccessNotification('Booking cancelled successfully!');

        // Reload bookings
        await loadBookings();
    } catch (error) {
        showErrorMessage(error.message || 'Failed to cancel booking. Please try again.');
        console.error('Cancel booking error:', error);
    }
}

function showLoadingSpinner(show) {
    document.getElementById('loadingSpinner').style.display = show ? 'block' : 'none';
}

function showNoBookingsMessage(show) {
    document.getElementById('noBookingsMessage').style.display = show ? 'block' : 'none';
}

function showErrorMessage(message) {
    const errorDiv = document.getElementById('errorMessage');
    errorDiv.textContent = message;
    errorDiv.style.display = 'block';

    setTimeout(() => {
        errorDiv.style.display = 'none';
    }, 5000);
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
