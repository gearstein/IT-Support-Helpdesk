$(document).ready(function () {
    $('#masterData').DataTable({
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'copyHtml5',
                text: '<i class="fa fa-copy"></i>',
                titleAttr: 'Copy'
            },
            {
                extend: 'excelHtml5',
                text: '<i class="fa fa-file-excel-o"></i>',
                titleAttr: 'Excel'
            },
            {
                extend: 'csvHtml5',
                text: '<i class="fa fa-file-text"></i>',
                titleAttr: 'CSV'
            },
            {
                extend: 'pdfHtml5',
                text: '<i class="fa fa-file-pdf-o"></i>',
                titleAttr: 'PDF'
            },
            {
                extend: 'print',
                text: '<i class="fa fa-print"></i>',
                titleAttr: 'Print',
                autoPrint: false
            }
        ],
        "ajax": {
            url: "/employee/getregistrasiview/",
            dataSrc: ""
        },
        "columns": [
            {
                "data": null,
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            {
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
        ]
    })
})



////Datatable and fill table
//$(document).ready(function () {
//    var table = $('#registerData').DataTable({
//        responsive: true,
//        bAutoWidth: true,
//        dom: 'Bfrtip',
//        buttons: [
//            {
//                extend: 'copyHtml5',
//                text: '<i class="fa fa-copy"></i>',
//                titleAttr: 'Copy'
//            },
//            {
//                extend: 'excelHtml5',
//                text: '<i class="fa fa-file-excel-o"></i>',
//                titleAttr: 'Excel'
//            },
//            {
//                extend: 'csvHtml5',
//                text: '<i class="fa fa-file-text"></i>',
//                titleAttr: 'CSV'
//            },
//            {

//                extend: 'pdfHtml5',
//                text: '<i class="fa fa-file-pdf-o"></i>',
//                titleAttr: 'PDF'

//            },
//            {
//                extend: 'print',
//                text: '<i class="fa fa-print"></i>',
//                titleAttr: 'Print',
//                autoPrint: false
//            }
//        ],

//        "ajax": {
//            /* url: "/admin/getrequestview/",*/
//            url: "https://localhost:44311/API/TicketRequests/ViewRequestHelpdesk",
//            dataType: "json",
//            dataSrc: ""

//        },
//        "columns": [
//            {
//                "data": null,
//                render: function (data, type, row, meta) {
//                    return meta.row + meta.settings._iDisplayStart + 1;
//                }
//            },
//            {
//                "data": "idTicket",
//                render: function (data, type, row) {
//                    return "TR" + data + "MCC";
//                }
//            },

//            {
//                "data": "title"
//            },
//            {
//                "data": "email"
//            },

//            {
//                "data": "startDate",

//                render: function (data, type, row) {
//                    date = new Date(data);
//                    return date.toLocaleString();

//                }
//            },
//            {
//                "data": "updateDate",

//                render: function (data, type, row) {
//                    date = new Date(data);
//                    return date.toLocaleString();

//                }
//            },
//            {
//                "data": "detail",
//                render: function (data, type, row) {
//                    if (data == "Pending") {
//                        return `<span class="badge badge-danger">` + data + `</span>`
//                    } else if (data == "On Going") {
//                        return `<span class="badge badge-info">` + data + `</span>`
//                    } else {
//                        return `<span class="badge badge-success">` + data + `</span>`
//                    }
//                }
//            },
//            {
//                "data": null,
//                targets: 'no-sort', orderable: false,
//                render: function (data, type, row) {
//                    return `<div class="row">
//                            <button class="btn btn-success mr-1 mt-1 data-toggle="tooltip" data-placement="top" title="Complete" onclick="updatestatus1(${row['idTicket']})"><i class="fa fa-check-square" aria-hidden="true"></i></button>
//                            <button class="btn btn-warning mr-1 mt-1 data-toggle="tooltip" data-placement="top" title="Send" onclick="updatestatus2(${row['idTicket']})"><i class="fa fa-share" aria-hidden="true"></i></button>
//                            </div>
//                            `
//                }
//            },
//            {
//                "data": "phoneNumber",
//                render: function (data, type, row) {
//                    return "+62" + data.slice(1);
//                }
//            },

