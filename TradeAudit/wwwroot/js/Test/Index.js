$(document).ready(function ($) {
    var baseTable = $('#baseTable').DataTable({
        searching: false,
        ordering: true,
        paging: true,
        autoWidth: true,
        serverSide: false,
        processing: true,
        order: [[0, 'asc']],

        ajax: {
            url: "/TaskNodeL/MobileGetTaskNodeLstByPage",
            type: "post",
            data: function(data) {
                delete data.search;

                var $form = $("#BaseFormId");
                var formData = CommonHelper.serializeFormToObject($form);
                jQuery.extend(data, formData);
            }
        },
        columns: [
            {
                targets: 0,
                searchable: false,
                orderable: false,
                defaultContent: '',
                data: null,
                render: function (data, type, row) {
                    var id = 'cb' + row.id;
                    var html = '<div>';
                    html += '<input type="checkbox" name="' + id + '" id="' + id + '" value="' + row.id + '" class="filled-in chk-col-blue checkbox_select"/>';
                    html += '<label for="' + id + '">';
                    html += '</div>';
                    return html;
                }
            },
            {
                targets: 1,
                orderable: false,
                className: "details-control",
                data: null,
                defaultContent: ""
            },
            {
                "targets": 2,
                "data":"tid"
            },
            {
                "targets": 3,
                "data":"nid",
                "orderable": false
            },
            {
                "targets": 4,
                "data":"gr"

            },
            {
                "targets": 5,
                "data":"id"

            },
            {
                "targets": 4,
                "data": "isccrole",
                "orderable": false,
                render: function (data, type, row) {
                    if (data == "False") {
                        return "否";
                    } else {
                        return "是";
                    }
                }
            },
            {
                "targets": 5,
                "data": "ty",
                "orderable": false
            },
            {
                "targets": 6,
                "data": "or",
                "orderable":false
            },
            {
                "targets": 7,
                render: function (data, type, row) {


                    return "<td data-field='11' data-key='1-0-11' data-off='true' class='layui-table-col-special'><div class='layui-table-cell laytable-cell-1-0-11'> <a class='layui-btn layui-btn-danger layui-btn-xs' lay-event='edit' href='/TaskNodeL/MobileSingleTradeDetailNew?aSysOrdId="+row.id+"'>详情</a> </div></td > ";
                }
            }
        ]
    });

    $("#SumitBtnId").click(function(event) {
        event.preventDefault();
        ReloadTable();
    });

    function ReloadTable() {
        baseTable.ajax.reload();
    }
    layui.use('form');

//    $.post("/Report/GetTotalBaseQty", getFormData(), function(data) {
//        if (data.code == "-1") {
//            console.log(data)
//        }
//        else {
//            var _$stock = $("#StockQuantitySpanId");
//            _$stock.empty();
//            _$stock.text(data.totalQuantity);
//        }
//    });

    $('#select-all').on('click', function () {
        if (this.checked) {
            $('.checkbox_select').prop("checked", true);
        } else {
            $('.checkbox_select').prop("checked", false);
        }
    });
    $("#BatchSumitButton").on('click', function () {
        alert("批量审核同意");
    });
    $("#BatchRefuseButton").on('click', function () {
        alert("批量拒绝");

    });

    $('#baseTable tbody').on('click', 'td.details-control', function () {
        var tr = $(this).closest('tr');
        var row = baseTable.row(tr);

        if (row.child.isShown()) {
            // This row is already open - close it
            row.child.hide();
            tr.removeClass('shown');
        }
        else {
            // Open this row
            row.child(format(row.data())).show();
            tr.addClass('shown');
        }
    });

    getCheckBoxIds = function () {
        var ids = [];
        var checkBoxes = $('.checkbox_select:checked');

        for (var i = 0; i < checkBoxes.length; i++) {
            ids.push(checkBoxes[i].value);
        }
        return ids;
    };
    function getFormData() {
        var $form = $("#BaseFormId");
        var formData = CommonHelper.serializeFormToObject($form);
        return formData;
    }

    function format(d) {
        console.log("d", d);

        var trs = "";

        for (var i = 0; i < d.r.length; i++) {
            var tr = "<tr><td>" + d.r[i].name + "</td><td>" + d.r[i].text + "</td></tr>";
            trs += tr;
        }
        // `d` is the original data object for the row
        return '<table cellpadding="5" cellspacing="0" border="0" style="padding-left:50px;">' +
            trs +
            '</table>';
    }
});

