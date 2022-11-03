

function Toggle() {
    const body = document.querySelector("body");
    const toggle = document.querySelector("#toggle");
    const sunIcon = document.querySelector(".toggle #sun");
    const moonIcon = document.querySelector(".toggle #moon");
    body.classList.toggle("dark");
    sunIcon.className = sunIcon.className == "bx bxs-sun" ? "bx bx-sun" : "bx bxs-sun";
    moonIcon.className = moonIcon.className == "bx bxs-moon" ? "bx bx-moon" : "bx bxs-moon";
}