//            {
//                "data": null,
//                "render": function (data, type, row) {
//                    return row["firstName"] + " " + row["lastName"];
//                }
//            },
//            {
//                "data": "message",
//                className: "text-justify",
//                "render": function (data, type, row) {
//                    return '<br>' + data;
//                }
//            }
//        ]
//    });

//    //Reload table
//    setInterval(function () {
//        table.ajax.reload();
//    }, 30000);
/*});*/



//Datatable and fill table
$(document).ready(function () {
    var table = $('#registerData').DataTable({
        responsive: true,
        bAutoWidth: true,
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'copyHtml5',
                text: '<i class="fa fa-copy"></i>',
                titleAttr: 'Copy'
            },
            {
                extend: 'excelHtml5',
                text: '<i class="fa fa-file-excel-o"></i>',
                titleAttr: 'Excel'
            },
            {
                extend: 'csvHtml5',
                text: '<i class="fa fa-file-text"></i>',
                titleAttr: 'CSV'
            },
            {

                extend: 'pdfHtml5',
                text: '<i class="fa fa-file-pdf-o"></i>',
                titleAttr: 'PDF'

            },
            {
                extend: 'print',
                text: '<i class="fa fa-print"></i>',
                titleAttr: 'Print',
                autoPrint: false
            }
        ],

        "ajax": {
            /* url: "/admin/getrequestview/",*/
            url: "https://localhost:44311/API/TicketRequests/ViewRequestHelpdesk",
            dataType: "json",
            dataSrc: ""

        },
        "columns": [
            {
                "data": null,
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            {
                "data": "idTicket",
                render: function (data, type, row) {
                    return "TR" + data + "MCC";
                }
            },
            {
                "data": "title"
            },
            {
                "data": "email"
            },

            {
                "data": "startDate",

                render: function (data, type, row) {
                    date = new Date(data);
                    return date.toLocaleString();

                }
            },
            {
                "data": "updateDate",

                render: function (data, type, row) {
                    date = new Date(data);
                    return date.toLocaleString();

                }
            },
            {
                "data": "detail",
                render: function (data, type, row) {
                    if (data == "Pending") {
                        return `<span class="badge badge-danger">` + data + `</span>`
                    } else if (data == "On Going") {
                        return `<span class="badge badge-info">` + data + `</span>`
                    } else {
                        return `<span class="badge badge-success">` + data + `</span>`
                    }
                }
            },
            {
                "data": null,
                targets: 'no-sort', orderable: false,
                render: function (data, type, row) {
                    return `<button class="btn btn-warning" onclick="detail(${row['idTicket']})"  data-toggle="modal" data-toggle="tooltip" data-placement="left"title="Detail" data-target="#getdetail"><i class="fa fa-expand" aria-hidden="true"></i></button>`
                }
            }
        ]
    });



    $("#ongoing").click(function () {

        let id = document.getElementById("idtemp").value;

        Swal.fire({
            title: 'Do you want to change the status to On Going ?',
            showCancelButton: true,
            confirmButtonText: `Yes`
        }).then((result) => {
            /* Read more about isConfirmed, isDenied below */
            if (result.isConfirmed) {
                $.ajax({
                    url: "https://localhost:44311/API/TicketRequests/" + id
                }).done((result) => {

                    var obj = new Object()

                    obj.idTicket = result.idTicket
                    obj.title = result.title
                    obj.message = result.message
                    obj.startDate = result.startDate
                    obj.nik = result.nik
                    obj.updateDate = new Date().toLocaleString();
                    obj.idStat = 2
                    obj.idpriority = 1

                    $.ajax({
                        url: "https://localhost:44311/API/TicketRequests/",
                        type: "PUT",
                        data: JSON.stringify(obj),
                        contentType: "application/json",
                        dataType: "json"

                    })
                        .done((hasil) => {
                            Swal.fire('Saved!', '', 'success')
                            /* $('#getdetail').modal('hide')*/
                            table.ajax.reload();
                        }).fail((error) => {

                            Swal.fire('Changes are not saved', '', 'info')
                        });
                })
            }
        })

    });



    $("#complete").click(function () {


        let id = document.getElementById("idtemp").value;

        Swal.fire({
            title: 'Do you want to change the status to Complete ?',
            showCancelButton: true,
            confirmButtonText: `Yes`
        }).then((result) => {
            /* Read more about isConfirmed, isDenied below */
            if (result.isConfirmed) {
                $.ajax({
                    url: "https://localhost:44311/API/TicketRequests/" + id
                }).done((result) => {

                    var obj = new Object()

                    obj.idTicket = result.idTicket
                    obj.title = result.title
                    obj.message = result.message
                    obj.startDate = result.startDate
                    obj.nik = result.nik
                    obj.updateDate = new Date().toLocaleString();
                    obj.idStat = 3
                    obj.idpriority = 1

                    $.ajax({
                        url: "https://localhost:44311/API/TicketRequests/",
                        type: "PUT",
                        data: JSON.stringify(obj),
                        contentType: "application/json",
                        dataType: "json"

                    })
                        .done((hasil) => {
                            Swal.fire('Saved!', '', 'success')
                            table.ajax.reload();
                        }).fail((error) => {

                            Swal.fire('Changes are not saved', '', 'info')
                        });
                })
            }
        })

    })


    $("#send").click(function () {

        let id = document.getElementById("idtemp").value;

        Swal.fire({
            title: 'Do you want to send a report ticket to level 2 ',
            showCancelButton: true,
            confirmButtonText: `Yes`
        }).then((result) => {
            /* Read more about isConfirmed, isDenied below */
            if (result.isConfirmed) {
                $.ajax({
                    url: "https://localhost:44311/API/TicketRequests/" + id
                }).done((result) => {
                    $.ajax({
                        url: "https://localhost:44311/API/TicketRequests/FindRequest/" + id,
                    }).done((result) => {
                        send(id);
                    })
                    var obj = new Object()

                    obj.idTicket = result.idTicket
                    obj.title = result.title
                    obj.message = result.message
                    obj.startDate = result.startDate
                    obj.nik = result.nik
                    obj.idStat = result.idStat
                    obj.updateDate = new Date().toLocaleString();
                    obj.idpriority = 2

                    $.ajax({
                        url: "https://localhost:44311/API/TicketRequests/",
                        type: "PUT",
                        data: JSON.stringify(obj),
                        contentType: "application/json",
                        dataType: "json"

                    })
                        .done((hasil) => {
                            Swal.fire('Saved!', '', 'success')
                            table.ajax.reload();
                        }).fail((error) => {

                            Swal.fire('Changes are not saved', '', 'info')
                        });
                })
            }
        })
    })


    //Reload table
    setInterval(function () {
        table.ajax.reload();
    }, 30000);
});





