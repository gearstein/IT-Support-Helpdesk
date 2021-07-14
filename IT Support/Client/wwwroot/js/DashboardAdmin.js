//Data Tabel Ticket
$(document).ready(function () {
    $('#registerData').DataTable({
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "ajax": {
            url: "/employee/getregistrasiview/",
            dataSrc: ""
        },
        "columns": [
            {
                /*"data": "firstName"*/
                "data": null,
                "render": function (data, type, row) {
                    return row["firstName"] + " " + row["lastName"];
                }
            },
            {
                "data": "birthDate"
            },
            {
                "data": "email"
            },
            {
                "data": "phoneNumber",
                render: function (data, type, row) {
                    return "+62" + data.slice(1);
                }
            },
            {
                "data": "roleName"
            },
            {
                "data": "salary"
            },
            {
                "data": "degree"
            },
            {
                "data": "gpa"
            },
            {
                "data": "universityName"
            },
            {
                "data": null,
                "render": function (data, type, row) {
                    return "<button class = \"btn btn-primary\">Edit</button>";
                }
            }
        ],
        columnDefs: [
            { orderable: false, targets: 10 }
        ],
        buttons: {
            buttons: [
                { extend: 'copy', className: 'btn btn-primary' },
                { extend: 'csv', className: 'btn btn-primary' },
                { extend: 'excel', className: 'btn btn-primary' },
                { extend: 'pdf', className: 'btn btn-primary', orientation: 'landscape' },
                { extend: 'print', className: 'btn btn-primary' },
            ]
        }
    })
})
//Submit Ticket
$("#saved").click(function () {
    $("#saved").submit(function (e) {
        e.preventDefault;
    })
    /*console.log("Input Berhasil");*/
    var obj = new Object(); //sesuaikan sendiri nama objectnya dan beserta isinya
    //ini ngambil value dari tiap inputan di form nya
    obj.nik = $("#nik").val();
    obj.firstName = $("#first-name").val();
    obj.lastName = $("#last-name").val();
    obj.Gender = $("#gender").val();
    obj.email = $("#email").val();
    obj.salary = $("#salary").val();
    obj.phoneNumber = $("#phone-number").val();
    obj.birthDate = $("#birth-date").val();
    obj.password = $("#password").val();
    obj.degree = $("#degree").val();
    obj.GPA = $("#gpa").val();
    obj.universityid = $("#uniname").val();
    obj.roleName = 1;
    /*console.log(obj);*/
    //isi dari object kalian buat sesuai dengan bentuk object yang akan di post
    $.ajax({
        url: "https://localhost:44311/API/Employees/Register",
        type: "POST",
        data: JSON.stringify(obj),
        contentType: "application/json",
        dataType: "json"
    }).done((result) => {
        alert("Data Telah Sukses Dimasukkan");
    }).fail((error) => {
        console.log(error);
    })
})