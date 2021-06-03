//UserList Page

let i = 0;
let name = document.querySelectorAll(".testar");
let names = Array.from(name);


document.querySelectorAll(".removeFunction").forEach(item => {

    item.addEventListener("submit", function (evt) {

        let test = document.getElementById("test").value;
        let r = confirm("Are you sure you want to delete this account? \n" + names[i].value);
        if (r == false) {
            evt.preventDefault();
        }
        i++;
    })

})
