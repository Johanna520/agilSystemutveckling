"use strict";
let Thumbsup = document.getElementById("thumbsup");
let Likes = document.getElementById("Likes");
let Like = 0;
let Liked = false;

Thumbsup.addEventListener("click", function () {
    if (Liked === false) {
        Like += 1;
        Likes.innerHTML = Like;
        disliked = false;
        Liked = true;

        if (Dislike <= 0) {
            PostLike();
            return Dislike;
        } else {
            Dislike -= 1;
            Dislikes.innerHTML = Dislike;

            PostLike();
        }
    } else {
        Like -= 1;
        Likes.innerHTML = Like;
        Liked = false;
    }
});

let Thumbsdown = document.getElementById("thumbsdown");
let Dislikes = document.getElementById("dislikes");
let Dislike = 0;
let disliked = false;
Thumbsdown.addEventListener("click", function () {
    if (disliked === false) {
        Dislike += 1;
        Dislikes.innerHTML = Dislike;
        Liked = false;
        disliked = true;
        if (Like <= 0) {
            PostLike();
            return Like;
        } else {
            Like -= 1;
            Likes.innerHTML = Like;
            PostLike();
        }
    } else {
        Dislike -= 1;
        Dislikes.innerHTML = Dislike;
        disliked = false;
    }

});


