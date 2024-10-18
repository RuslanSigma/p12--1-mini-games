// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function hideOtherElements(clickedElement) {
    // Отримуємо всі елементи з класом "anime-card"
    var elements = document.querySelectorAll('.anime-card');

    // Проходимо через всі елементи
    elements.forEach(function (element) {
        // Якщо елемент не є натиснутим, приховуємо його
        if (element !== clickedElement) {
            element.style.display = 'none';
        }
    });
}