//View Tabel Semua Pokemon
//$.ajax({
//    url: "https://pokeapi.co/api/v2/pokemon"
//}).done((result) => {
//    console.log(result.results);
//    text = "";
//    content = "";
//    no = 1;

//    $.each(result.results, function (key, val) {
//        text += `<tr>
//                    <td>${no++}</td>
//                    <td>${val.name}</td>
//                    <td>${val.url}</td>
//                    <td>
//                        <button class="btn btn-info m-2 PokeView" data-toggle="modal" data-target="#PokeModal" data-url="${val.url}">View</button>
//                    </td>
//                </tr>`;
//    });


//    $("#ListPoke").html(text);

//    //Button on Click
//    $(".PokeView").click(function () {
//        $.ajax({
//            url: $(this).data("url")
//        }).done((result) => {

//            console.log(result);

//            img = result.sprites.front_default;
//            $("#PokeImage").attr("src", img);

//            name = result.name;
//            $("#PokeName").text(name);

//            ability = "Abilities";
//            $.each(result.abilities, function (val) {
//                /*console.log(result.abilities[val].ability.name);*/
//                ability += `<li>${result.abilities[val].ability.name}</li>`
//                //$.each(result.abilities, function (val2) {
//                //    console.log(result.abilities[val2]);
//                //    ///moves += `<>${val.name}</td>`;
//                //}); 
//            });
//            $("#PokeAbility").html(ability);

//            moves = "Moves";
//            $.each(result.moves, function (val) {
//                /*console.log(result.abilities[val].ability.name);*/
//                moves += `<h6><span class="badge badge-secondary badge-pill">${result.moves[val].move.name}</span></h6>`
//                //$.each(result.abilities, function (val2) {
//                //    console.log(result.abilities[val2]);
//                //    ///moves += `<>${val.name}</td>`;
//                //}); 
//            });
//            $("#PokeMove").html(moves);

//        }).fail((error) => {
//            console.log(error);
//        });
//    });

//    $("#ListPoke").modal("handleUpdate");

//}).fail((error) => {
//    console.log(error);
//})
//$(document).ready(function () {
//    $('#PokeTabel').DataTable({
//        "ajax": {
//            url: "https://pokeapi.co/api/v2/pokemon",
//            dataSrc: "results"
//        },
//        "columns": [
//            {
//                "data" : "name"
//            },
//            {
//                "data" : "url"
//            }
//        ]
//    })
//})

$(document).ready(function () {
    $('#PokeTabel').DataTable({
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
            //{
            //    "data": "lastName"
            //},
            {
                "data": null,
                "render": function (data, type, row) {
                    if (row["gender"] == 1) {
                        return "Pria";
                    }
                    if (row["gender"] == 2) {
                        return "Wanita";
                    }
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
            {orderable:false, targets: 10}
        ],
        buttons: {
            buttons: [
                { extend: 'copy', className: 'btn btn-primary' },
                { extend: 'csv', className: 'btn btn-primary' },
                { extend: 'excel', className: 'btn btn-primary' },
                { extend: 'pdf', className: 'btn btn-primary', orientation:'landscape' },
                { extend: 'print', className: 'btn btn-primary' },
            ]
        }
    })
})

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





