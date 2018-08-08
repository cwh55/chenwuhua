/*
*work:邮箱云附件的相关事件
*date:2013-8-9
*author:lihui
*/
var Attach = function () {
    //存储对象
    var self = this;

    //dom节点
    self.Obj = {
        nav_del: ".nav-del",
        attach_table: ".attach-table",
        attach_download: ".atl-download",
        attach_send: ".atl-send",
        attach_groupBy: ".attach-grouping-type li",
        attach_Name: ".attach-table .atl-filename .a-filename"
    };


    /* 全选/反选  2013-8-12 */
    Mail_Common.CheckOrUnCheckAll(".CheckOrUnCheckAll", "input[name='chklink']");

    //html内容容器
    self.strs = "";

    //导航删除按钮
    $(self.Obj.nav_del).unbind("click").click(function () {

        //ajax
        var ids = $("input[name='chklink']:checked").length;
        if (ids == 0) {
            alert("请选择删除项")
            return;
        }
        alert("已选择" + ids + " 项删除");
    });


    /* ajax获取数据  2013-8-9 */
    self.AjaxHtml = function () {

        //ajax操作


        //模拟数据
        for (var i = 0; i < 3; i++) {
            self.strs += '<tr>';
            self.strs += '<td class="atl-select"><input type="checkbox" name="chklink"></td>';
            self.strs += '<td class="atl-filename">公司简介以及班车路线以及班车车路线公司简介以及班车路线公司简介以及班车路线.rar</td>';
            self.strs += '<td class="atl-size">2.0k</td>';
            self.strs += '<td class="at-option"><span><a href="javascript:;" class="atl-download">下载</a>|<a href="javascript:;" class="atl-send">发送</a></span></td>';
            self.strs += '<td class="atl-upload-time">2013-07-24</td>';
            self.strs += '<td class="atl-effect-size">7天4小时</td>';
            self.strs += '</tr>';
        }


        $(self.Obj.attach_table).append(self.strs);
    };


    /* 页面点击事件 */
    self.ClickHandle = function () {

        //下载按钮事件
        $(self.Obj.attach_download).unbind("click").bind("click", function () {
            alert($(this).html());

        });


        //发送按钮事件
        $(self.Obj.attach_send).unbind("click").bind("click", function () {
            alert($(this).html());

        });

        //分组筛选事件
        $(self.Obj.attach_groupBy).unbind("click").bind("click", function () {
            $(this).addClass("linkman_visited").siblings().removeClass("linkman_visited");
            alert($(this).find("strong").html());

        });

        //鼠标经过分组列添加的样式
        $(self.Obj.attach_groupBy).unbind("mouseover").mouseover(function () {
            $(this).addClass("linkman_hover");
        });
        //鼠标离开分组列添加的样式
        $(self.Obj.attach_groupBy).unbind("mouseout").mouseout(function () {
            $(this).removeClass("linkman_hover");
        });
    }

    /* 修改附件名称 */
    self.AttachEdit = function () {

        //双击生成文本框
        $(self.Obj.attach_Name).unbind("dblclick").bind("dblclick", function () {
            var value = $(this).html();
            if ($(this).find(".attachInput").length == 0) {
                $(this).html("<input type='text' class='attachInput' value='" + value + "' >");
                $(this).find("input").focus();

            }
        });

        $(".attachInput").unbind("blur").live("blur", function () {

            $(this).parent().html($(this).val());
        })
    }

    //外部调用
    self.Invoke = function () {
        //构造页面
        self.AjaxHtml();
        //页面点击事件调用
        self.ClickHandle();
    }

}

$(function () {
    new Attach().Invoke();

})
