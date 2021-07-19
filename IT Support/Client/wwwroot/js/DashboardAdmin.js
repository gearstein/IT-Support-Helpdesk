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



//Datatable and fill table actual
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
            {
                "data": "startDate"
            },
            {
                "data": "updateDate"
            },
            {
                "data": "detail"
            },
            {
                "data": "priorityName"
            }
            //{
            //    "data": null,
            //    targets: 'no-sort', orderable: false,
            //    render: function (data, type, row) {
            //        return `<button class="btn btn-warning" onclick="updatestatus(${row['idTicket']})" >Update</button>
            //                <button class="btn btn-success" onclick="updatestatus1(${row['idTicket']})" >Complete</button>
            //                <button class="btn btn-info" onclick="updatestatus2(${row['idTicket']})" >Pass</button>`
            //    }
            //}
        ]
    });

    //Reload table
    setInterval(function () {
        table.ajax.reload();
    }, 30000);

});


//Datatable and fill table history
$(document).ready(function () {
    var table = $('#history').DataTable({
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
            url: "https://localhost:44311/API/TicketRequests/ViewComplete",
            dataType: "json",
            dataSrc: ""
        },
        "columns": [
            {
                "data": "idTicket"
            },
            {
                "data": "idTicket"
            },
            {
                "data": "message"
            },
            {
                "data": "title"
            },
            {
                "data": "startDate"
            },
            {
                "data": "updateDate"
            },
            {
                "data": "detail"
            },
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
                    }).fail((error) => {

                        Swal.fire('Changes are not saved', '', 'info')
                    });
            })
        }
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






//var currentdate = new Date();
//var datetime = "Last Sync: " + currentdate.getDate() + "/"
//    + (currentdate.getMonth() + 1) + "/"
//    + currentdate.getFullYear() + " @ "
//    + currentdate.getHours() + ":"
//    + currentdate.getMinutes() + ":"
//    + currentdate.getSeconds();

//newdate = datetime


/*newdate = console.log(dateObj.toISOString().split('T'));*/




//Insert fill table from form registration to db (create data)
function insert() {
    var obj = new Object(); //sesuaikan sendiri nama objek dan isinya
    // ini ngambil value dari inputan dalam form nya

    let dateObj = new Date();
    let month = dateObj.getUTCMonth() + 1; //months from 1-12
    let day = dateObj.getUTCDate();
    let year = dateObj.getUTCFullYear();
    let hour = dateObj.getHours();
    let minute = dateObj.getMinutes();
    let second = dateObj.getSeconds();

    newdate = year + "-" + month + "-" + day;
    /*newdate1 = hour + ":" + minute + ":" + second + "" + "Wib";*/

    //newdate2 = newdate + newdate1;

    /*newdate = year + "-" + month + "-" + day + "/" + hour + "-" + minute + "-" + second;*/

    console.log(newdate)


    obj.title = $("#title").val();
    obj.message = $("#message").val();
    obj.startDate = newdate;
    obj.updateDate = newdate;
    /* obj.updateDate = $("#updatedate").val();*/
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
