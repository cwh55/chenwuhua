/*
*work:后台招商信息管理js
*date：2013年10月28日
*author：陈武华
*/
var checkInfoRelease = function () {
    var self = this;
    self.obj = {
        chk_pass: ".chk_pass",
        chk_nopass: ".chk_nopass", //不通过
        nopass_remark: ".nopass_remark",
        btn_submit: "#layout_ok",
        a_more: $("a[name='more']")
    }
    self.Value = {
        aid: 0,
        t: "",
        m: null,
        v: 0
    };
    self.BindEvent = function () {
        $(self.obj.chk_pass).click(function () { //点击通过
            var id = $(this).attr("autoid");
            var cause = $(this).parent().find(".cause").val();
            self.UpdateIsPass(id, 1, cause)
        });

        $(self.obj.chk_nopass).click(function () {  //点击不通过
            self.Value.aid = parseInt($(this).attr("autoid"));
            $("#approve-layout div.al-header span[name='t']").text($(this).attr("t"));
            $("#approve-layout").show();
            $(this).next().next(self.obj.nopass_remark).show();
        });

        //确定添加审核不通过的原因
        $(self.obj.btn_submit).click(function () {
            var cause = $("#layout_content").val();
            if (cause == "") {
                $.alert({ msg: "请输入原因" });
                return false;
            } else {
                self.UpdateIsPass(self.Value.aid, 2, cause)
            }
        });

        //关闭添加审核不通过的原因窗口
        $("#layout_cancel").click(function () {
            $("#approve-layout").hide();
        });
    }

    //审核通过
    self.UpdateIsPass = function (ID, isPass, Cause) {
        location.href = "checkInfoRelease.aspx?PassID=" + ID + "&passValue=" + isPass + "&Cause=" + Cause;
    }

    self.Invoke = function () {
        self.BindEvent();
    }
}
$(function () {
    new checkInfoRelease().Invoke();
})
