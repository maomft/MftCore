$(document).ready(function () {
    $('#example').DataTable();
});
layui.use(['form', 'layedit', 'laydate'], function () {
    var form = layui.form
        , layer = layui.layer
        , layedit = layui.layedit
        , laydate = layui.laydate;

    //自定义验证规则
    form.verify({
        title: function (value) {
            if (value.length < 5) {
                return '标题也太短了吧';
            }
        }
        , pass: [/(.+){6,12}$/, '密码必须6到12位']
        , money: [
            /^\d+\.\b\d{2}\b$/
            , '金额必须为小数保留两位'
        ]
    });

    //日期
    laydate.render({
        elem: '#date'
    });

    //初始赋值
    var thisValue = form.val('first', {
        'title': '测试'
        , 'phone': 11111111111
        , 'email': 'xu@sentsin.com'
        , 'password': 123123
        //,'quiz': 2
        , 'interest': 3
        , 'like[write]': true
        //,'open': false
        , 'sex': '男'
        , 'desc': 'form 是我们非常看重的一块'
        , xxxxxxxxx: 123
    });
    console.log(thisValue);


    //事件监听
    form.on('select', function (data) {
        console.log('select: ', this, data);
    });

    form.on('select(quiz)', function (data) {
        console.log('select.quiz：', this, data);
    });

    form.on('select(interest)', function (data) {
        console.log('select.interest: ', this, data);
    });



    form.on('checkbox', function (data) {
        console.log(this.checked, data.elem.checked);
    });

    form.on('switch', function (data) {
        console.log(data);
    });

    form.on('radio', function (data) {
        console.log(data);
    });

    //监听提交
    form.on('submit(*)', function (data) {
        console.log(data)
        alert(JSON.stringify(data.field));
        return false;
    });
});