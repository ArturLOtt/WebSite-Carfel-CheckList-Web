
window.addEventListener('load', () => {
    document.querySelectorAll(".avatar img").forEach(img => {
        let randId = Math.floor((Math.random() * 500) + 10);
        img.src = `http://picsum.photos/${randId}`;
    });
});