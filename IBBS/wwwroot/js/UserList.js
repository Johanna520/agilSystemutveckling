//UserList Page

let i = 0;
let name = document.querySelectorAll(".testar");
let names = Array.from(name);


document.querySelectorAll(".removeFunction").forEach(item => {
    let hej = item;
    item.addEventListener("submit", function (e) {

        let r = confirm("Are you sure you want to delete this account? \n" + names[i].value);
        if (r == false) {
            e.preventDefault();
        }
    })

})
