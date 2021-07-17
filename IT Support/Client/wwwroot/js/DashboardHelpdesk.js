//////Data Tabel Master
////$(document).ready(function () {
////    $('#masterData').DataTable({
////        dom: 'Bfrtip',
////        buttons: [
////            'copy', 'csv', 'excel', 'pdf', 'print'
////        ],
////        "ajax": {
////            url: "/employee/getregistrasiview/",
////            dataSrc: ""
////        },
////        "columns": [
////            {
////                /*"data": "firstName"*/
////                "data": null,
////                "render": function (data, type, row) {
////                    return row["firstName"] + " " + row["lastName"];
////                }
////            },
////            {
////                "data": "email"
////            },
////            {
////                "data": "phoneNumber",
////                render: function (data, type, row) {
////                    return "+62" + data.slice(1);
////                }
////            },
////            {
////                "data": "roleName"
////            }
////        ],
////        buttons: {
////            buttons: [
////                { extend: 'copy', className: 'btn btn-primary' },
////                { extend: 'csv', className: 'btn btn-primary' },
////                { extend: 'excel', className: 'btn btn-primary' },
////                { extend: 'pdf', className: 'btn btn-primary', orientation: 'landscape' },
////                { extend: 'print', className: 'btn btn-primary' },
////            ]
////        }
////    })
////})

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

//Data Tabel Master
//$(document).ready(function () {
//    $('#masterdata').datatable({
//        dom: 'bfrtip',
//        buttons: [
//            'copy', 'csv', 'excel', 'pdf', 'print'
//        ],
//        "ajax": {
//            url: "/employee/getregistrasiview/",
//            datasrc: ""
//        },
//        "columns": [
//            {
//                /*"data": "firstname"*/
//                "data": null,
//                "render": function (data, type, row) {
//                    return row["firstname"] + " " + row["lastname"];
//                }
//            },
//            {
//                "data": "email"
//            },
//            {
//                "data": "phonenumber",
//                render: function (data, type, row) {
//                    return "+62" + data.slice(1);
//                }
//            },
//            {
//                "data": "rolename"
//            }
//        ],
//        buttons: {
//            buttons: [
//                { extend: 'copy', classname: 'btn btn-primary' },
//                { extend: 'csv', classname: 'btn btn-primary' },
//                { extend: 'excel', classname: 'btn btn-primary' },
//                { extend: 'pdf', classname: 'btn btn-primary', orientation: 'landscape' },
//                { extend: 'print', classname: 'btn btn-primary' },
//            ]
//        }
//    })
//})

////Data Tabel Ticket
//$(document).ready(function () {
//    $('#registerData').DataTable({
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
//                    return `<button value="" class="btn btn-info" data-toggle="modal" data-target="#getrequest">Detail</button>
//                            <button value="" onclick="delEmployee(this.value)" class="btn btn-danger ViewRequest">Delete</button>`
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
//    $(".ViewRequest").click(function () {
//        $.ajax({
//            url: $(this).data("url")
//        }).done((result) => {
//            //title
//            title = result.title;
//            $("#Title").text(title);
//            //detail
//            detail = result.detail;
//            $("#Detail").text(detail);
//        }).fail((error) => {
//            console.log(error);
//        });
//    })
//})

////Submit Ticket
//$("#saved").click(function () {
//    $("#saved").submit(function (e) {
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

//Datatable and fill table
$(document).ready(function () {
    var table = $('#registerData').DataTable({
        responsive: true,

        dom: 'Bfrtip',
        buttons: [
            { extend: 'copy' },
            { extend: 'csv' },
            { extend: 'excel' },
            { extend: 'pdf', orientation: 'landscape' },
            { extend: 'print' }
        ],

        "ajax": {
            /* url: "/admin/getrequestview/",*/
            url: "https://localhost:44311/API/TicketRequests/ViewRequest",
            dataType: "json",
            dataSrc: ""

        },
        "columns": [
            {
                "data": "idTicket"
            },
            {
                "data": "title"
            },

            //"data": "firstName",
            //render: function (data, type, row) {
            //    return row.firstName + '&nbsp' + row.lastName;

            /*  $.fn.dataTable.render.moment(to);*/

            {
                "data": "startDate"
                /*  , render: $.fn.dataTable.render.moment('M/D/YYYY')*/
                //render: function(from, to, locale) {
                //    return to = startDate;
                //}
            },

            //    {

            //    "data": "startDate",
            //    render: function (data, type, row) {
            //        if (type === "sort" || type === "type") {
            //            return data;
            //        }
            //        return moment(data).format("MM-DD-YYYY HH:mm");
            //    }
            //},

            {
                "data": "updateDate"
            },
            {
                "data": "detail"
            },
            {
                "data": null,
                targets: 'no-sort', orderable: false,
                render: function (data, type, row) {
                    return `<button class="btn btn-warning" onclick="updatestatus(${row['idTicket']})" >Update</button>
                            <button class="btn btn-success" onclick="updatestatus1(${row['idTicket']})" >Complete</button>
                            <button class="btn btn-info" onclick="updatestatus2(${row['idTicket']})" >Pass</button>`
                }
            }
        ]
    });

    //Reload table
    setInterval(function () {
        table.ajax.reload();
    }, 30000);

});


