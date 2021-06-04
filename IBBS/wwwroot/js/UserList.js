//UserList Page

document.querySelectorAll(".removeFunction").forEach(item => {
    item.addEventListener("submit", function (e) {
        let r = confirm("Are you sure you want to delete this account?");
        if (r == false) {
            e.preventDefault();
        }
    })

})

