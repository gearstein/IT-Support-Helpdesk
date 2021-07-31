
//Datatable and fill table
$(document).ready(function () {
    var table = $('#registerData').DataTable({
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
            url: "https://localhost:44311/API/TicketRequests/ViewRequestJunior",
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
            }

           
       

        ]
    });

    //Reload table
    setInterval(function () {
        table.ajax.reload();
    }, 30000);

});




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
                jwt();
            }
            form.classList.add('was-validated');
        });
    }
});


//Send Email
function send(ticket) {
        $.ajax({
            url: "https://localhost:44311/API/Accounts/NotifSend/" + ticket + "/Junior Helpdesk",
            type: "GET",
            success: function () {
                Swal.fire({
                    title: "Good job!",
                    text: "Registration Success!",
                    icon: "success"
                });
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

//JWT
function jwt() {
    $.ajax({
        url: "/admin/findrequest/",
        type: "GET",
        contentType: "application/json",
        dataType: "json"
    }).done((result) => {
        insert(result[0].nik)
    }).fail((error) => {

    })
}
//Insert fill table from form registration to db (create data)
function insert(nik) {

    var obj = new Object(); //sesuaikan sendiri nama objek dan isinya
    // ini ngambil value dari inputan dalam form nya

    let dateObj = new Date().toLocaleString();
    /*console.log(dateObj)*/

    obj.title = $("#title").val();
    obj.message = $("#message").val();
    obj.startDate = dateObj;
    obj.updateDate = dateObj;
    /* obj.updateDate = $("#updatedate").val();*/
    obj.nik = nik;


    // isi dari object kalian buat sesuai dengan bentuk object yang akan di post (insert)
    $.ajax({
        url: "https://localhost:44311/API/TicketRequests/Request",
        type: "POST",
        data: JSON.stringify(obj),
        contentType: "application/json",
        dataType: "json"
    }).done((result) => {
        $.ajax({
            url: "https://localhost:44311/API/TicketRequests/FindRequest/" + nik,
        }).done((result) => {
            send(result[0].idTicket);
        })
        /*$(".bd-example-modal-lg").modal('hide')*/

        Swal.fire({
            title: "Good job!",
            text: "Registration Success!",
            icon: "success"
        });

        $("#registerData").DataTable().ajax.reload();

    }).fail((error) => {

        Swal.fire({
            title: "Failed!",
            text: `${error.responseJSON.message}`,
            icon: "Warning"
        });

        //alert pemberitahuan jika gagal
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
             url: "/admin/findcomplete/",
            /*url: "https://localhost:44311/API/TicketRequests/ViewComplete",*/
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
            }
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
