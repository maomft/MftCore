//$(document).ready(function ($) {

    layui.use('layer', function () { //独立版的layer无需执行这一句
        var $ = layui.jquery, layer = layui.layer; //独立版的layer无需执行这一句

        var baseTable = $('#baseTable').DataTable({
            searching: false,
            ordering: false,
            paging: false,
            autoWidth: true,
            serverSide: false,
            processing: true,
            order: [[0, 'asc']],

            ajax: {
                url: "/TaskNodeL/MobileGetTaskNodeGroup",
                type: "post",
            },
            columns: [
                {
                    "targets": 0,
                    "data": "n",
                },
                {
                    "targets": 1,
                    "data": "ct",
                },
                {
                    "targets": 2,
                    render: function (data, type, row) {
                        //return "<td data-field='11' data-key='1-0-11' data-off='true' class='layui-table-col-special'><div class='layui-table-cell laytable-cell-1-0-11'> <a class='layui-btn layui-btn-danger layui-btn-xs' lay-event='edit' onClick='showDetail'>详情</a> </div></td > ";

                        return "<button id='DetailButton' onClick=showDetail('"+ row.c + "') class='layui-btn layui-btn-sm  layui-btn-warm'>详情</button>";
                    }
                }
            ]
        });

        $("#SumitBtnId").click(function (event) {
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

        showDetail = function (c) {
            if (c == null || c == '') {
                layer.msg("请选择一条数据");
            }
            var url = '/TaskNodeL/MobileGetTaskNodeGroupDetailView?c=' + c;
            layer.open({
                type: 2//iframe类型
                , area: ['80%', '70%']
                , title: '组合明细'
                , shade: 0.6 //遮罩透明度
                , maxmin: true //允许全屏最小化
                , anim: 1 //0-6的动画形式，-1不开启
                //, content: '<div style="padding:50px;">这是一个非常普通的页面层，传入了自定义的html</div>'
                , content: url
            });
            //alert("显示列表数据");
        };
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

    
//});

