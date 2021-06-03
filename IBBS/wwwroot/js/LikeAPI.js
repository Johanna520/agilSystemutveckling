"user strict";
async function LikeApi() {
    const url = new URL("https://localhost:44363/api/Like");

    const response = await fetch(url);
    let Data = await response.json();

    return Data;
}

LikeApi().then((Data) => alert(Data));