function updatestatus(put) {

    Swal.fire({
        title: 'Apakah ingin melanjutkan proses selanjutnya ?',
        showCancelButton: true,
        confirmButtonText: `Iya`
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "https://localhost:44311/API/TicketRequests/" + put
            }).done((result) => {

                var obj = new Object()

                obj.idTicket = result.idTicket
                obj.title = result.title
                obj.message = result.message
                obj.startDate = result.startDate
                obj.nik = result.nik
                obj.updateDate = new Date()
                obj.idStat = 2
                obj.idpriority = 3


                $.ajax({
                    url: "https://localhost:44311/API/TicketRequests/",
                    type: "PUT",
                    data: JSON.stringify(obj),
                    contentType: "application/json",
                    dataType: "json"

                })
                    .done((hasil) => {
                        Swal.fire('Saved!', '', 'success')
                    }).fail((error) => {

                        Swal.fire('Changes are not saved', '', 'info')
                    });
            })
        }
    })

}

function updatestatus1(put) {

    Swal.fire({
        title: 'Apakah ingin melanjutkan proses selanjutnya ?',
        showCancelButton: true,
        confirmButtonText: `Iya`
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "https://localhost:44311/API/TicketRequests/" + put
            }).done((result) => {

                var obj = new Object()

                obj.idTicket = result.idTicket
                obj.title = result.title
                obj.message = result.message
                obj.startDate = result.startDate
                obj.nik = result.nik
                obj.updateDate = new Date()
                obj.idStat = 3
                obj.idpriority = 3

                $.ajax({
                    url: "https://localhost:44311/API/TicketRequests/",
                    type: "PUT",
                    data: JSON.stringify(obj),
                    contentType: "application/json",
                    dataType: "json"

                })
                    .done((hasil) => {
                        Swal.fire('Saved!', '', 'success')
                    }).fail((error) => {

                        Swal.fire('Changes are not saved', '', 'info')
                    });
            })
        }
    })

}

function updatestatus2(put) {

    Swal.fire({
        title: 'Apakah ingin melanjutkan proses selanjutnya ?',
        showCancelButton: true,
        confirmButtonText: `Iya`
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "https://localhost:44311/API/TicketRequests/" + put
            }).done((result) => {

                var obj = new Object()

                obj.idTicket = result.idTicket
                obj.title = result.title
                obj.message = result.message
                obj.startDate = result.startDate
                obj.nik = result.nik
                obj.updateDate = new Date()
                obj.idStat = 2
                obj.idpriority = 4

                $.ajax({
                    url: "https://localhost:44311/API/TicketRequests/",
                    type: "PUT",
                    data: JSON.stringify(obj),
                    contentType: "application/json",
                    dataType: "json"

                })
                    .done((hasil) => {
                        Swal.fire('Saved!', '', 'success')
                    }).fail((error) => {

                        Swal.fire('Changes are not saved', '', 'info')
                    });
            })
        }
    })

}





//$.ajax({
//    url: "https://localhost:44311/api/ticketrequests/viewrequest"
//}).done((result) => {
//    $.each(result, function (key, val) {

//        document.getelementbyid("idticket").value = "val.idticket";
//        document.getelementbyid("title").value = "val.title";
//        document.getelementbyid("startdate").value = "val.startdate";
//        document.getelementbyid("updatedate").value = "val.updatedate";
//        document.getelementbyid("detail").value = "val.detail";
//    }
//    )
//}
//)



// Example starter JavaScript for disabling form submissions if there are invalid fields
window.addEventListener('load', () => {
    var forms = document.getElementsByClassName('needs-validation');
    for (let form of forms) {
        form.addEventListener('submit', (evt) => {
            if (!form.checkValidity()) {
                evt.preventDefault();
                evt.stopPropagation();
            } else {
                evt.preventDefault();
                insert();
            }
            form.classList.add('was-validated');
        });
    }
});

//Insert fill table from form registration to db (create data)
function insert() {
    var obj = new Object(); //sesuaikan sendiri nama objek dan isinya
    // ini ngambil value dari inputan dalam form nya

    obj.title = $("#title").val();
    obj.message = $("#message").val();
    obj.startDate = $("#startdate").val();
    obj.updateDate = $("#updatedate").val();
    obj.nik = $("#nik").val();

    console.log(obj);

    // isi dari object kalian buat sesuai dengan bentuk object yang akan di post (insert)
    $.ajax({
        url: "https://localhost:44311/API/TicketRequests/Request",
        type: "POST",
        data: JSON.stringify(obj),
        contentType: "application/json",
        dataType: "json"
    }).done((result) => {

        /* $("#reload").ajax.reload(null, false);*/

        Swal.fire({
            title: "Good job!",
            text: "Registration Success!",
            icon: "success"
        });


    }).fail((error) => {

        Swal.fire({
            title: "Failed!",
            text: `${error.responseJSON.message}`,
            icon: "Warning"
        });

        //alert pemberitahuan jika gagal
    })
}

