$(function () {
    'use strict';

    $('.form-control').on('input', function () {
        var $field = $(this).closest('.form-group');
        if (this.value) {
            $field.addClass('field--not-empty');
        } else {
            $field.removeClass('field--not-empty');
        }
    });
});

//document.getElementById("submit").addEventListener("click", function () {
function login() {
    var datas = $('#submitlogin').serialize()

    var obj = new Object()

    obj.NIK = document.getElementById("Email").value;
    obj.Password = document.getElementById("Password").value;

    console.log(datas)

    $.ajax({
        url: "/login/auth/",
        type: "POST",
        data: datas
    }).done((role) => {
        if (role == "Employee") {
            /*return RedirectToAction("dashboard", "admin");*/
            window.location = "https://localhost:44329/admin/dashboard";

        }
        else if (role == "Junior Helpdesk") {
            /*return RedirectToAction("junior", "admin");*/
            window.location = "https://localhost:44329/admin/junior";
        }
        else if (role == "Helpdesk") {
            /*  return RedirectToAction("helpdesk", "admin");*/
            window.location = "https://localhost:44329/admin/helpdesk";
        }
        else if (role == "Engineer") {
            /*  return RedirectToAction("engineer", "admin");*/
            window.location = "https://localhost:44329/admin/engineer";
        }
        else {
            Swal.fire({
                title: "Failed!",
                text: "Email/Password Salah",
                icon: "Warning"
            })
        }

    }).fail((error) => {

        Swal.fire({
            title: "Failed!",
            text: `${error.responseJSON.message}`,
            icon: "Warning"
        }).then(function (result) {
            if (true) {
                window.location = "https://localhost:44329/login";
            }
        })
    })
}

$("#Forgot").click(function () {
    /*console.log("Input Berhasil");*/
    var obj = new Object(); //sesuaikan sendiri nama objectnya dan beserta isinya
    //ini ngambil value dari tiap inputan di form nya
    obj.email = $("#EmailForgot").val();
    /*console.log(obj);*/
    //isi dari object kalian buat sesuai dengan bentuk object yang akan di post
    $.ajax({
        url: "https://localhost:44311/API/Accounts/Forgot",
        type: "POST",
        data: JSON.stringify(obj),
        contentType: "application/json",
        dataType: "json"
    }).done((result) => {
        console.log()
        if (result.result == 1) {
            Swal.fire({
                title: "Good job!",
                text: "Email Sent",
                icon: "success"
            });
        }
    }).fail((error) => {
        Swal.fire({
            title: "Failed!",
            text: "Email Tidak Ada",
            icon: "Warning"
        })
    })
})