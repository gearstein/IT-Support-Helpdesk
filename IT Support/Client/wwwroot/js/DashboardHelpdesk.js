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
                    return `<div class="row">
                            <button class="btn btn-success mr-1 mt-1 data-toggle="tooltip" data-placement="top" title="Complete" onclick="updatestatus1(${row['idTicket']})"><i class="fa fa-check-square" aria-hidden="true"></i></button>
                            <button class="btn btn-warning mr-1 mt-1 data-toggle="tooltip" data-placement="top" title="Send" onclick="updatestatus2(${row['idTicket']})"><i class="fa fa-share" aria-hidden="true"></i></button>
                            </div>
                            `
                }
            },
            {
                "data": "phoneNumber",
                render: function (data, type, row) {
                    return "+62" + data.slice(1);
                }
            },

            {
                "data": null,
                "render": function (data, type, row) {
                    return row["firstName"] + " " + row["lastName"];
                }
            },
            {
                "data": "message",
                className: "text-justify",
                "render": function (data, type, row) {
                    return '<br>' + data;
                }
            }
        ]
    });

    //Reload table
    setInterval(function () {
        table.ajax.reload();
    }, 30000);

});
//Send Email
function send(ticket) {
    $.ajax({
        url: "https://localhost:44311/API/Accounts/NotifSend/" + ticket +"/engineer",
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
                "data": "message",
                className: "text-justify text-break",
                "render": function (data, type, row) {
                    return data;
                }
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
        ]
    });


    //Reload table
    setInterval(function () {
        table.ajax.reload();
    }, 30000);

});




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