function detail(idTicket) {

    $.ajax({
        url: "https://localhost:44311/API/TicketRequests/ViewRequestDetail",
    }).done((result) => {
        $.each(result, function (index, val) {

            if (val.idTicket == idTicket) {

                console.log(result)

                let a = new Date(val.startDate)
                let b = new Date(val.updateDate)
                let c = Math.abs(b - a) / 86400000;

                $("#idtemp").val(idTicket)

                $("#idTicket").html("TR" + val.idTicket + "MCC")
                $("#title1").html(val.title)
                $("#startDate").html(val.startDate)
                $("#updateDate").html(val.updateDate)

                /*   $("#selisih").html(parseInt(c) + " Day")*/

                $("#detail").html(val.detail)
                if (val.detail == "Pending") {
                    $("#detail").html('<span class="badge badge-danger">' + val.detail + '</span>')
                    $("#ongoing").show()
                    $("#complete").hide()

                } else {
                    $("#detail").html('<span class="badge badge-info">' + val.detail + '</span>')
                    $("#ongoing").hide()
                    $("#complete").show()
                }

                //$("#cutiV").html(result[0].leaveQuota)
                //if (result[0].leaveStatus == 1) {
                //    $("#statusV").html('<span class="badge bg-success">Masuk</span>')
                //} else {
                //    $("#statusV").html('<span class="badge bg-secondary">Cuti</span>')
                //}
                $("#firstname").html(result[0].firstName + " " + result[0].lastName)
                /*   $("#firstname").html(val.firstName)*/
                var tel = parseInt(result[0].phoneNumber);
                $("#phoneNumber").html("+62" + tel)
                /* $("#phoneNumber").html(val.phoneNumber)*/
                $("#email").html(val.email)
                $("#message1").html(val.message)
            }
        })

    })
}




