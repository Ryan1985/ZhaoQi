!function () { }();//!
jQuery.noConflict();
jQuery(document).ready(function (jQuery) {
    "use strict";
    var tagidObj = {
        "罐体1产气": "text4166",
        "罐体2产气": "text4166-1",
        "罐体3产气": "text4166-8",
        "罐体4产气": "text4166-5",
        "罐体1进干": "text4166-7",
        "罐体2进干": "text4166-77",
        "罐体3进干": "text4166-4",
        "罐体4进干": "text4166-10",
        "罐体1-1温度": "text4166-16",
        "罐体1-2温度": "text4166-14",
        "罐体2-1温度": "text4166-104",
        "罐体2-2温度": "text4166-3",
        "罐体3-1温度": "text4166-6",
        "罐体3-2温度": "text4166-2",
        "罐体4-1温度": "text4166-0",
        "罐体4-2温度": "text4166-71",
        "罐体1进湿": "text4166-67",
        "罐体2进湿": "text4166-50",
        "罐体3进湿": "text4166-48",
        "罐体4进湿": "text4166-15",
        "供气流量1": "text4166-480",
        "供气流量2": "text4166-40",
        "罐体压力": "text4166-56",
        "供气压力": "text4166-776",
        "储气压力": "text4166-02",
    };
    //var tagvalueObj={
    //    "温度1-1": "400101",
    //    "温度1-2": "400201",
    //    "温度2-1": "400301",
    //    "温度2-2": "400401",
    //    "温度3-1": "400501",
    //    "温度3-2": "400601",
    //    "温度4-1": "400701",
    //    "温度4-2": "400801",
    //    "1#进干流量":"400901",
    //    "1#进湿阀":"401001",
    //    "1#产气": "401101",
    //    "2#进干流量": "401201",
    //    "2#进湿阀": "401301",
    //    "2#产气": "401401",
    //    "3#进干流量": "401501",
    //    "3#进湿阀": "401601",
    //    "3#产气": "401701",
    //    "4#进干流量": "401801",
    //    "4#进湿阀": "401901",
    //    "4#产气": "402001",
    //    "罐体压力": "402101",
    //    "供气流量": "402201",
    //    "供气压力": "402301",
    //    "储气压力": "402401",
    //};
    init();
    function init() {
        showRealtimeValue();
    }
    function showRealtimeValue() {
        for (var i in tagidObj) {
            Snap("#" + tagidObj[i]).node.textContent = "null";
        }
        ReadData();
    }

    function ReadData() {
        jQuery.get('../api/RealData', function (data) {
            var dataModel = JSON.parse(data);
            var i = 4001;
            while (i <= 4024) {
                var tagid = dataModel[i.toString() + "01"];
                var tagname = tagid["TagDesc"];
                var tagvalue = tagid["TagValue"];
                var taguint = tagid["TagUint"];
                var tagdomid = tagidObj[tagname];
                if (Snap("#" + tagdomid)) {
                    Snap("#" + tagdomid).node.textContent = tagvalue + taguint;
                }
                // jQuery('#' + tagidObj[i] + " tspan").text(dataModel[tagvalueObj[i]].TagValue + dataModel[tagvalueObj[i]].TagUint);
                i += 1;
            }
            for (var i in tagidObj) {
                var nodetext = Snap("#" + tagidObj[i]).node.textContent;
                console.log(Snap("#" + tagidObj[i]));
                if (nodetext == "null") {
                    Snap("#" + tagidObj[i]).node.style.fill = "red";
                }
            }
            setTimeout(ReadData, 1000);
        });
    }




});

