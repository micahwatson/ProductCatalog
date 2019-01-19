// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/productHub").build();

console.log(connection);
connection.on("ReceiveNewProduct", function () {
    console.log("Received New Product");
    location.reload();
});

connection.start().then(function (value) {
    console.log("Connected");
    console.log(value);
});


//document.getElementById("create").addEventListener("click", function (event) {
//    connection.invoke("SendNewProduct").catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});