//Send Email
function send(ticket) {
    $.ajax({
        url: "https://localhost:44311/API/Accounts/NotifSend/" + ticket + "/Engineer",
        type: "GET",
        success: function () {
        },
        error: function (err) {
            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Something went wrong, Call Helpdesk!',
                showConfirmButton: false,
                timer: 1800
            })
        }
    });
}

// Change to complite and new update date

function updatestatus1(put) {

    Swal.fire({
        title: 'Do you want to change the status to Complete ?',
        showCancelButton: true,
        confirmButtonText: `Yes`
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
                obj.idpriority = result.idpriority
                obj.updateDate = new Date().toLocaleString();
                obj.idStat = 3

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

// Change Id priority to lv 3 and new update date
function updatestatus2(put) {

    Swal.fire({
        title: 'Do you want to send a report ticket to level 3',
        showCancelButton: true,
        confirmButtonText: `Yes`
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "https://localhost:44311/API/TicketRequests/" + put
            }).done((result) => {
                $.ajax({
                    url: "https://localhost:44311/API/TicketRequests/FindRequest/" + put,
                }).done((result) => {
                    send(put);
                })
                var obj = new Object()

                obj.idTicket = result.idTicket
                obj.title = result.title
                obj.message = result.message
                obj.startDate = result.startDate
                obj.nik = result.nik
                obj.idStat = result.idStat
                obj.updateDate = new Date().toLocaleString();
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



////Datatable and fill table
//$(document).ready(function () {
//    var table = $('#history').DataTable({
//        responsive: true,

//        dom: 'Bfrtip',
//        buttons: [
//            {
//                extend: 'copyHtml5',
//                text: '<i class="fa fa-copy"></i>',
//                titleAttr: 'Copy'
//            },
//            {
//                extend: 'excelHtml5',
//                text: '<i class="fa fa-file-excel-o"></i>',
//                titleAttr: 'Excel'
//            },
//            {
//                extend: 'csvHtml5',
//                text: '<i class="fa fa-file-text"></i>',
//                titleAttr: 'CSV'
//            },
//            {
//                extend: 'pdfHtml5',
//                text: '<i class="fa fa-file-pdf-o"></i>',
//                titleAttr: 'PDF'
//            },
//            {
//                extend: 'print',
//                text: '<i class="fa fa-print"></i>',
//                titleAttr: 'Print',
//                autoPrint: false
//            }
//        ],

//        "ajax": {
//            /* url: "/admin/getrequestview/",*/
//            url: "https://localhost:44311/API/TicketRequests/ViewComplete",
//            dataType: "json",
//            dataSrc: ""
//        },
//        "columns": [
//            {
//                "data": null,
//                render: function (data, type, row, meta) {
//                    return meta.row + meta.settings._iDisplayStart + 1;
//                }
//            },
//            {
//                "data": "idTicket",
//                render: function (data, type, row) {
//                    return "TR" + data + "MCC";
//                }
//            },
//            {
//                "data": "title"
//            },
//            {
//                "data": "message",
//                className: "text-justify text-break",
//                "render": function (data, type, row) {
//                    return data;
//                }
//            },
//            {
//                "data": "startDate",
//                render: function (data, type, row) {
//                    date = new Date(data);
//                    return date.toLocaleString();
//                }
//            },
//            {
//                "data": "updateDate",
//                render: function (data, type, row) {
//                    date = new Date(data);
//                    return date.toLocaleString();
//                }
//            },
//            {
//                "data": "detail",
//                render: function (data, type, row) {
//                    if (data == "Pending") {
//                        return `<span class="badge badge-danger">` + data + `</span>`
//                    } else if (data == "On Going") {
//                        return `<span class="badge badge-info">` + data + `</span>`
//                    } else {
//                        return `<span class="badge badge-success">` + data + `</span>`
//                    }
//                }
//            },
//        ]
//    });


//    //Reload table
//    setInterval(function () {
//        table.ajax.reload();
//    }, 30000);

//});







//Datatable and fill table
$(document).ready(function () {
    var table = $('#history').DataTable({
        responsive: true,

        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'copyHtml5',
                text: '<i class="fa fa-copy"></i>',
                titleAttr: 'Copy'
            },
            {
                extend: 'excelHtml5',
                text: '<i class="fa fa-file-excel-o"></i>',
                titleAttr: 'Excel'
            },
            {
                extend: 'csvHtml5',
                text: '<i class="fa fa-file-text"></i>',
                titleAttr: 'CSV'
            },
            {

                extend: 'pdfHtml5',
                text: '<i class="fa fa-file-pdf-o"></i>',
                titleAttr: 'PDF'

            },
            {
                extend: 'print',
                text: '<i class="fa fa-print"></i>',
                titleAttr: 'Print',
                autoPrint: false
            }
        ],

        "ajax": {
            /* url: "/admin/getrequestview/",*/
            url: "https://localhost:44311/API/TicketRequests/ViewComplete",
            dataType: "json",
            dataSrc: ""
        },
        "columns": [
            {
                "data": null,
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            {
                "data": "idTicket",
                render: function (data, type, row) {
                    return "TR" + data + "MCC";
                }
            },
            {
                "data": "title"
            },
            {
                "data": "email",

            },
            {
                "data": "startDate",
                render: function (data, type, row) {
                    date = new Date(data);
                    return date.toLocaleString();

                }
            },
            {
                "data": "updateDate",
                render: function (data, type, row) {
                    date = new Date(data);
                    return date.toLocaleString();

                }
            },
            {
                "data": "detail",
                render: function (data, type, row) {
                    if (data == "Pending") {
                        return `<span class="badge badge-danger">` + data + `</span>`
                    } else if (data == "On Going") {
                        return `<span class="badge badge-info">` + data + `</span>`
                    } else {
                        return `<span class="badge badge-success">` + data + `</span>`
                    }
                }
            },

            {
                "data": null,
                targets: 'no-sort', orderable: false,
                render: function (data, type, row) {
                    return `<button class="btn btn-warning" onclick="detail2(${row['idTicket']})"  data-toggle="modal" data-toggle="tooltip" data-placement="left"title="Detail" data-target="#getdetailhistory"><i class="fa fa-expand" aria-hidden="true"></i></button>`


                }
            }
        ]
    });

    //Reload table
    setInterval(function () {
        table.ajax.reload();
    }, 30000);

});



function detail2(idTicket) {

    $.ajax({
        url: "https://localhost:44311/API/TicketRequests/ViewComplete",
    }).done((result) => {
        $.each(result, function (index, val) {

            if (val.idTicket == idTicket) {

                console.log(result)

                let a = new Date(val.startDate)
                let b = new Date(val.updateDate)
                let c = Math.abs(b - a) / 86400000;

                $("#idTicket").html("TR" + val.idTicket + "MCC")
                $("#title2").html(val.title)
                $("#startDate").html(val.startDate)
                $("#updateDate").html(val.updateDate)

                $("#selisih").html(parseInt(c) + " Day")

                $("#detail").html('<span class="badge badge-success">' + val.detail + '</span>')
                //$("#cutiV").html(result[0].leaveQuota)
                //if (result[0].leaveStatus == 1) {
                //    $("#statusV").html('<span class="badge bg-success">Masuk</span>')
                //} else {
                //    $("#statusV").html('<span class="badge bg-secondary">Cuti</span>')
                //}
                $("#firstname").html(result[0].firstName + " " + result[0].lastName)
                /*   $("#firstname").html(val.firstName)*/
                var tel = parseInt(result[0].phoneNumber);
                $("#phoneNumber").html("+62" + tel)
                /* $("#phoneNumber").html(val.phoneNumber)*/
                $("#email").html(val.email)
                $("#message2").html(val.message)


            }
        })

    })
}






//For fill chart in dashboard link to id
// Chart Status
let Pending = countStatus("Pending");
let OnGoing = countStatus("On Going");
let Complete = countStatus("Complete");

var optionspie = {
    chart: {
        type: 'donut',
        height: '400px'
    },
    dataLabels: {
        enabled: false
    },
    series: [Pending, OnGoing, Complete],
    labels: ['pending', 'ongoing', 'complete'],
    noData: {
        text: 'Loading...'
    }
}

var chart = new ApexCharts(document.querySelector("#piechart"), optionspie);

chart.render();

function countStatus(detail) {
    let count = 0;
    jQuery.ajax({
        url: 'https://localhost:44311/api/TicketRequests/ViewChart',
        success: function (result) {
            $.each(result, function (key, val) {
                if (val.detail === detail) {
                    ++count;
                }
            });
        },
        async: false
    });
    return count;
}


//Chart Priority

let pri1 = countPri("Level 1");
let pri2 = countPri("Level 2");
let pri3 = countPri("Level 3");


var optionsbar = {
    chart: {
        type: 'bar',
        height: '234px'
    },
    series: [{
        name: 'priority from',
        data: [pri1, pri2, pri3]
    }],
    xaxis: {
        categories: ["Level 1", "Level 2", "Level 3"]
    }
}
var barChart = new ApexCharts(document.querySelector("#barChart"), optionsbar);
barChart.render();

function countPri(priorityName) {
    let count = 0;
    jQuery.ajax({
        url: 'https://localhost:44311/api/TicketRequests/ViewChart',
        success: function (result) {
            $.each(result, function (key, val) {
                if (val.priorityName === priorityName) {
                    ++count;
                }
            });
        },
        async: false
    });
    return count;
}

// Coba register

//Insert fill table from form registration to db (create data)
function insert() {
    var obj = new Object(); //sesuaikan sendiri nama objek dan isinya
    // ini ngambil value dari inputan dalam form nya

    obj.nik = $("#nik").val();
    obj.firstName = $("#firstname").val();
    obj.lastName = $("#lastname").val();
    obj.email = $("#email").val();
    obj.phoneNumber = $("#phonenumber").val();
    obj.password = $("#password").val();

    console.log(obj);
    // isi dari object kalian buat sesuai dengan bentuk object yang akan di post (insert)
    $.ajax({
        url: "https://localhost:44311/Api/Employees/Register",
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

//Ganti Password
function changepassword() {
    /*console.log("Input Berhasil");*/
    let passwordLama = $('#Password').val();
    let PasswordBaru = $('#PasswordBaru').val()
    let passwordBaruKonfirm = $('#PasswordDouble').val()

    if (passwordLama == "" || PasswordBaru == "" || passwordBaruKonfirm == "") {
        Swal.fire({
            title: "Failed!",
            text: "Password is Empty",
            icon: "Warning"
        });
    } else if (PasswordBaru != passwordBaruKonfirm) {
        Swal.fire({
            title: "Failed!",
            text: "New Password Not Match",
            icon: "Warning"
        });
    } else {
        var obj = new Object(); //sesuaikan sendiri nama objectnya dan beserta isinya
        //ini ngambil value dari tiap inputan di form nya
        obj.nik = $("#NIK").val();
        obj.passwordlama = passwordLama;
        obj.Passwordbaru = PasswordBaru;
        /*console.log(obj);*/
        //isi dari object kalian buat sesuai dengan bentuk object yang akan di post
        $.ajax({
            url: "https://localhost:44311/API/Accounts/Change",
            type: "POST",
            data: JSON.stringify(obj),
            contentType: "application/json",
            dataType: "json"
        }).done((result) => {
            console.log()
            if (result.result == 2) {
                Swal.fire({
                    title: "Good job!",
                    text: "Password Changed",
                    icon: "success"
                });
            }
        }).fail((error) => {
            Swal.fire({
                title: "Failed!",
                text: "Error",
                icon: "Warning"
            })
        })
    }
}