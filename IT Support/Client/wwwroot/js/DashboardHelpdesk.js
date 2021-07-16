//Data Tabel Master
$(document).ready(function () {
    $('#masterData').DataTable({
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
            }
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

//Data Tabel Ticket
//$(document).ready(function () {
//    $('#registerData1').DataTable({
//        dom: 'Bfrtip',
//        buttons: [
//            'copy', 'csv', 'excel', 'pdf', 'print'
//        ],
//        "ajax": {
//            url: "/admin/getrequestview/",
//            dataSrc: ""
//        },
//        "columns": [
//            {
//                "data": "title"
//            },
//            {
//                "data": "startDate"
//            },
//            {
//                "data": "updateDate"
//            },
//            {
//                "data": "idTicket"
//            },
//            {
//                "data": "detail"
//            },
//            {
//                "data": null,
//                targets: 'no-sort', orderable: false,
//                render: function (data, type, row) {
//                    return `<button value="" class="btn btn-warning">Update</button>
//                            <button value="" onclick="delEmployee(this.value)" class="btn btn-danger">Delete</button>`
//                }
//            }

//        ],
//        buttons: {
//            buttons: [
//                { extend: 'copy', className: 'btn btn-primary' },
//                { extend: 'csv', className: 'btn btn-primary' },
//                { extend: 'excel', className: 'btn btn-primary' },
//                { extend: 'pdf', className: 'btn btn-primary', orientation: 'landscape' },
//                { extend: 'print', className: 'btn btn-primary' },
//            ]
//        }
//    })
////})

////Submit Ticket
//$("#saved1").click(function () {
//    $("#saved1").submit(function (e) {
//        e.preventDefault;
//    })
//    /*console.log("Input Berhasil");*/
//    var obj = new Object(); //sesuaikan sendiri nama objectnya dan beserta isinya
//    //ini ngambil value dari tiap inputan di form nya
//    obj.title = $("#title").val();
//    obj.message = $("#message").val();
//    obj.startDate = $("#startdate").val();
//    obj.updateDate = $("#updatedate").val();
//    obj.nik = $("#nik").val();
   
//    /*console.log(obj);*/
//    //isi dari object kalian buat sesuai dengan bentuk object yang akan di post
//    $.ajax({
//        url: "https://localhost:44311/API/TicketRequests/Request",
//        type: "POST",
//        data: JSON.stringify(obj),
//        contentType: "application/json",
//        dataType: "json"
//    }).done((result) => {
//        alert("Data Telah Sukses Dimasukkan");
//    }).fail((error) => {
//        console.log(error);
//    })
//})