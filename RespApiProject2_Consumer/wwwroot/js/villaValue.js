﻿
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#myTable').DataTable({
        "ajax": {
            url: '/villaValue/getAllVillaValues'
        },
        "columns": [
            { data: 'villaNo', "width": "10%" },
            { data: 'villa.name', "width": "25%" },
            { data: 'villa.rate', "width": "10%" },
            { data: 'villa.occupancy', "width": "15%" },
            { data: 'villa.sqft', "width": "15%" },
            {
                data: 'villaNo',
                "render": function (data) {
                    return `
                        <div class="w-75 btn-group" role="group">
                                <a href="/villaValue/edit?villaNo=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                                <a onClick=Delete('/villaValue/DeleteVillaValue?villaNo=${data}')  class="btn btn-danger mx-2"> <i class="bi bi-pencil-square" ></i> Delete</a>
                         </div> `




                },
                "width": "25%"

            },

        ]
    });
}
function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}
