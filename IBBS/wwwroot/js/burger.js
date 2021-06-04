let TopBun = document.getElementById("TopBun");
let sallad = document.getElementById("sallad");
let tomato = document.getElementById("tomato");
let meat = document.getElementById("meat");
let BottomBun = document.getElementById("BottomBun");

// btn
let TopBunBtn = document.getElementById("TopBunBtn");
let SalladBtn = document.getElementById("SalladBtn");
let TomatoBtn = document.getElementById("TomatoBtn");
let MeatBtn = document.getElementById("MeatBtn");
let BottomBunBtn = document.getElementById("BottomBunBtn");

TopBunBtn.addEventListener("click", function () {
    if (TopBun.style.display == "none" || TopBun.style.display == "")
        TopBun.style.display = "inline";
    else {
        TopBun.style.display = "none";
    }
});

SalladBtn.addEventListener("click", function () {
    if (sallad.style.display == "none" || sallad.style.display == "")
        sallad.style.display = "inline";
    else {
        sallad.style.display = "none";
    }
});

TomatoBtn.addEventListener("click", function () {
    if (tomato.style.display == "none" || tomato.style.display == "")
        tomato.style.display = "inline";
    else {
        tomato.style.display = "none";
    }
});

MeatBtn.addEventListener("click", function () {
    if (meat.style.display == "none" || meat.style.display == "")
        meat.style.display = "inline";
    else {
        meat.style.display = "none";
    }
});

BottomBunBtn.addEventListener("click", function () {
    if (BottomBun.style.display == "none" || BottomBun.style.display == "")
        BottomBun.style.display = "inline";
    else {
        BottomBun.style.display = "none";
    }
});


