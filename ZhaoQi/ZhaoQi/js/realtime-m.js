!function(){}();//!
jQuery.noConflict();
jQuery(document).ready(function(jQuery){
	"use strict";
	var tagidObj={
		"温度1-1":"text5491-4",
		"温度1-2":"text5491-4-2",
		"温度2-1":"text5491-9",
		"温度2-2":"text5491-9-1",
		"温度3-1":"text5491-6",
		"温度3-2":"text5491-6-2",
		"温度4-1":"text5491-5",
		"温度4-2": "text5491-5-1",
		"1#进干流量": "text5491",
		"1#进湿阀": "text5491-4-2-0",
		"1#产气": "text5491-4-2-0",
		"2#进干流量": "text5491-0",
		"2#进湿阀": "text5491-9-1-9",
		"2#产气": "text5491-4-2-0",
		"3#进干流量": "text5491-8",
		"3#进湿阀": "text5491-6-2-0",
		"3#产气": "text5491-4-2-0",
		"4#进干流量": "text5491-01",
		"4#进湿阀":"text5491-5-1-4",
		"4#产气": "text5491-4-2-0",
		"罐体压力":"text5491-5-3",
		"供气流量":"text5491-5-8",
		"供气压力":"text5491-5-7",
		"储气压力":"text5491-5-71",
	};
	var tagvalueObj={
	    "温度1-1": "400101",
	    "温度1-2": "400201",
	    "温度2-1": "400301",
	    "温度2-2": "400401",
	    "温度3-1": "400501",
	    "温度3-2": "400601",
	    "温度4-1": "400701",
	    "温度4-2": "400801",
	    "1#进干流量":"400901",
	    "1#进湿阀":"401001",
	    "1#产气": "401101",
	    "2#进干流量": "401201",
	    "2#进湿阀": "401301",
	    "2#产气": "401401",
	    "3#进干流量": "401501",
	    "3#进湿阀": "401601",
	    "3#产气": "401701",
	    "4#进干流量": "401801",
	    "4#进湿阀": "401901",
	    "4#产气": "402001",
	    "罐体压力": "402101",
	    "供气流量": "402201",
	    "供气压力": "402301",
	    "储气压力": "402401",
	};
	init();
	function init(){
		showRealtimeValue();
	}
	function showRealtimeValue(){
		//for(var i in tagidObj){
		//	Snap("#"+tagidObj[i]).node.textContent=tagvalueObj[i];
	    //}.
	    ReadData();
	}
    
    function ReadData() {
        jQuery.get('../api/RealData', function (data) {
            var dataModel = JSON.parse(data);
            for (var i in tagidObj) {
                //Snap("#" + tagidObj[i]).node.textContent = dataModel[tagvalueObj[i]].TagValue + dataModel[tagvalueObj[i]].TagUint;

                jQuery('#' + tagidObj[i] + " tspan").text(dataModel[tagvalueObj[i]].TagValue + dataModel[tagvalueObj[i]].TagUint);
            }
            setTimeout(ReadData, 1000);
        });
    }




});

