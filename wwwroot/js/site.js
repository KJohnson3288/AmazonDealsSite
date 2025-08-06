// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Promo code copy function
    function copyCode(code) {
        const element = document.getElementById(`code-${code}`);
    if (element) {
        navigator.clipboard.writeText(code).then(() => {
            // Swap icon for checkmark
            element.innerHTML = `<span class="me-1">${code}</span><i class="bi bi-clipboard-check-fill"></i>`;
            setTimeout(() => {
                element.innerHTML = `<span class="me-1">${code}</span><i class="bi bi-clipboard"></i>`;
            }, 1500);

            // Show toast
            const toast = new bootstrap.Toast(document.getElementById('copyToast'));
            toast.show();
        });
        }
    }



