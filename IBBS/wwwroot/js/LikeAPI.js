"user strict";
async function LikeApi() {
    const url = new URL("https://localhost:44363/api/Like");

    const response = await fetch(url);
    let Data = await response.json();

    return console.log(Data);
}

function PostLike() {
    let _data = {
        Like: Like,
        Dislike: Dislike
    };
    fetch("https://localhost:44363/api/Like", {
        method: "POST",
        body: JSON.stringify(_data),
        headers: { "Content-Type": "application/json" },
    })
        .then((_data) => {
            console.log("Success:", _data);
        })
        .catch((error) => {
            console.error("Error:", error);
        });
}