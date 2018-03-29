
    //var allItem = new Array();
    var imgurl = "http://www.swtychina.com/gb/images/download16.gif";
    var playerImgUrl = "http://swtychina.com/gb/images/ting.gif";
    var evenNumber = 0;
    var arrmonth = ["1","2","3","4","5","6","7","8","9","10","11","12"];
    //var isLoadLatestItem = false;

    function toggleLoadingControls(loading) {
        if (loading) {
            document.querySelector('.spinner').setAttribute('class', "spinner");            
        }
        else {
            document.querySelector('.spinner').setAttribute('class', "spinner hidden");
        }
    }

    function getSwtyItemsData(valuesDate){
        //var server = 'http://api.swtychina.com/api/values?';
        var server = 'http://ceshnjd.imwork.net:41689/api/values?';
        // 删除原有节目
        deleteProgramList("ProgramList");
        toggleLoadingControls(true);
        $.ajax({
            url: server + valuesDate,
            type: 'GET',
            dataType: 'json',
            timeout: 10000,
            error: function(data){
                alert('不要着急我正在加载~？');
                toggleLoadingControls(false);
            },
            success: function(data){
                
                var parent = document.getElementById("ProgramList");
                var auditonUrl = "http://swtychina.com/gb/audiodoc";
                $.each(data, function (index, val) {
                    var itemDate = val.date.substring(0, 10);

                    var year = val.date.substring(0, 4);
                    var month = year + val.date.substring(5, 7);
                    var day = month + val.date.substring(8, 10);
                    // 下载地址：http://swtychina.com/gb/audiodoc/2018/201801/20180101.mp3
                    var Url = auditonUrl+ "/" + year + "/" + month + "/" + day + ".mp3";

                    // 去掉山外天园节目title前缀“小贝回来了(000):”
                    //var mccItemTitle = val.title.slice(11, val.title.length);
                    var mccItemTitle = val.title;
                    var item = { date:itemDate, url:Url, title:mccItemTitle};
                    //console.log("getSwtyItemsDate()->isLoadLatestItem",isLoadLatestItem);
                    loadItem(parent, item,evenNumber%2 != 0);
                    evenNumber++;
                });
                evenNumber = 0;
                //isLoadLatestItem = false;
                //console.log("Allitem:",allItem);
                toggleLoadingControls(false);
            }
        });
    }

    // swty:   http://api.swtychina.com/api/values
    // mcchome: http://api.swtychina.com/api/swtymp3?path=mcchome/2018/201801
    // date=2010-**
    // ?date=2010-01
    function loadLatestItem(id)
    {
        //isLoadLatestItem = true;
        //console.log("loadLatestItems()->isLoadLatestItem",isLoadLatestItem );
        getSwtyItemsData();
    }

    function deleteProgramList(id)
    {
        var parent = document.getElementById(id);
        var childslength = document.getElementsByName("item").length;

        //console.log("parent", parent);
        //console.log("document.getElementById" ,document.getElementsByName("item"));
        //parent.remove(parent.getElementsByTagName("p"));
        for (let index = 0; index < childslength; index++) {
            parent.removeChild(document.getElementsByName("item")[0]);
        //console.log(parent);                
        }
    }

    function playMe(me) {
        console.log("me:", me);
        document.getElementById("player_title").innerHTML = me.parentNode.textContent.substring(10,me.parentNode.textContent.length);

        var x = document.getElementById("player");
        x.setAttribute("src", me.getAttribute("playurl"));
        x.play();
    }

    function loadItem(parent,data,ishavebackgrouad) {
        // <div class="row" name="item">   //parent_div 
        //     <div class="col-sm-2 col-xs-6">2018-01-01</div>   // child_div1
        //     <div class="col-sm-1 col-xs-6"><a href="#"><img src="http://www.swtychina.com/gb/images/download16.gif" class="mccDownloadImg"></a></div>  //child_div2
        //     <div class="col-sm-4 col-xs-12"><span class="mccSpace">世外桃源再回到休斯敦本地电台传福音</span></div>  //child_div3
        // </div>
        //var parent = document.getElementById(id);
        var parent_div = document.createElement("div");
        if (ishavebackgrouad) {
            parent_div.setAttribute("class", "row mccItembackground");                
        }
        else{
        parent_div.setAttribute("class", "row mccItem");
        }

        //parent_div.setAttribute("className","row");
        parent_div.setAttribute("name","item");
        //console.log("parent_div",parent_div);
        parent.appendChild(parent_div);

        // date div begin
        var child_div1 = document.createElement("div");
        child_div1.setAttribute("class","col-sm-2 col-xs-6");
        var node1 = document.createTextNode(data.date);
        child_div1.appendChild(node1);
        parent_div.appendChild(child_div1);
        // date div end

        // player div begin
        var child_div_player = document.createElement("div");
        child_div_player.setAttribute("class","col-sm-1 col-xs-3");
        child_div_player.setAttribute("onclick","playMe(this);");
        child_div_player.setAttribute("playurl",data.url);
        child_div_player.setAttribute("id", "playItem");
        parent_div.appendChild(child_div_player);

        var child_div_player_a = document.createElement("a");
        child_div_player_a.setAttribute("href","javascript:void(0)");
        child_div_player.appendChild(child_div_player_a);

        var child_div_player_a_img = document.createElement("img");
        child_div_player_a_img.setAttribute("src",playerImgUrl);
        child_div_player_a_img.setAttribute("class","mccDownloadImg");
        child_div_player_a.appendChild(child_div_player_a_img);
        // player div end

        // download div begin
        var child_div2 = document.createElement("div");
        child_div2.setAttribute("class","col-sm-1 col-xs-3");
        parent_div.appendChild(child_div2);

        var child_div2_a = document.createElement("a");
        child_div2_a.setAttribute("href",data.url);
        child_div2_a.setAttribute("target","_blank");
        child_div2.appendChild(child_div2_a);

        var child_div2_a_img = document.createElement("img");
        child_div2_a_img.setAttribute("src",imgurl);
        child_div2_a_img.setAttribute("class","mccDownloadImg");
        child_div2_a.appendChild(child_div2_a_img);
        // download div end

        // title div begin
        var child_div3 = document.createElement("div");
        child_div3.setAttribute("class", "col-sm-8 col-xs-12");
        child_div3.setAttribute("onclick", "playMe(this);");
        child_div3.setAttribute("playurl", data.url);

        parent_div.appendChild(child_div3);

        var node2 = document.createTextNode(data.title);
        child_div3.appendChild(node2);
        // title div end
    }

    function searchItem() {

        //isLoadLatestItem = true;           
        var input_value = document.getElementById("itemname").value;
        //console.log("nodeValue",input_value);
        if (input_value.length == 0) {
            alert("请输入搜素关键字~！");
            return;
        }
        // 删除原有节目
        deleteProgramList("ProgramList");
        var search_value = "date=" + input_value;
        //console.log("search_value:",search_value);
        //console.log("isLoadLatestItem",isLoadLatestItem);
        getSwtyItemsData(search_value);
    }

    function updateYearNavigation(yearmonth) {
        var value = yearmonth;
        var str = "";
        for (var nIndex = 1; nIndex < 13; nIndex++)
        {
            value++;
            $("#" + nIndex).text(value);

            //getSwtyItemsData('date=2018-01')
            str = value;
            var year = String(str).substring(0, 4);
            var month = String(str).substring(4, 6);
            var attr = "getSwtyItemsData(\'date=" + year +"-"+ month + "\')";
            $("#" + nIndex).attr("onclick", attr);
        }
    }
    //$(function () { $('#collapseyear').collapse('toggle') });
    //$(function () { $('#collapseyear').collapse('show') });
    $(function () { $('#collapseBiblestudy').collapse('hide') });

    $(document).ready(function () {
        console.log("ready:");
        
        loadLatestItem();        

        $("a[id='otheryear']").click(function () { 
            console.log("a[id='otheryear']");
            var year = $(this).text();
            var yearuse = year.substring(0, 4);

            // 更新选择年份的1月的节目
            console.log("date=" + "yearuse" + "-" + "01");
            getSwtyItemsData("date="+yearuse+"-"+"01"); 
            // 将选择置为当前            
            $("#currentyear").text(year);
            // 更新当前节目导航
            $("#itemsNavigationYear").text(year);
            updateYearNavigation(Number(yearuse)*100);
        });


        $("#ProgramList").click(function () {
            console.log("#playItem:click()");
            $("#swtyChinaPlayer").attr("class", "navbar navbar-default navbar-fixed-bottom mccPlayerbackground");
        });

        //$("#playItem").click(function () {
        //    console.log(".mccDownloadImg:click()");
        //    $("#swtyChinaPlayer").attr("class", "navbar navbar-default navbar-fixed-bottom mccPlayerbackground");            
        //});
    });