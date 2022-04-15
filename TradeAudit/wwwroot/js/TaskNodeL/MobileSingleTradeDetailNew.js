$(document).ready(function ($) {
    layui.use(['layer', 'table'], function () {
        var layer = layui.layer;
        var table = layui.table;

        //事件>>>返回
        $("#RebackButton").click(function () {
            window.location.href = document.referrer;
        });

        $("#AuditFlowButton").click(function () {
            var aTaskId = $("#aTaskId").val();
            var url = "/TaskNodeL/MobileSingleTaskNodeTreeView?aTaskId=" + aTaskId;
            layer.open({
                type: 2//iframe类型
                , area: ['100%', '70%']
                , title: '流程图'
                , shade: 0.6 //遮罩透明度
                , maxmin: true //允许全屏最小化
                , anim: 1 //0-6的动画形式，-1不开启
                //, content: '<div style="padding:50px;">这是一个非常普通的页面层，传入了自定义的html</div>'
                , content: url
            });
        });
        $("#AuditLogButton").click(function () {
            layer.open({
                offset: ['100px', '350px'],
                type: 1,
                content: "<table id='logTable' lay-filter='test'></table> ", //这里content是一个普通的String
                success: function (layero, index) {
                    var url = "/TaskNodeL/MobileSingleTraceLog";

                    table.render({
                        elem: '#logTable',
                        method: "post",
                        url: url,
                        where: { aTaskId: $("#aTaskId").val() },
                        parseData: function (res) {
                            console.log("res", res);
                            return {
                                "code": "0", //解析接口状态
                                "msg": "查询成功", //解析提示文本
                                "count": res.length, //解析数据长度
                                "data": res //解析数据列表
                            };
                        },
                        height: 312,
                        page: false,//开启分页
                        cols: [[ //表头
                            { field: 'ti', title: '业务编号' }
                            , { field: 'ly', title: '类型' }
                            , { field: 'na', title: '名义审批人' }
                            , { field: 'on', title: '实际审批人' }
                            //, { field: 'rn', title: '审批角色', width: 80, sort: true }
                            , { field: 'sn', title: '日志内容' }
                            , { field: 'an', title: '结果' }
                            , { field: 'ot', title: '时间' }
                        ]]
                    });
                }
            });
        });
        $("#LimitButton").click(function () {
            layer.open({
                offset: ['100px', '350px'],
                type: 1,
                content: "<table border='1' id='limitTabel' lay-filter='test'><tr><th>限额名称</th><th>限额类型</th><th>交易前结果</th><th>交易后结果</th><th>差值</th><th>指标名称</th></tr></table> ", //这里content是一个普通的String
                area: ['800px', '300px'],
                success: function (layero, index) {
                    var url = "/TaskNodeL/MobileSingleLimitresult";

                    $.ajax({
                        type: "POST",
                        url: url,
                        dataType: "json",
                        data: {
                            aTaskId: $("#aTaskId").val()
                        },
                        contentType: "application/x-www-form-urlencoded; charset=utf-8",
                        beforeSend: function () {
                        },
                        complete: function () {
                        },
                        success: function (res) {

                            let trColor = "";
                            //le 0 绿灯 1黄灯 2橙灯 3红灯
                            if (res.le == "0") {
                                trColor = "green";
                                //$("#limitTabel tr").css("background-color", "green")
                            }
                            else if (res.le == "1") {
                                trColor = "yellow";
                                //$("#limitTabel tr").css("background-color", "yellow")
                            }
                            else if (res.le == "2") {
                                trColor = "orange";
                                //$("#limitTabel tr").css("background-color", "orange")
                            }
                            else if (res.le == "3") {
                                trColor = "red";
                                //$("#limitTabel tr").css("background-color", "red")
                            }
                            $("#limitTabel").append("<tr style='background-color:" + trColor + ";'><td>" + res.na + "</td><td>" + res.ty + "</td><td>" + res.bf + "</td><td>" + res.af + "</td><td>" + res.df + "</td><td>" + res.me + "</td></tr>")

                        },
                        error: function (data) {
                            layer.msg(data.responseText);

                        }
                    });

                }
            });

        });
        $("#TradeButton").click(function () {

            $.post('/TaskNodeL/MobileSingleTradeTarget', { aTaskId: $("#aTaskId").val() }, function (str) {

                console.log(str);

                var dataSrt = "<table border='1px'> ";
                dataSrt+="<th>名称：</th><th>值：</th>"

                for (var i = 0; i < str.length; i++) {
                    dataSrt += "<tr><td>" + str[i].name + "</td><td>" + str[i].value +"</td></tr>";
                }
                dataSrt += "</table>";
                layer.open({
                    title:"交易指标",
                    type: 1,
                    content: dataSrt //注意，如果str是object，那么需要字符拼接。
                });
            });

            //alert("交易指标");

            //$.ajax({
            //    type: "POST",
            //    url: url,
            //    dataType: "json",
            //    data: {
            //        aTaskId: $("#aTaskId").val()
            //    },
            //    contentType: "application/x-www-form-urlencoded; charset=utf-8",
            //    beforeSend: function () {
            //    },
            //    complete: function () {
            //    },
            //    success: function (res) {
            //        //le 0 绿灯 1黄灯 2橙灯 3红灯
            //        if (res.le == "0") {

            //            $("#limitTabel").css("background-color", "green")
            //        }
            //        else if (res.le == "1") {
            //            $("#limitTabel").css("background-color", "yellow")
            //        }+
            //        else if (res.le == "2") {
            //            $("#limitTabel").css("background-color", "orange")
            //        }
            //        else if (res.le == "3") {
            //            $("#limitTabel").css("background-color", "red")
            //        }
            //        $("#limitTabel").append("<tr><td>" + res.na + "</td><td>" + res.ty + "</td><td>" + res.bf + "</td><td>" + res.af + "</td><td>" + res.df + "</td><td>" + res.me + "</td></tr>")

            //    },
            //    error: function (data) {
            //        layer.msg(data.responseText);

            //    }
            //});
        });
    });
});